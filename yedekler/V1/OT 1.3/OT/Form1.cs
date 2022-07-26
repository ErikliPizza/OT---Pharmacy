using System;
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
	public partial class Form1 : Form
	{
        #region variables
        public DateTime currentDate;
        public int currentMonth, currentYear;

        public MySqlConnection _conn = new MySqlConnection("Server=89.252.187.3;Database=noircont_pharma_ot;Uid=noircont_plummyw;Pwd='qwxqwx123123123';");
        public MySqlCommand _cmd;
        public MySqlDataAdapter isAdapter;
        public DataTable pTable = new DataTable();
        public MySqlDataReader dreader;

        public bool machineWriting = false;
        #endregion
        public string isLikely;
		public Form1()
		{
            InitializeComponent();

        }
        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
			main.Visible = false;
            test.Visible = false;
			edspanel.Visible = true;
        }
        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
			edspanel.Visible = false;
            test.Visible = false;
			main.Visible = true;
        }
        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edspanel.Visible = false;
            main.Visible = false;
            test.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            #region panelConfig
            getProducts();
            //datagridEds.DataSource = getProducts("SELECT id, pName as 'URUN', pAbout as 'HAKKINDA', pEquivalent as 'MUADILLER', pCount as 'ADET', pPrice as 'FIYAT', pBarcode as 'BARKOD', pExDate as 'SKT', pRegDate as 'KAYIT' FROM products");
            showExtrasBoxEds.Checked = true;
            dateCheckBoxEds.Checked = true;
            edspanel.Visible = false;
            main.Visible = false;
            test.Visible = false;

            main.Parent = this;
            test.Parent = this;
            edspanel.Parent = this;

            main.Location = edspanel.Location;
            test.Location = edspanel.Location;
            #endregion
            #region textboxConfig
            pNameEds.MaxLength = 25;
            pCountEds.MaxLength = 6;
            pPriceEds.MaxLength = 8;
            pAboutEds.MaxLength = 255;
            #endregion
            #region tarih
            currentDate = DateTime.Now;
            currentMonth = Convert.ToInt32(currentDate.ToString("MM"));
            currentYear = Convert.ToInt32(currentDate.ToString("yyyy"));
            #endregion
        }

        #region callbacks
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
                if(_cmd.ExecuteNonQuery()>0)
                {
                    MessageBox.Show("kayıt başarılı");
                }
                _conn.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
                _conn.Close();
            }
        }
        private void createItems(string id, string name, string about, string eq, string count, string price, string barcode, string exdate, string regdate)
        {
            datagridEds.Rows.Add(id, name, about, eq, count, price, barcode, exdate, regdate);
        }
        private void getProducts()
        {
            datagridEds.Rows.Clear(); //tabloyu temizle
            clearInputs(); //formu temizle

            //tabloyu çek
            string query = "select * from products";
            _cmd = new MySqlCommand(query, _conn);
            try 
            {
                _conn.Open();
                isAdapter = new MySqlDataAdapter(_cmd);
                isAdapter.Fill(pTable);
                datagridEds.DataSource = pTable;
                foreach(DataRow row in pTable.Rows) 
                {
                    createItems(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString());
                }
                _conn.Close();
                pTable.Rows.Clear();
            }
            catch (Exception err) 
            {
                MessageBox.Show(err.Message);
                _conn.Close();
            }
            getLikely(); //muadilleri çek

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
                        if (value == row.Cells["ÜRÜN"].Value.ToString())
                        {
                            productBoxEds.Items.Remove(value);
                            break;
                        }
                    }
                }
                productBoxEds.Items.Add(row.Cells["ÜRÜN"].Value.ToString());
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
                if (showExtrasBoxEds.Checked)
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
            foreach (DataGridViewRow row in datagridEds.Rows)
            {
                if (row.Cells["BARKOD"].Value.ToString() == isBarcode)//eşleşme varsa
                {
                    MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
                    DialogResult result = MessageBox.Show("Barkod Zaten Bu Ürüne Tanımlı: " + row.Cells["ÜRÜN"].Value.ToString(), "SORUN VAR!", buttons, MessageBoxIcon.Warning);
                    
                    if (result == DialogResult.Retry) // düzenle, select row
                    {
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
            //kayıt sonrası
            getProducts();
            //kayıt sonrası
        }
        #endregion
        #region sil butonu
        private void deleteBtnEds_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in datagridEds.SelectedRows)
            {
                string selected = datagridEds.SelectedRows[0].Cells[0].Value.ToString();
                string pname = datagridEds.SelectedRows[0].Cells["ÜRÜN"].Value.ToString();
                int id = Convert.ToInt32(selected);
                deleteFromDb(id, pname);
            }
        }
        private void deleteFromDb(int id, string productName)
        {
            string sql = "DELETE FROM products WHERE id="+id+"";
            _cmd = new MySqlCommand(sql, _conn);
            try
            {
                _conn.Open();
                isAdapter = new MySqlDataAdapter(_cmd);
                isAdapter.DeleteCommand = _conn.CreateCommand();
                isAdapter.DeleteCommand.CommandText = sql;
                if(!checkBoxDelete.Checked)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show("Bu İşlem Geri Alınamaz:", "SİLMEK İSTEDİĞİNE EMİN MİSİN?", buttons, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        _cmd.ExecuteNonQuery();
                    }
                }
                else
                {
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
            //datagridEds.DataSource = getProducts("SELECT id, pName as 'URUN', pAbout as 'HAKKINDA', pEquivalent as 'MUADILLER', pCount as 'ADET', pPrice as 'FIYAT', pBarcode as 'BARKOD', pExDate as 'SKT', pRegDate as 'KAYIT' FROM products");
            clearInputs();
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

    

            pTable.DefaultView.RowFilter = string.Format("pName = '{0}'", currentContainer);
            isAdapter.Fill(pTable);


            //if (!machineWriting) datagridEds.DataSource = getProducts("SELECT id, pName as 'URUN', pAbout as 'HAKKINDA', pEquivalent as 'MUADILLER', pCount as 'ADET', pPrice as 'FIYAT', pBarcode as 'BARKOD', pExDate as 'SKT', pRegDate as 'KAYIT' FROM products WHERE pName LIKE '" + currentContainer.Text + "%'"); //filtrele

        }

        private void dateCheckBoxEds_CheckedChanged(object sender, EventArgs e)
        {
            pDateEds.Enabled = !pDateEds.Enabled;
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

        private void editBtnEds_Click(object sender, EventArgs e)
        {
            getLikely();
            getProducts();
        }

        private void datagridEds_SelectionChanged(object sender, EventArgs e)
        {
            if (checkboxEdit.Checked)
            {
                clearInputs();
                getLikely();
                pNameEds.Text = datagridEds.SelectedRows[0].Cells["ÜRÜN"].Value.ToString();
                pAboutEds.Text = datagridEds.SelectedRows[0].Cells["AÇIKLAMA"].Value.ToString();
                pCountEds.Text = datagridEds.SelectedRows[0].Cells["ADET"].Value.ToString();
                pPriceEds.Text = datagridEds.SelectedRows[0].Cells["FİYAT"].Value.ToString();
                pBarcode.Text = datagridEds.SelectedRows[0].Cells["BARKOD"].Value.ToString();
                string eq = datagridEds.SelectedRows[0].Cells["MUADİLLER"].Value.ToString();
                string exdate = datagridEds.SelectedRows[0].Cells["SKT"].Value.ToString();
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

        private void checkboxEdit_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxEdit.Checked)
            {
                checkBoxDelete.Checked = false;
                int i = datagridEds.CurrentRow.Index+1;
                datagridEds.Rows[i].Selected = true;
                datagridEds.Rows[i-1].Selected = true;
                addBtnEds.Enabled = false;
                editBtnEds.Enabled = true;
            }
            else 
            {
                editBtnEds.Enabled = false;
                addBtnEds.Enabled = true;
                clearInputs();
                getLikely();
            }
        }

        private void checkBoxDelete_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxDelete.Checked)
            {
                checkboxEdit.Checked = false;
                editBtnEds.Enabled = false;
                datagridEds.MultiSelect = true;
                checkboxEdit.Enabled = false;
            }
            else 
            {
                datagridEds.MultiSelect = false;
                datagridEds.Rows[1].Selected = true;
                datagridEds.ClearSelection();
                checkboxEdit.Enabled = true;
            }
        }

        private void pEquivalentEds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(pEquivalentEds.SelectedItem != null) productBoxEds.Items.Add(pEquivalentEds.SelectedItem);
            pEquivalentEds.Items.Remove(pEquivalentEds.SelectedItem);
        }
        #endregion
    }
}