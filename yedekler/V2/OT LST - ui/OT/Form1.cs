using System;
using MetroSet_UI.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using Microsoft.VisualBasic;
using MySql.Data.EntityFramework;
namespace OT
{
	public partial class Form1 : MetroSetForm
	{
        #region variables
        public static string sw, db, uid, pwd, st, myip;
        public bool connected = false;
        #region EDS
        public DateTime currentDate;
        public int currentMonth, currentYear, k, idForEdit;
        public string[] dedicatedWord;
        public string isLikely, barcodeForEdit;
        public bool machineWriting = false, comingFrom;
        public DataTable pTable = new DataTable();
        public MySqlDataAdapter isAdapter;
        #endregion
        #region ortak
        public MySqlConnection _conn = new MySqlConnection(st);
        public MySqlCommand _cmd;
        public MySqlDataReader dreader;
        #endregion
        #region Main
        public DataTable sellTable = new DataTable();
        public double totalPrice=0;
        public string regDateMain;
        public bool scanBool, deleteBool, sellBool, editingNow;
        #endregion
        #region log
        public DataTable lTable = new DataTable();
        public MySqlDataAdapter logAdapter;
        #endregion
        #endregion

        public Form1()
		{
            InitializeComponent();
            //main
            datagridEds.RowHeadersVisible = false;
            datagridLog.RowHeadersVisible = false;
            datagridMain.RowHeadersVisible = false;
            sellTable.Columns.Add("URUN").ReadOnly = true;
            sellTable.Columns.Add("BARKOD").ReadOnly = true;
            sellTable.Columns.Add("ADET");
            sellTable.Columns.Add("STOK").ReadOnly = true;
            sellTable.Columns.Add("FIYAT").ReadOnly = true;
            sellTable.Columns.Add("TOPLAM");
            //main
            datagridMain.DataSource = sellTable;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default["server"].ToString()) || string.IsNullOrWhiteSpace(Properties.Settings.Default["db"].ToString()) || string.IsNullOrWhiteSpace(Properties.Settings.Default["id"].ToString())) metroSetButton2.Enabled = false;
            #region textboxConfig
            pNameEds.MaxLength = 25;
            pCountEds.MaxLength = 6;
            pPriceEds.MaxLength = 8;
            pBarcode.MaxLength = 30;
            pAboutEds.MaxLength = 255;
            #endregion
            #region tarih
            currentDate = DateTime.Now;
            currentMonth = Convert.ToInt32(currentDate.ToString("MM"));
            currentYear = Convert.ToInt32(currentDate.ToString("yyyy"));
            #endregion
        }
        #region menu
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connected)
            {
                if (logTab.SelectedTab == logTab.TabPages["login"])
                {
                    logTab.SelectedTab = tabPageFirst;
                }

                else if (logTab.SelectedTab == logTab.TabPages["tabPageFirst"])
                {
                    getProducts();
                }
                else if (logTab.SelectedTab == logTab.TabPages["tabPageSecond"])
                {
                    scanBool = true;
                    deleteBool = false;
                    sellBool = false;
                    editingNow = false;
                    sellTable.Clear();
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else if (logTab.SelectedTab == logTab.TabPages["tabPageThird"])
                {
                    getLogs();
                }
            }
            else
            {
                if (logTab.SelectedTab == logTab.TabPages["login"]) return;
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show("Giriş Yapmalısınız", "SORUN VAR!", buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    logTab.SelectedTab = login;
                }
                else
                {
                    Application.Exit();
                }
            }

        }
        #endregion

        #region EDS
        #region callbacks

        private void editProduct(string name, string about, string eq, string count, string price, string barcode, string exdate)
        {
            string regdate = DateAndTime.Now.ToString("dd-MM-yyyy-H-mm");
            string query = "UPDATE products SET pName='"+name+"', pAbout='"+about+"', pEquivalent='"+eq+"', pCount='"+count+"', pPrice='"+price+"', pBarcode='"+barcode+"', pExDate='"+exdate+"' WHERE id='"+idForEdit+"'";
            _cmd = new MySqlCommand(query, _conn);
            try
            {
                _conn.Open();
                isAdapter = new MySqlDataAdapter(_cmd);
                isAdapter.UpdateCommand = _conn.CreateCommand();
                isAdapter.UpdateCommand.CommandText = query;
                if (isAdapter.UpdateCommand.ExecuteNonQuery() > 0 && showExtrasBoxEds.Checked)
                {
                    MessageBox.Show("kayıt başarılı: "+idForEdit.ToString());
                }
                _conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                _conn.Close();
            }
            getProducts();
        }
        private void addProduct(string name, string about, string eq, string count, string price, string barcode, string exdate)
        {
            string regdate = DateAndTime.Now.ToString("dd-MM-yyyy-H-mm");
            string query = "INSERT INTO products (pName, pAbout, pEquivalent, pCount, pPrice, pBarcode, pExDate, pRegDate) VALUES (@name,@about,@eq,@count,@price,@barcode,@exdate,@regdate)";
            _cmd = new MySqlCommand(query, _conn);

            _cmd.Parameters.AddWithValue("@name", name);
            _cmd.Parameters.AddWithValue("@about", about);
            _cmd.Parameters.AddWithValue("@eq", eq);
            _cmd.Parameters.AddWithValue("@count", count);
            _cmd.Parameters.AddWithValue("@price", price);
            _cmd.Parameters.AddWithValue("@barcode", barcode);
            _cmd.Parameters.AddWithValue("@exdate", exdate);
            _cmd.Parameters.AddWithValue("@regdate", regdate);


            try
            {
                _conn.Open();
                if (_cmd.ExecuteNonQuery() > 0 && showExtrasBoxEds.Checked)
                {
                    MessageBox.Show("kayıt başarılı: "+ name);
                }
                _conn.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
                _conn.Close();
            }
            getProducts();
        }
        private void deleteFromDb(string id, string pn)
        {
            if (!string.IsNullOrEmpty(id))
            {
                id = id.Remove(id.Length - 1);
                id.Trim();
                dedicatedWord = id.Split(',');
            }
            if (datagridEds.SelectedRows != null && datagridEds.SelectedRows.Count > 0)
            {
                try
                {
                    if (dedicatedWord.Length == 1 && showExtrasBoxEds.Checked)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        DialogResult result = MessageBox.Show("Bu İşlem Geri Alınamaz: " + pn, "SİLMEK İSTEDİĞİNE EMİN MİSİN?", buttons, MessageBoxIcon.Warning);
                        if (result == DialogResult.Cancel)
                        {
                            return;
                        }
                    }
                    _conn.Open();
                    for (int i = 0; i < dedicatedWord.Length; i++)
                    {
                        string sql = "DELETE FROM products WHERE id=" + dedicatedWord[i] + "";
                        _cmd = new MySqlCommand(sql, _conn);
                        isAdapter = new MySqlDataAdapter(_cmd);
                        isAdapter.DeleteCommand = _conn.CreateCommand();
                        isAdapter.DeleteCommand.CommandText = sql;
                        _cmd.ExecuteNonQuery();
                    }
                    _conn.Close();
                    getProducts();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                    _conn.Close();
                }
                clearInputs();
                Array.Clear(dedicatedWord, 0, dedicatedWord.Length);

            }
        }
        private void getProducts()
        {
            pTable.Clear();
            clearInputs(); //formu temizle

            //tabloyu çek
            isAdapter = new MySqlDataAdapter(_cmd);
            string query = "select * from products";
            _cmd = new MySqlCommand(query, _conn);
            isAdapter.SelectCommand = _cmd;
            isAdapter.Fill(pTable);
            datagridEds.DataSource = pTable;
            getLikely(); //muadilleri çek
            datagridEds.Columns["id"].HeaderText = "ID";
            datagridEds.Columns["pName"].HeaderText = "ÜRÜNLER";
            datagridEds.Columns["pAbout"].HeaderText = "AÇIKLAMA";
            datagridEds.Columns["pCount"].HeaderText = "ADET";
            datagridEds.Columns["pPrice"].HeaderText = "FİYAT";
            datagridEds.Columns["pBarcode"].HeaderText = "BARKOD";
            datagridEds.Columns["pEquivalent"].HeaderText = "MUADİLLER";
            datagridEds.Columns["pExDate"].HeaderText = "SKT";
            datagridEds.Columns["pRegDate"].HeaderText = "KAYIT";
        }
        private void clearInputs()
        {
            pNameEds.Clear();
            pBarcode.Clear();
            pCountEds.Clear();
            pPriceEds.Clear();
            pAboutEds.Clear();
            pDateEds.Value = DateTime.Now;
            pEquivalentEds.Items.Clear();
        }
        private void getLikely()
        {
            productBoxEds.Items.Clear();
            foreach (DataGridViewRow row in datagridEds.Rows)
            {
                if (productBoxEds.Items.Count > 0)
                {
                    for (int i = 0; i < productBoxEds.Items.Count; i++)
                    {
                        string value = productBoxEds.GetItemText(productBoxEds.Items[i]);
                        if (value == row.Cells["pName"].Value.ToString())
                        {
                            productBoxEds.Items.Remove(value);
                            break;
                        }
                    }
                }
                productBoxEds.Items.Add(row.Cells["pName"].Value.ToString());
            }
        }
        #endregion

        #region butonlar

        #region ekle butonu
        private void addBtn_Click(object sender, EventArgs e)
        {
            #region kontroller
            //muadilleri al
            isLikely = null; //muadilleri temizle
            foreach (string s in pEquivalentEds.Items) isLikely += s + ",";//muadilleri yazdır
            if(!string.IsNullOrEmpty(isLikely)) isLikely = isLikely.Remove(isLikely.Length - 1);//sondaki virgülü sil

            //verileri al
            string isName ="", isCount="", isPrice="", isBarcode="", isAbout="", isExpDate="";
            int expMonth, expYear, expResult;
            isName = pNameEds.Text;
            isName = isName.Trim();
            isCount = pCountEds.Text;
            isPrice = pPriceEds.Text;
            isAbout = pAboutEds.Text;
            isBarcode = pBarcode.Text;
            
            //ürün, miktar, fiyat uygunluk kontrolü
            if(string.IsNullOrWhiteSpace(isName) ||string.IsNullOrWhiteSpace(isCount)||string.IsNullOrWhiteSpace(isPrice) || string.IsNullOrWhiteSpace(isBarcode))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Zorunlu Kısımları Doldurunuz", "SORUN VAR!", buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    return;
                }
            }
            
            //tarih eklenecekse, kontrol
            if (dateCheckBoxEds.Checked)
            {
                isExpDate = pDateEds.Value.ToString("MM-yyyy");
                expMonth = Convert.ToInt32(pDateEds.Value.ToString("MM"));
                expYear = Convert.ToInt32(pDateEds.Value.ToString("yyyy"));
                if (expYear < currentYear || expYear == currentYear && expMonth <= currentMonth)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show("Geçerli Bir SKT Giriniz", "SORUN VAR!", buttons, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        return;
                    }

                }
                if (dateExtraBox.Checked)
                {
                    expResult = ((expYear - currentYear) * 12) + (expMonth - currentMonth);
                    if (expResult < 12)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Ürünün miyadı " + expResult + " ay sonra dolmakta, yine de kaydedelim mi?", "UYARI", buttons, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                    }
                }
            }

            //aynı barkod var mı
            DataView dv = new DataView(pTable);

            foreach (DataRowView rowView in dv)
            {
                if (rowView["pBarcode"].ToString() == isBarcode)//eşleşme varsa
                {
                    MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
                    DialogResult result = MessageBox.Show("Barkod Zaten Bu Ürüne Tanımlı: " + rowView["pName"].ToString(), "SORUN VAR!", buttons, MessageBoxIcon.Warning);
                    
                    if (result == DialogResult.Retry) // düzenle, select row
                    {
                        comingFrom = true;
                        checkboxEdit.Checked = true;
                        return;
                    }
                    else if (result == DialogResult.Abort) //iptal et, formu sıfırla
                    {
                        clearInputs();
                        getLikely();
                        return;
                    }
                    else if (result == DialogResult.Ignore) //yeni barkod gir, return
                    {
                        return;
                    }
                }
            }
            #endregion
            

            //kayıt başladı
            addProduct(isName,isAbout,isLikely,isCount,isPrice,isBarcode,isExpDate);
            //kayıt bitti
        }
        #endregion
        #region sil butonu
        private void deleteBtnEds_Click(object sender, EventArgs e)
        {
            string selected = "", pname="";
            foreach (DataGridViewRow row in datagridEds.SelectedRows)
            {
                selected += datagridEds.Rows[row.Index].Cells["id"].Value.ToString()+",";
                pname = datagridEds.Rows[row.Index].Cells["pName"].Value.ToString();
            }
            deleteFromDb(selected, pname);
        }
        
        #endregion
        #region edit butonu
        private void editBtnEds_Click(object sender, EventArgs e)
        {
            #region kontroller
            //muadilleri al
            isLikely = null; //muadilleri temizle
            foreach (string s in pEquivalentEds.Items) isLikely += s + ",";//muadilleri yazdır
            if (!string.IsNullOrEmpty(isLikely)) isLikely = isLikely.Remove(isLikely.Length - 1);//sondaki virgülü sil

            //verileri al
            string isName = "", isCount = "", isPrice = "", isBarcode = "", isAbout = "", isExpDate = "";
            int expMonth, expYear, expResult;
            isName = pNameEds.Text;
            isName = isName.Trim();
            isCount = pCountEds.Text;
            isPrice = pPriceEds.Text;
            isAbout = pAboutEds.Text;
            isBarcode = pBarcode.Text;

            //ürün, miktar, fiyat uygunluk kontrolü
            if (string.IsNullOrWhiteSpace(isName) || string.IsNullOrWhiteSpace(isCount) || string.IsNullOrWhiteSpace(isPrice) || string.IsNullOrWhiteSpace(isBarcode))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Zorunlu Kısımları Doldurunuz", "SORUN VAR!", buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    return;
                }
            }

            //tarih eklenecekse, kontrol
            if (dateCheckBoxEds.Checked)
            {
                isExpDate = pDateEds.Value.ToString("MM-yyyy");
                expMonth = Convert.ToInt32(pDateEds.Value.ToString("MM"));
                expYear = Convert.ToInt32(pDateEds.Value.ToString("yyyy"));
                if (expYear < currentYear || expYear == currentYear && expMonth <= currentMonth)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show("Geçerli Bir SKT Giriniz", "SORUN VAR!", buttons, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        return;
                    }

                }
                if (dateExtraBox.Checked)
                {
                    expResult = ((expYear - currentYear) * 12) + (expMonth - currentMonth);
                    if (expResult < 12)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Ürünün miyadı " + expResult + " ay sonra dolmakta, yine de kaydedelim mi?", "UYARI", buttons, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                    }
                }
            }

            //aynı barkod var mı
            DataView dv = new DataView(pTable);
            foreach (DataRowView rowView in dv)
            {

                if (rowView["pBarcode"].ToString() == isBarcode)//eşleşme varsa
                {
                    if (rowView["pBarcode"].ToString() != barcodeForEdit)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result = MessageBox.Show("Bu Barkod Zaten Başka Ürüne Tanımlı: " + rowView["pName"].ToString(), "SORUN VAR!", buttons, MessageBoxIcon.Warning);
                        if (result == DialogResult.OK)
                        {
                            return;
                        }
                        return;
                    }
                }
            }
            #endregion
            //düzenle
            editProduct(isName, isAbout, isLikely, isCount, isPrice, isBarcode, isExpDate);
            //düzenle
        }
        #endregion

        #endregion

        #region characterCasing
        private void pPriceEds_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)8) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //if ((e.KeyChar == '.') && (((sender as TextBox).Text.Split('.').Length-1) > 2)) //3 defa nokta

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) // "." basıldıysa ve "." bulunduysa (. yoksa -1 döndürür)
            {
                e.Handled = true;
            }
        }

        private void pCountEds_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)8) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pNameEds_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(pTable);
            TextBox currentContainer = ((TextBox)sender);
            int caretPosition = currentContainer.SelectionStart;

            currentContainer.Text = currentContainer.Text.ToUpper();
            currentContainer.Text = currentContainer.Text.Replace("İ", "I");
            currentContainer.Text = currentContainer.Text.Replace("Ç", "C");
            currentContainer.Text = currentContainer.Text.Replace("Ğ", "G");
            currentContainer.Text = currentContainer.Text.Replace("Ö", "O");
            currentContainer.Text = currentContainer.Text.Replace("Ş", "S");
            currentContainer.Text = currentContainer.Text.Replace("Ü", "U");
            currentContainer.SelectionStart = caretPosition++;
            if (!machineWriting)
            {
                if (string.IsNullOrEmpty(currentContainer.Text))
                {
                    datagridEds.DataSource = pTable;
                }
                else
                {
                    dv.RowFilter = string.Format("pName LIKE '%{0}%'", currentContainer.Text);
                    datagridEds.DataSource = dv;
                }
            }
        }

        #endregion

        #region Boxes
        private void productBoxEds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productBoxEds.SelectedItem != null)
            {
                if (pEquivalentEds.Items.Count < 5 && productBoxEds.SelectedItem.ToString() != pNameEds.Text)
                {
                    if (productBoxEds.SelectedItem != null) pEquivalentEds.Items.Add(productBoxEds.SelectedItem);
                    productBoxEds.Items.Remove(productBoxEds.SelectedItem);
                }
            }

        }
        private void pEquivalentEds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pEquivalentEds.SelectedItem != null) productBoxEds.Items.Add(pEquivalentEds.SelectedItem);
            pEquivalentEds.Items.Remove(pEquivalentEds.SelectedItem);
        }

        #endregion

        #region checkBoxes
        private void checkboxEdit_CheckedChanged(object sender)
        {
            barcodeForEdit = null;
            idForEdit = 0;
            if (checkboxEdit.Checked)
            {
                checkBoxDelete.Checked = false;
                labelEdsTicket.Text = "Düzenleme modundasınız.";
                if (comingFrom)
                {
                    DataView dv = new DataView(pTable);
                    dv.RowFilter = string.Format("pBarcode LIKE '%{0}%'", pBarcode.Text);
                    datagridEds.DataSource = dv;
                    datagridEds_CellClick(datagridEds, new DataGridViewCellEventArgs(0, 0));
                }
                comingFrom = false;
                checkBoxDelete.Enabled = false;
                editBtnEds.Enabled = true;
                addBtnEds.Enabled = false;
                deleteBtnEds.Enabled = false;
            }
            else
            {
                labelEdsTicket.Text = "EDS";
                checkBoxDelete.Enabled = true;
                editBtnEds.Enabled = false;
                addBtnEds.Enabled = true;
                deleteBtnEds.Enabled = true;
                clearInputs();
                dateCheckBoxEds.Checked = false;
                getLikely();
            }
        }
        private void checkBoxDelete_CheckedChanged(object sender)
        {
            if (checkBoxDelete.Checked)
            {
                checkboxEdit.Checked = false;
                labelEdsTicket.Text = "Toplu Silme modundasınız.";
                checkboxEdit.Enabled = false;
                datagridEds.MultiSelect = true;
            }
            else
            {
                labelEdsTicket.Text = "EDS";
                datagridEds.MultiSelect = false;
                datagridEds.ClearSelection();
                checkboxEdit.Enabled = true;
            }
        }

 

        private void dateCheckBoxEds_CheckedChanged(object sender)
        {
            if (dateCheckBoxEds.Checked)
                pDateEds.Enabled = true;
            else
                pDateEds.Enabled = false;
        }

        private void metroSetButton3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(myip);
            metroSetButton3.Text = "KOPYALANDI";
            metroSetButton3.Enabled = false;
        }

        private void datagridMain_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Focus();
        }


        #endregion

        #region dataGrid Event
        private void datagridEds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            k = e.RowIndex;
            if (k > -1)
            {
                string sub = datagridEds[e.ColumnIndex, e.RowIndex].Value.ToString();
                string head = datagridEds.Columns[e.ColumnIndex].HeaderText.ToString();
                explainerEds.Text = head + ": " + sub;
            }
            int rowIndex = -1;
            string eq = "", exdate = "";
            if (checkboxEdit.Checked)
            {
                DataView dv = new DataView(pTable);
                machineWriting = true;
                clearInputs();
                getLikely();
                string b = datagridEds.CurrentRow.Cells[1].Value.ToString();
                foreach (DataGridViewRow row in datagridEds.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(b))
                    {
                        rowIndex = row.Index;
                        break;
                    }
                }
                idForEdit = Convert.ToInt32(datagridEds.Rows[rowIndex].Cells["id"].Value);
                barcodeForEdit = datagridEds.Rows[rowIndex].Cells["pBarcode"].Value.ToString();
                pNameEds.Text = datagridEds.Rows[rowIndex].Cells["pName"].Value.ToString();
                pAboutEds.Text = datagridEds.Rows[rowIndex].Cells["pAbout"].Value.ToString();
                pCountEds.Text = datagridEds.Rows[rowIndex].Cells["pCount"].Value.ToString();
                pPriceEds.Text = datagridEds.Rows[rowIndex].Cells["pPrice"].Value.ToString();
                pBarcode.Text = datagridEds.Rows[rowIndex].Cells["pBarcode"].Value.ToString();
                eq = datagridEds.Rows[rowIndex].Cells["pEquivalent"].Value.ToString();
                exdate = datagridEds.Rows[rowIndex].Cells["pExDate"].Value.ToString();

                labelEdsTicket.Text = "ID: "+idForEdit.ToString() + " düzenliyorsunuz";
                
                dv.RowFilter = string.Format("pBarcode LIKE '%{0}%'", pBarcode.Text);
                datagridEds.DataSource = dv;
                machineWriting = false;
                if (!string.IsNullOrEmpty(eq))
                {
                    eq.Trim();
                    string[] words = eq.Split(',');
                    foreach (var word in words)
                    {
                        pEquivalentEds.Items.Add(word);
                        productBoxEds.Items.Remove(word);
                    }
                }
                if (!string.IsNullOrEmpty(exdate))
                {
                    dateCheckBoxEds.Checked = true;
                    exdate.Trim();
                    string[] dateinfos = exdate.Split('-');
                    pDateEds.Value = new DateTime(Convert.ToInt32(dateinfos[1]), Convert.ToInt32(dateinfos[0]), Convert.ToInt32(dateinfos[0]));
                }
                else
                {
                    dateCheckBoxEds.Checked = false;
                }
            }
        }
        #endregion
        #endregion

        #region Main

        #region scanProduct
        private void scanProduct(string bcode)
        {
            string query = "select * from products WHERE pBarcode='" + bcode + "'";
            _cmd = new MySqlCommand(query, _conn);
            _conn.Open();
            dreader = _cmd.ExecuteReader();

            string n, b, c, p;
            dreader.Read();
            if (dreader.HasRows)
            {
                regDateMain = dreader["pRegDate"].ToString();
                n = dreader["pName"].ToString();
                b = dreader["pBarcode"].ToString();
                c = dreader["pCount"].ToString();
                p = dreader["pPrice"].ToString();
                DataView dv = new DataView(sellTable);
                foreach (DataRowView rowView in dv)
                {
                    if (rowView["BARKOD"].ToString() == b)
                    {
                        float isS, isA;
                        double isF;
                        isS = float.Parse(rowView["ADET"].ToString());
                        isA = float.Parse(rowView["STOK"].ToString());

                        if (isS < isA)
                        {
                            rowView["ADET"] = (isS + 1).ToString();
                            isS++;
                        }

                        string[] convertedPrice = rowView["FIYAT"].ToString().Split('.');
                        if (convertedPrice.Length > 1)
                        {
                            double slice = Math.Pow(10, convertedPrice[1].Length);
                            isF = float.Parse(rowView["FIYAT"].ToString()) / slice;
                        }
                        else
                        {
                            isF = float.Parse(rowView["FIYAT"].ToString());
                        }
                        rowView["TOPLAM"] = ((isS)*isF).ToString();
                        _conn.Close();
                        sellBool = true;
                        deleteBool = true;
                        scanBool = true;
                        calcuPrice();
                        return;
                    }
                }
                DataRow dr = sellTable.NewRow();
                dr[0] = n;
                dr[1] = b;
                dr[2] = "1";
                dr[3] = c;
                dr[4] = p;
                dr[5] = p;
                sellTable.Rows.Add(dr);
                calcuPrice();
                sellBool = true;
                deleteBool = true;
            }
            else 
            {
                MessageBox.Show("barkod tanımlanmamış");
            }
            _conn.Close();
            dreader.Close();
            scanBool = true;
        }

        #endregion

        #region sellProduct
        private void sellProduct()
        {
            if (editingNow) return;
            DataView dv = new DataView(sellTable);
            int a = 0, s = 0, r = 0;
            foreach (DataRowView rowView in dv)
            {
                a = Convert.ToInt32(rowView["STOK"]);
                s = Convert.ToInt32(rowView["ADET"]);
                double isF;
                string[] convertedPrice = rowView["FIYAT"].ToString().Split('.');
                if (convertedPrice.Length > 1)
                {
                    double slice = Math.Pow(10, convertedPrice[1].Length);
                    isF = float.Parse(rowView["FIYAT"].ToString()) / slice;
                }
                else
                {
                    isF = float.Parse(rowView["FIYAT"].ToString());
                }
                if (s > a)
                {
                    MessageBox.Show("KRİTİK HATA, UYGULAMANIN KAPANMASI GEREKİYOR");
                    Application.Exit();
                    return;
                }
                else if (s < a)
                {
                    r = a - s;
                    string query = "UPDATE products SET pCount = '" + r.ToString() + "' WHERE pBarcode='" + rowView["BARKOD"].ToString() + "'";
                    _cmd = new MySqlCommand(query, _conn);
                    try
                    {
                        _conn.Open();
                        isAdapter = new MySqlDataAdapter(_cmd);
                        isAdapter.UpdateCommand = _conn.CreateCommand();
                        isAdapter.UpdateCommand.CommandText = query;
                        isAdapter.UpdateCommand.ExecuteNonQuery();
                        _conn.Close();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                        _conn.Close();
                    }
                }
                else if (Convert.ToInt32(rowView["ADET"]) == Convert.ToInt32(rowView["STOK"]))
                {
                    try
                    {
                        _conn.Open();
                        string sql = "DELETE FROM products WHERE pBarcode=" + rowView["BARKOD"].ToString() + "";
                        _cmd = new MySqlCommand(sql, _conn);
                        isAdapter = new MySqlDataAdapter(_cmd);
                        isAdapter.DeleteCommand = _conn.CreateCommand();
                        isAdapter.DeleteCommand.CommandText = sql;
                        _cmd.ExecuteNonQuery();
                        _conn.Close();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                        _conn.Close();
                    }
                }
                string selldate = DateAndTime.Now.ToString("dd-MM-yyyy-H-mm");
                string logql = "INSERT INTO islogs (isproduct, isbarcode, isregdate, isnow, isprice, iscount, istotal) VALUES (@isproduct,@isbarcode,@isregdate,@isnow,@isprice,@iscount,@istotal)";
                _cmd = new MySqlCommand(logql, _conn);
                _cmd.Parameters.AddWithValue("@isproduct", rowView["URUN"]);
                _cmd.Parameters.AddWithValue("@isbarcode", rowView["BARKOD"]);
                _cmd.Parameters.AddWithValue("@isregdate", regDateMain);
                _cmd.Parameters.AddWithValue("@isnow", selldate);
                _cmd.Parameters.AddWithValue("@iscount", rowView["ADET"]);
                _cmd.Parameters.AddWithValue("@isprice", isF.ToString());
                _cmd.Parameters.AddWithValue("@istotal", (s * isF).ToString());


                try
                {
                    _conn.Open();
                    _cmd.ExecuteNonQuery();
                    _conn.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    _conn.Close();
                }
                rowView.Delete();
                datagridMain.DataSource = sellTable;

            }
            scanBool = true;
            totalPrice = 0;
            totalPriceMain.Text = "0";
        }
        #endregion

        #region datagrid EVENTS
        //edit biterse satılan ve stok kontrolü
        private void datagridMain_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(datagridMain.CurrentRow.Cells["ADET"].Value.ToString())|| datagridMain.CurrentRow.Cells["ADET"].Value.ToString() == "0" || datagridMain.CurrentRow.Cells["ADET"].Value.ToString().Length > 4) datagridMain.CurrentRow.Cells["ADET"].Value = "1";

            int a = Convert.ToInt32(datagridMain.CurrentRow.Cells["STOK"].Value);
            int s = Convert.ToInt32(datagridMain.CurrentRow.Cells["ADET"].Value);
            double isF;
            string[] convertedPrice = datagridMain.CurrentRow.Cells["FIYAT"].Value.ToString().Split('.');

            if (s > a)
            {
                datagridMain.CurrentRow.Cells["ADET"].Value = a.ToString();
            }
            if (convertedPrice.Length > 1)
            {
                double slice = Math.Pow(10, convertedPrice[1].Length);
                isF = float.Parse(datagridMain.CurrentRow.Cells["FIYAT"].Value.ToString()) / slice;
            }
            else
            {
                isF = float.Parse(datagridMain.CurrentRow.Cells["FIYAT"].Value.ToString());
            }
            s = Convert.ToInt32(datagridMain.CurrentRow.Cells["ADET"].Value);
            datagridMain.CurrentRow.Cells["TOPLAM"].Value = (isF * s).ToString();
            calcuPrice();
            editingNow = false;
        }
        //hücrede sadece numerik giriş
        private void datagridMain_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            editingNow = true;
            TextBox txtEdit = (TextBox)e.Control;
            txtEdit.KeyPress += textBox5_KeyPress;
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (datagridMain.CurrentCell.ColumnIndex != 1) return;
            var backKeyChr = char.ConvertFromUtf32((int)Keys.Back);
            int result;
            if (int.TryParse(e.KeyChar.ToString(), out result) || e.KeyChar == (char)Keys.Back)
            {

                e.Handled = false;//if numeric display
                return;
            }
            else
            {
                e.Handled = true; //if non numeric don't display
            }
        }
        //hücrede sadece numerik giriş
        #endregion
        
        #region callbacks
        private void calcuPrice()
        {
            totalPrice = 0;
            DataView dv = new DataView(sellTable);
            foreach (DataRowView rowView in dv)
            {
                int foundedS = Convert.ToInt32(rowView["ADET"]);
                double foundedP;
                string[] convertedPrice = rowView["FIYAT"].ToString().Split('.');
                if (convertedPrice.Length > 1)
                {
                    double slice = Math.Pow(10, convertedPrice[1].Length);
                    foundedP = float.Parse(rowView["FIYAT"].ToString()) / slice;
                }
                else
                {
                    foundedP = float.Parse(rowView["FIYAT"].ToString());
                }
                totalPrice += foundedP * foundedS;
            }
            totalPriceMain.Text = totalPrice.ToString();
        }
        #endregion

        #region events&shortcuts
        //focuslamalar
        private void tabPageSecond_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
        //focuslamalar

        //shortcuts
        private void tabControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && logTab.SelectedTab == logTab.TabPages["tabPageSecond"])
            {
                if (scanBool == true)
                {
                    if (editingNow == false)
                    {
                        scanBool = false;
                        sellBool = false;
                        deleteBool = false;
                        scanProduct(textBox1.Text.Trim());
                        textBox1.Clear();
                        textBox1.Focus();
                    }
                }
            }
            if (e.KeyCode == Keys.Space && logTab.SelectedTab == logTab.TabPages["tabPageSecond"])
            {
                if (sellBool == true)
                {
                    if (editingNow == false)
                    {
                        scanBool = false;
                        sellBool = false;
                        deleteBool = false;
                        sellProduct();
                        textBox1.Clear();
                        textBox1.Focus();
                    }
                }
            }
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back && logTab.SelectedTab == logTab.TabPages["tabPageSecond"])
            {
                if (deleteBool == true)
                {
                    if (editingNow == false)
                    {
                        textBox1.Focus();
                        if (datagridMain.CurrentRow != null)
                            datagridMain.Rows.Remove(datagridMain.CurrentRow);
                        calcuPrice();
                    }
                }
            }

        }

        #endregion

        #endregion

        #region logs
        #region callbacks
        private void getLogs()
        {
            lTable.Clear();
            //tabloyu çek
            logAdapter = new MySqlDataAdapter(_cmd);
            string query = "select * from islogs";
            _cmd = new MySqlCommand(query, _conn);
            logAdapter.SelectCommand = _cmd;
            logAdapter.Fill(lTable);
            datagridLog.DataSource = lTable;
            datagridLog.Columns["id"].HeaderText = "ID";
            datagridLog.Columns["isproduct"].HeaderText = "ÜRÜN";
            datagridLog.Columns["isbarcode"].HeaderText = "BARKOD";
            datagridLog.Columns["isregdate"].HeaderText = "STOK GİRİŞ";
            datagridLog.Columns["isnow"].HeaderText = "İŞLEM TARİH";
            datagridLog.Columns["isprice"].HeaderText = "FİYAT";
            datagridLog.Columns["iscount"].HeaderText = "ADET";
            datagridLog.Columns["istotal"].HeaderText = "TOPLAM";
        }
        #endregion
        #endregion

        #region login
        private void metroSetButton1_Click_1(object sender, EventArgs e)
        {
            sw = loginSW.Text;
            db = loginDb.Text;
            uid = loginId.Text;
            pwd = loginPwd.Text;
            st = "Server=" + sw + ";Database=" + db + ";Uid=" + uid + ";Pwd='" + pwd + "';";
            _conn = new MySqlConnection(st);
            try
            {
                _conn.Open();
                MessageBox.Show("ServerVersion: " + _conn.ServerVersion + "\nState: " + _conn.State.ToString());
                _conn.Close();
                if (rememberUser.Checked)
                {
                    Properties.Settings.Default["server"] = sw;
                    Properties.Settings.Default["db"] = db;
                    Properties.Settings.Default["id"] = uid;
                    Properties.Settings.Default.Save();

                }
            }
            catch (Exception err)
            {
                connected = false;
                MessageBox.Show(err.Message);
                _conn.Close();
                if (string.IsNullOrEmpty(myip))
                {
                    try
                    {
                        string url = "http://checkip.dyndns.org";
                        System.Net.WebRequest req = System.Net.WebRequest.Create(url);
                        System.Net.WebResponse resp = req.GetResponse();
                        System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
                        string response = sr.ReadToEnd().Trim();
                        string[] ipAddressWithText = response.Split(':');
                        string ipAddressWithHTMLEnd = ipAddressWithText[1].Substring(1);
                        string[] ipAddress = ipAddressWithHTMLEnd.Split('<');
                        myip = ipAddress[0];
                    }
                    catch (Exception errtwo)
                    {
                        MessageBox.Show(errtwo.Message);
                    }
                    metroSetButton3.Visible = true;
                    metroSetButton3.Enabled = true;
                    metroSetLabel12.Visible = true;
                    metroSetButton3.Text = myip;
                }
                return;
            }
            connected = true;
            logTab.SelectedTab = tabPageFirst;

        }
        private void rememberUser_CheckedChanged(object sender)
        {
            if (rememberUser.Checked)
            {
                if (string.IsNullOrWhiteSpace(Properties.Settings.Default["server"].ToString()) || string.IsNullOrWhiteSpace(Properties.Settings.Default["db"].ToString()) || string.IsNullOrWhiteSpace(Properties.Settings.Default["id"].ToString())) return;
                loginSW.Text = Properties.Settings.Default["server"].ToString();
                loginDb.Text = Properties.Settings.Default["db"].ToString();
                loginId.Text = Properties.Settings.Default["id"].ToString();
            }
        }
        private void metroSetButton2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["server"] = "";
            Properties.Settings.Default["db"] = "";
            Properties.Settings.Default["id"] = "";
            Properties.Settings.Default.Save();
            this.Enabled = false;
        }
        #endregion

    }
}