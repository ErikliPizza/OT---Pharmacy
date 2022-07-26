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

        public MySqlConnection _conn = new MySqlConnection("Server=localhost;Database=pharma_ot;Uid=root;Pwd='hello';");
        public MySqlCommand _cmd = new MySqlCommand();
        public DataTable pTable = new DataTable();
        public MySqlDataReader dreader;
        public MySqlDataAdapter isAdapter = new MySqlDataAdapter();

        public bool machineWriting = false;
        #endregion
        public string isLikely, connString;
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
            #region connection
            try
            {
                _conn.Open();
                if (_conn.State != ConnectionState.Closed)
                {
                    _cmd.Connection = _conn;
                    MessageBox.Show("Veri Tabanı Bağlantısı Başarılı");
                }
                else
                {
                    MessageBox.Show("Hata");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion
            #region panelConfig
            datagridEds.DataSource = getProducts("SELECT id, pName as 'ürün', pAbout as 'açıklama', pEquivalent as 'muadiller', pCount as 'adet', pPrice as 'fiyat', pBarcode as 'barkod', pExDate as 'SKT', pRegDate as 'kayıt' FROM products");
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
            #region muadilleriçek
            getLikely();
            #endregion
            #region tarih
            currentDate = DateTime.Now;
            currentMonth = Convert.ToInt32(currentDate.ToString("MM"));
            currentYear = Convert.ToInt32(currentDate.ToString("yyyy"));
            #endregion
        }

        #region callbacks
        private void clearInputs()
        {
            pNameEds.Clear();
            pCountEds.Clear();
            pPriceEds.Clear();
            pAboutEds.Clear();
            pDateEds.Value = DateTime.Now;
            getLikely();
            pEquivalentEds.Items.Clear();
        }
        private void getLikely()
        {
            productBoxEds.Items.Clear();
            _cmd.CommandText = "SELECT DISTINCT pName FROM products";
            dreader = _cmd.ExecuteReader();
            while (dreader.Read()) productBoxEds.Items.Add(dreader["pName"].ToString());
            dreader.Close();
            _cmd.Dispose();
        }
        private DataTable getProducts(string dynaCommand) 
        {
            _cmd.CommandText = dynaCommand;
            dreader = _cmd.ExecuteReader();
            pTable.Clear();
            pTable.Load(dreader);
            dreader.Close();
            _cmd.Dispose();
            return pTable;

        }
        private void getProductsInto(string sqlValue, string dynaValue)
        {
            clearInputs();
            machineWriting = true;
            _cmd.CommandText = "SELECT pName, pAbout, pEquivalent, pCount, pPrice, pBarcode, pExDate FROM products WHERE " + sqlValue + "='" + dynaValue + "'";
            dreader = _cmd.ExecuteReader();
            while (dreader.Read())
            {
                pNameEds.Text = dreader[0].ToString();
                pAboutEds.Text = dreader[1].ToString();
                if (!string.IsNullOrEmpty(dreader[2].ToString()))
                {
                    dreader[2].ToString().Trim();
                    string[] words = dreader[2].ToString().Split(',');
                    foreach (var word in words)
                    {
                        pEquivalentEds.Items.Add(word);
                        productBoxEds.Items.Remove(word);
                    }
                }
                pCountEds.Text = dreader[3].ToString();
                pPriceEds.Text = dreader[4].ToString();
                if (!string.IsNullOrEmpty(dreader[6].ToString()))
                {
                    dateCheckBoxEds.Checked = true;
                    dreader[6].ToString().Trim();
                    string[] dateinfos = dreader[6].ToString().Split('-');
                    pDateEds.Value = new DateTime(Convert.ToInt32(dateinfos[1]), Convert.ToInt32(dateinfos[0]), Convert.ToInt32(dateinfos[0]));
                }
                else
                {
                    dateCheckBoxEds.Checked = false;
                }

            }
            machineWriting = false;
            dreader.Close();
            _cmd.Dispose();
            datagridEds.DataSource = getProducts("SELECT id, pName as 'ürün', pAbout as 'açıklama', pEquivalent as 'muadiller', pCount as 'adet', pPrice as 'fiyat', pBarcode as 'barkod', pExDate as 'SKT', pRegDate as 'kayıt' FROM products WHERE pName LIKE '" + pNameEds.Text + "%'"); //filtre
        }
        #endregion

        #region butonlar

        #region ekle butonu
        private void addBtn_Click(object sender, EventArgs e)
        {
            #region kontroller
            isLikely = null; //muadilleri temizle
            foreach (string s in pEquivalentEds.Items) isLikely += s + ",";
            if(!string.IsNullOrEmpty(isLikely)) isLikely = isLikely.Remove(isLikely.Length - 1);

            string isName ="", isCount="", isPrice="", isBarcode="", isAbout="", isExpDate="";
            int expMonth, expYear, expResult;
            isName = pNameEds.Text;
            isName = isName.Trim();
            isCount = pCountEds.Text;
            isPrice = pPriceEds.Text;
            isAbout = pAboutEds.Text;
            
            

            if(string.IsNullOrWhiteSpace(isName) ||string.IsNullOrWhiteSpace(isCount)||string.IsNullOrWhiteSpace(isPrice))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Zorunlu Kısımları Doldurunuz", "SORUN VAR!", buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    return;
                }
            }
            
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

            isBarcode = Interaction.InputBox("barkod", "barkodu okut", "", 100, 100);
            if(string.IsNullOrWhiteSpace(isBarcode))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Ürün İçin Barkod Tanımlayın", "SORUN VAR!", buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    return;
                }
            }

            _cmd.CommandText = "select pBarcode, pName FROM products WHERE pBarcode ='" + isBarcode + "';";
            dreader = _cmd.ExecuteReader();
            if (dreader.HasRows)
            {
                dreader.Close();
                _cmd.Dispose();
                MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
                DialogResult result = MessageBox.Show("Barkod Zaten Tanımlı", "SORUN VAR!", buttons, MessageBoxIcon.Warning); 
                if(result == DialogResult.Retry)
                {
                    getProductsInto("pBarcode", isBarcode);
                    return;
                }
                else if(result == DialogResult.Abort)
                {
                    clearInputs();
                    return;
                }
            }
            dreader.Close();
            _cmd.Dispose();
            #endregion

            //kayıt başladı
            try
            {
                _cmd.CommandText = "INSERT INTO products (pName, pAbout, pEquivalent, pCount, pPrice, pBarcode, pExDate, pRegDate) VALUES ('" + isName + "','" + isAbout + "','" + isLikely + "', '" + isCount + "','" + isPrice + "','" + isBarcode + "','" + isExpDate + "','" + DateAndTime.Now.ToString("dd-MM-yyyy-H-mm") + "');";
                _cmd.ExecuteNonQuery();
                _cmd.Dispose();
                
            }
            catch(Exception err)
            {
                MessageBox.Show("Hata! " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //kayıt bitti

            clearInputs();
        }
        #endregion

        #region sil butonu
        private void deleteBtnEds_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in datagridEds.SelectedRows)
            {
                string selected = datagridEds.SelectedRows[0].Cells[0].Value.ToString();
                int id = Convert.ToInt32(selected);
                deleteFromDb(id);
            }
        }
        private void deleteFromDb(int id)
        {
            string sql = "DELETE FROM products WHERE id="+id+"";
            MySqlCommand cm = new MySqlCommand(sql, _conn);
            try
            {
                isAdapter.DeleteCommand = _conn.CreateCommand();
                isAdapter.DeleteCommand.CommandText = sql;
                cm.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            datagridEds.DataSource = getProducts("SELECT id, pName as 'ürün', pAbout as 'açıklama', pEquivalent as 'muadiller', pCount as 'adet', pPrice as 'fiyat', pBarcode as 'barkod', pExDate as 'SKT', pRegDate as 'kayıt' FROM products");
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
            if (!machineWriting) datagridEds.DataSource = getProducts("SELECT id, pName as 'ürün', pAbout as 'açıklama', pEquivalent as 'muadiller', pCount as 'adet', pPrice as 'fiyat', pBarcode as 'barkod', pExDate as 'SKT', pRegDate as 'kayıt' FROM products WHERE pName LIKE '" + currentContainer.Text + "%'"); //filtrele

        }

        private void dateCheckBoxEds_CheckedChanged(object sender, EventArgs e)
        {
            pDateEds.Enabled = !pDateEds.Enabled;
        }


        #endregion

        #region Boxes
        private void productBoxEds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pEquivalentEds.Items.Count < 5)
            {
                if (productBoxEds.SelectedItem != null) pEquivalentEds.Items.Add(productBoxEds.SelectedItem);
                productBoxEds.Items.Remove(productBoxEds.SelectedItem);
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