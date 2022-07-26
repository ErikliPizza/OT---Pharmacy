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

namespace OT
{
	public partial class Form1 : Form
	{
        public MySqlConnection _conn = new MySqlConnection("Server=localhost;Database=pharma_ot;Uid=root;Pwd='hello';");


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
            _conn.Close();
            #endregion
            #region panelConfig
            datagridEds.DataSource = getProducts("SELECT pName as 'ürün', pAbout as 'açıklama', pEquivalent as 'muadiller', pCount as 'adet', pPrice as 'fiyat', pBarcode as 'barkod', pExDate as 'SKT', pRegDate as 'kayıt' FROM products");
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
            using (_conn)
            {
                using (MySqlCommand _cmd = new MySqlCommand("SELECT pName FROM products", _conn))
                {
                    _conn.Open();
                    MySqlDataReader reader = _cmd.ExecuteReader();
                    while (reader.Read()) productBoxEds.Items.Add(reader["pName"].ToString());
                }
            }
            #endregion
        }


        private DataTable getProducts(string dynaCommand) 
        {
            DataTable pTable = new DataTable();
            using (_conn) 
            {
                using (MySqlCommand cmd = new MySqlCommand(dynaCommand, _conn))
                {
                    _conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    pTable.Load(reader);
                }
            }
            return pTable;
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            #region kontroller
            isLikely = null;
            string isName, isCount, isPrice, isBarcode, isAbout, isExpDate;
            isName = pNameEds.Text;
            isName = isName.Trim();
            isCount = pCountEds.Text;
            isPrice = pPriceEds.Text;
            isBarcode = pBarcodeEds.Text;
            isAbout = pAboutEds.Text;
            isExpDate = pDateEds.Value.ToString("MM-yyyy");
            foreach (string s in pEquivalentEds.Items) isLikely += s + ",";

            labelEdsTicket.Text = isLikely;

            if(string.IsNullOrWhiteSpace(isName) ||string.IsNullOrWhiteSpace(isCount)||string.IsNullOrWhiteSpace(isPrice)||string.IsNullOrWhiteSpace(isBarcode))
            {
                string message = "Zorunlu Kısımları Doldurunuz"+isName;
                string title = "SORUN VAR!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    return;
                }
            }
            MessageBox.Show("kayıt yapıyoruz");
            #endregion
        }
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

            datagridEds.DataSource = getProducts("SELECT pName as 'ürün', pAbout as 'açıklama', pEquivalent as 'muadiller', pCount as 'adet', pPrice as 'fiyat', pBarcode as 'barkod', pExDate as 'SKT', pRegDate as 'kayıt' FROM products WHERE pName LIKE '"+currentContainer.Text+"%'"); //filtrele

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