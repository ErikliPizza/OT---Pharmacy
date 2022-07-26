
namespace OT
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
            this.edspanel = new System.Windows.Forms.GroupBox();
            this.explainerEds = new System.Windows.Forms.RichTextBox();
            this.checkBoxDelete = new System.Windows.Forms.CheckBox();
            this.checkboxEdit = new System.Windows.Forms.CheckBox();
            this.dateExtraBox = new System.Windows.Forms.CheckBox();
            this.showExtrasBoxEds = new System.Windows.Forms.CheckBox();
            this.datagridEds = new System.Windows.Forms.DataGridView();
            this.labelEdsTicket = new System.Windows.Forms.Label();
            this.pEquivalentEds = new System.Windows.Forms.ListBox();
            this.productBoxEds = new System.Windows.Forms.ComboBox();
            this.dateCheckBoxEds = new System.Windows.Forms.CheckBox();
            this.deleteBtnEds = new System.Windows.Forms.Button();
            this.editBtnEds = new System.Windows.Forms.Button();
            this.addBtnEds = new System.Windows.Forms.Button();
            this.pDateEds = new System.Windows.Forms.DateTimePicker();
            this.pBarcode = new System.Windows.Forms.TextBox();
            this.pPriceEds = new System.Windows.Forms.TextBox();
            this.pCountEds = new System.Windows.Forms.TextBox();
            this.pAboutEds = new System.Windows.Forms.TextBox();
            this.pNameEds = new System.Windows.Forms.TextBox();
            this.labelEdsExpDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEdsPrice = new System.Windows.Forms.Label();
            this.labelEdsCount = new System.Windows.Forms.Label();
            this.labelEdsEq = new System.Windows.Forms.Label();
            this.labelEdsAbout = new System.Windows.Forms.Label();
            this.labelEdsName = new System.Windows.Forms.Label();
            this.main = new System.Windows.Forms.GroupBox();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.sellProductMain = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.scanProductMain = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.datagridMain = new System.Windows.Forms.DataGridView();
            this.logGroup = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.totalPriceMain = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.MenuStrip();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datagridLog = new System.Windows.Forms.DataGridView();
            this.edspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridEds)).BeginInit();
            this.main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridMain)).BeginInit();
            this.logGroup.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridLog)).BeginInit();
            this.SuspendLayout();
            // 
            // edspanel
            // 
            this.edspanel.Controls.Add(this.explainerEds);
            this.edspanel.Controls.Add(this.checkBoxDelete);
            this.edspanel.Controls.Add(this.checkboxEdit);
            this.edspanel.Controls.Add(this.dateExtraBox);
            this.edspanel.Controls.Add(this.showExtrasBoxEds);
            this.edspanel.Controls.Add(this.datagridEds);
            this.edspanel.Controls.Add(this.labelEdsTicket);
            this.edspanel.Controls.Add(this.pEquivalentEds);
            this.edspanel.Controls.Add(this.productBoxEds);
            this.edspanel.Controls.Add(this.dateCheckBoxEds);
            this.edspanel.Controls.Add(this.deleteBtnEds);
            this.edspanel.Controls.Add(this.editBtnEds);
            this.edspanel.Controls.Add(this.addBtnEds);
            this.edspanel.Controls.Add(this.pDateEds);
            this.edspanel.Controls.Add(this.pBarcode);
            this.edspanel.Controls.Add(this.pPriceEds);
            this.edspanel.Controls.Add(this.pCountEds);
            this.edspanel.Controls.Add(this.pAboutEds);
            this.edspanel.Controls.Add(this.pNameEds);
            this.edspanel.Controls.Add(this.labelEdsExpDate);
            this.edspanel.Controls.Add(this.label1);
            this.edspanel.Controls.Add(this.labelEdsPrice);
            this.edspanel.Controls.Add(this.labelEdsCount);
            this.edspanel.Controls.Add(this.labelEdsEq);
            this.edspanel.Controls.Add(this.labelEdsAbout);
            this.edspanel.Controls.Add(this.labelEdsName);
            this.edspanel.Location = new System.Drawing.Point(1173, 695);
            this.edspanel.Name = "edspanel";
            this.edspanel.Size = new System.Drawing.Size(1193, 674);
            this.edspanel.TabIndex = 0;
            this.edspanel.TabStop = false;
            this.edspanel.Text = "ÜRÜNLER";
            // 
            // explainerEds
            // 
            this.explainerEds.Location = new System.Drawing.Point(418, 401);
            this.explainerEds.Name = "explainerEds";
            this.explainerEds.ReadOnly = true;
            this.explainerEds.Size = new System.Drawing.Size(758, 85);
            this.explainerEds.TabIndex = 11;
            this.explainerEds.Text = "";
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.AutoSize = true;
            this.checkBoxDelete.Location = new System.Drawing.Point(533, 492);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(111, 17);
            this.checkBoxDelete.TabIndex = 10;
            this.checkBoxDelete.Text = "Toplu Silme Modu";
            this.checkBoxDelete.UseVisualStyleBackColor = true;
            this.checkBoxDelete.CheckedChanged += new System.EventHandler(this.checkBoxDelete_CheckedChanged);
            // 
            // checkboxEdit
            // 
            this.checkboxEdit.AutoSize = true;
            this.checkboxEdit.Location = new System.Drawing.Point(418, 492);
            this.checkboxEdit.Name = "checkboxEdit";
            this.checkboxEdit.Size = new System.Drawing.Size(109, 17);
            this.checkboxEdit.TabIndex = 10;
            this.checkboxEdit.Text = "Düzenleme Modu";
            this.checkboxEdit.UseVisualStyleBackColor = true;
            this.checkboxEdit.CheckedChanged += new System.EventHandler(this.checkboxEdit_CheckedChanged);
            // 
            // dateExtraBox
            // 
            this.dateExtraBox.AutoSize = true;
            this.dateExtraBox.Location = new System.Drawing.Point(875, 498);
            this.dateExtraBox.Name = "dateExtraBox";
            this.dateExtraBox.Size = new System.Drawing.Size(170, 17);
            this.dateExtraBox.TabIndex = 10;
            this.dateExtraBox.Text = "Anormal Durumlarda Beni Uyar";
            this.dateExtraBox.UseVisualStyleBackColor = true;
            // 
            // showExtrasBoxEds
            // 
            this.showExtrasBoxEds.AutoSize = true;
            this.showExtrasBoxEds.Location = new System.Drawing.Point(1051, 498);
            this.showExtrasBoxEds.Name = "showExtrasBoxEds";
            this.showExtrasBoxEds.Size = new System.Drawing.Size(125, 17);
            this.showExtrasBoxEds.TabIndex = 10;
            this.showExtrasBoxEds.Text = "Bilgi Kutularını Göster";
            this.showExtrasBoxEds.UseVisualStyleBackColor = true;
            // 
            // datagridEds
            // 
            this.datagridEds.AllowUserToAddRows = false;
            this.datagridEds.AllowUserToDeleteRows = false;
            this.datagridEds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridEds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridEds.Location = new System.Drawing.Point(418, 19);
            this.datagridEds.MultiSelect = false;
            this.datagridEds.Name = "datagridEds";
            this.datagridEds.ReadOnly = true;
            this.datagridEds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridEds.Size = new System.Drawing.Size(758, 376);
            this.datagridEds.TabIndex = 9;
            this.datagridEds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridEds_CellClick);
            // 
            // labelEdsTicket
            // 
            this.labelEdsTicket.AutoSize = true;
            this.labelEdsTicket.Location = new System.Drawing.Point(16, 646);
            this.labelEdsTicket.Name = "labelEdsTicket";
            this.labelEdsTicket.Size = new System.Drawing.Size(93, 13);
            this.labelEdsTicket.TabIndex = 8;
            this.labelEdsTicket.Text = "lorem ipsum - EDS";
            // 
            // pEquivalentEds
            // 
            this.pEquivalentEds.FormattingEnabled = true;
            this.pEquivalentEds.Location = new System.Drawing.Point(110, 300);
            this.pEquivalentEds.Name = "pEquivalentEds";
            this.pEquivalentEds.Size = new System.Drawing.Size(219, 95);
            this.pEquivalentEds.TabIndex = 7;
            this.pEquivalentEds.SelectedIndexChanged += new System.EventHandler(this.pEquivalentEds_SelectedIndexChanged);
            // 
            // productBoxEds
            // 
            this.productBoxEds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.productBoxEds.FormattingEnabled = true;
            this.productBoxEds.Location = new System.Drawing.Point(110, 195);
            this.productBoxEds.Name = "productBoxEds";
            this.productBoxEds.Size = new System.Drawing.Size(219, 99);
            this.productBoxEds.TabIndex = 6;
            this.productBoxEds.SelectedIndexChanged += new System.EventHandler(this.productBoxEds_SelectedIndexChanged);
            // 
            // dateCheckBoxEds
            // 
            this.dateCheckBoxEds.AutoSize = true;
            this.dateCheckBoxEds.Location = new System.Drawing.Point(335, 171);
            this.dateCheckBoxEds.Name = "dateCheckBoxEds";
            this.dateCheckBoxEds.Size = new System.Drawing.Size(15, 14);
            this.dateCheckBoxEds.TabIndex = 4;
            this.dateCheckBoxEds.UseVisualStyleBackColor = true;
            this.dateCheckBoxEds.CheckedChanged += new System.EventHandler(this.dateCheckBoxEds_CheckedChanged);
            // 
            // deleteBtnEds
            // 
            this.deleteBtnEds.Location = new System.Drawing.Point(265, 492);
            this.deleteBtnEds.Name = "deleteBtnEds";
            this.deleteBtnEds.Size = new System.Drawing.Size(75, 23);
            this.deleteBtnEds.TabIndex = 3;
            this.deleteBtnEds.Text = "SİL";
            this.deleteBtnEds.UseVisualStyleBackColor = true;
            this.deleteBtnEds.Click += new System.EventHandler(this.deleteBtnEds_Click);
            // 
            // editBtnEds
            // 
            this.editBtnEds.Enabled = false;
            this.editBtnEds.Location = new System.Drawing.Point(184, 492);
            this.editBtnEds.Name = "editBtnEds";
            this.editBtnEds.Size = new System.Drawing.Size(75, 23);
            this.editBtnEds.TabIndex = 3;
            this.editBtnEds.Text = "DÜZENLE";
            this.editBtnEds.UseVisualStyleBackColor = true;
            this.editBtnEds.Click += new System.EventHandler(this.editBtnEds_Click);
            // 
            // addBtnEds
            // 
            this.addBtnEds.Location = new System.Drawing.Point(103, 492);
            this.addBtnEds.Name = "addBtnEds";
            this.addBtnEds.Size = new System.Drawing.Size(75, 23);
            this.addBtnEds.TabIndex = 3;
            this.addBtnEds.Text = "EKLE";
            this.addBtnEds.UseVisualStyleBackColor = true;
            this.addBtnEds.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // pDateEds
            // 
            this.pDateEds.CustomFormat = "MM-yyyy";
            this.pDateEds.Enabled = false;
            this.pDateEds.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pDateEds.Location = new System.Drawing.Point(110, 169);
            this.pDateEds.Name = "pDateEds";
            this.pDateEds.Size = new System.Drawing.Size(219, 20);
            this.pDateEds.TabIndex = 2;
            // 
            // pBarcode
            // 
            this.pBarcode.Location = new System.Drawing.Point(110, 97);
            this.pBarcode.Name = "pBarcode";
            this.pBarcode.Size = new System.Drawing.Size(219, 20);
            this.pBarcode.TabIndex = 1;
            // 
            // pPriceEds
            // 
            this.pPriceEds.Location = new System.Drawing.Point(110, 71);
            this.pPriceEds.Name = "pPriceEds";
            this.pPriceEds.Size = new System.Drawing.Size(219, 20);
            this.pPriceEds.TabIndex = 1;
            this.pPriceEds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pPriceEds_KeyPress);
            // 
            // pCountEds
            // 
            this.pCountEds.Location = new System.Drawing.Point(110, 45);
            this.pCountEds.Name = "pCountEds";
            this.pCountEds.Size = new System.Drawing.Size(219, 20);
            this.pCountEds.TabIndex = 1;
            this.pCountEds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pCountEds_KeyPress);
            // 
            // pAboutEds
            // 
            this.pAboutEds.Location = new System.Drawing.Point(110, 143);
            this.pAboutEds.Name = "pAboutEds";
            this.pAboutEds.Size = new System.Drawing.Size(219, 20);
            this.pAboutEds.TabIndex = 1;
            // 
            // pNameEds
            // 
            this.pNameEds.Location = new System.Drawing.Point(110, 19);
            this.pNameEds.Name = "pNameEds";
            this.pNameEds.Size = new System.Drawing.Size(219, 20);
            this.pNameEds.TabIndex = 1;
            this.pNameEds.TextChanged += new System.EventHandler(this.pNameEds_TextChanged);
            // 
            // labelEdsExpDate
            // 
            this.labelEdsExpDate.AutoSize = true;
            this.labelEdsExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEdsExpDate.Location = new System.Drawing.Point(67, 173);
            this.labelEdsExpDate.Name = "labelEdsExpDate";
            this.labelEdsExpDate.Size = new System.Drawing.Size(37, 16);
            this.labelEdsExpDate.TabIndex = 1;
            this.labelEdsExpDate.Text = "SKT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barkod*";
            // 
            // labelEdsPrice
            // 
            this.labelEdsPrice.AutoSize = true;
            this.labelEdsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEdsPrice.Location = new System.Drawing.Point(17, 72);
            this.labelEdsPrice.Name = "labelEdsPrice";
            this.labelEdsPrice.Size = new System.Drawing.Size(87, 16);
            this.labelEdsPrice.TabIndex = 1;
            this.labelEdsPrice.Text = "Birim Fiyat*";
            // 
            // labelEdsCount
            // 
            this.labelEdsCount.AutoSize = true;
            this.labelEdsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEdsCount.Location = new System.Drawing.Point(58, 46);
            this.labelEdsCount.Name = "labelEdsCount";
            this.labelEdsCount.Size = new System.Drawing.Size(46, 16);
            this.labelEdsCount.TabIndex = 1;
            this.labelEdsCount.Text = "Adet*";
            // 
            // labelEdsEq
            // 
            this.labelEdsEq.AutoSize = true;
            this.labelEdsEq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEdsEq.Location = new System.Drawing.Point(32, 198);
            this.labelEdsEq.Name = "labelEdsEq";
            this.labelEdsEq.Size = new System.Drawing.Size(72, 16);
            this.labelEdsEq.TabIndex = 1;
            this.labelEdsEq.Text = "Muadiller";
            // 
            // labelEdsAbout
            // 
            this.labelEdsAbout.AutoSize = true;
            this.labelEdsAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEdsAbout.Location = new System.Drawing.Point(32, 143);
            this.labelEdsAbout.Name = "labelEdsAbout";
            this.labelEdsAbout.Size = new System.Drawing.Size(72, 16);
            this.labelEdsAbout.TabIndex = 1;
            this.labelEdsAbout.Text = "Açıklama";
            // 
            // labelEdsName
            // 
            this.labelEdsName.AutoSize = true;
            this.labelEdsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEdsName.Location = new System.Drawing.Point(54, 23);
            this.labelEdsName.Name = "labelEdsName";
            this.labelEdsName.Size = new System.Drawing.Size(50, 16);
            this.labelEdsName.TabIndex = 1;
            this.labelEdsName.Text = "Ürün *";
            // 
            // main
            // 
            this.main.Controls.Add(this.deleteProduct);
            this.main.Controls.Add(this.sellProductMain);
            this.main.Controls.Add(this.textBox5);
            this.main.Controls.Add(this.scanProductMain);
            this.main.Controls.Add(this.textBox1);
            this.main.Controls.Add(this.datagridMain);
            this.main.Controls.Add(this.totalPriceMain);
            this.main.Location = new System.Drawing.Point(565, 793);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(984, 727);
            this.main.TabIndex = 1;
            this.main.TabStop = false;
            this.main.Text = "ÜRÜNLER";
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(345, 436);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(75, 20);
            this.deleteProduct.TabIndex = 15;
            this.deleteProduct.Text = "SİL";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // sellProductMain
            // 
            this.sellProductMain.Location = new System.Drawing.Point(760, 433);
            this.sellProductMain.Name = "sellProductMain";
            this.sellProductMain.Size = new System.Drawing.Size(75, 23);
            this.sellProductMain.TabIndex = 14;
            this.sellProductMain.Text = "SAT";
            this.sellProductMain.UseVisualStyleBackColor = true;
            this.sellProductMain.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 462);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 12;
            this.textBox5.Visible = false;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // scanProductMain
            // 
            this.scanProductMain.Location = new System.Drawing.Point(264, 436);
            this.scanProductMain.Name = "scanProductMain";
            this.scanProductMain.Size = new System.Drawing.Size(75, 20);
            this.scanProductMain.TabIndex = 11;
            this.scanProductMain.Text = "ÇEK";
            this.scanProductMain.UseVisualStyleBackColor = true;
            this.scanProductMain.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 436);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 20);
            this.textBox1.TabIndex = 10;
            // 
            // datagridMain
            // 
            this.datagridMain.AllowUserToAddRows = false;
            this.datagridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridMain.Location = new System.Drawing.Point(6, 19);
            this.datagridMain.Name = "datagridMain";
            this.datagridMain.Size = new System.Drawing.Size(972, 408);
            this.datagridMain.TabIndex = 9;
            this.datagridMain.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridMain_CellEndEdit);
            this.datagridMain.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.datagridMain_EditingControlShowing);
            // 
            // logGroup
            // 
            this.logGroup.Controls.Add(this.datagridLog);
            this.logGroup.Controls.Add(this.label17);
            this.logGroup.Location = new System.Drawing.Point(12, 27);
            this.logGroup.Name = "logGroup";
            this.logGroup.Size = new System.Drawing.Size(1114, 733);
            this.logGroup.TabIndex = 1;
            this.logGroup.TabStop = false;
            this.logGroup.Text = "SATIŞ LOGLARI";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 713);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "lorem ipsum - test";
            // 
            // totalPriceMain
            // 
            this.totalPriceMain.AutoSize = true;
            this.totalPriceMain.Location = new System.Drawing.Point(841, 439);
            this.totalPriceMain.Name = "totalPriceMain";
            this.totalPriceMain.Size = new System.Drawing.Size(93, 13);
            this.totalPriceMain.TabIndex = 8;
            this.totalPriceMain.Text = "lorem ipsum - main";
            // 
            // header
            // 
            this.header.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.bToolStripMenuItem,
            this.cToolStripMenuItem,
            this.dToolStripMenuItem});
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1225, 24);
            this.header.TabIndex = 1;
            this.header.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.aToolStripMenuItem.Text = "Araçlar";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.bToolStripMenuItem.Text = "Ana";
            this.bToolStripMenuItem.Click += new System.EventHandler(this.bToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.cToolStripMenuItem.Text = "Loglar";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(26, 20);
            this.dToolStripMenuItem.Text = "d";
            // 
            // datagridLog
            // 
            this.datagridLog.AllowUserToAddRows = false;
            this.datagridLog.AllowUserToDeleteRows = false;
            this.datagridLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridLog.Location = new System.Drawing.Point(19, 19);
            this.datagridLog.Name = "datagridLog";
            this.datagridLog.ReadOnly = true;
            this.datagridLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridLog.Size = new System.Drawing.Size(1089, 688);
            this.datagridLog.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 812);
            this.Controls.Add(this.edspanel);
            this.Controls.Add(this.main);
            this.Controls.Add(this.header);
            this.Controls.Add(this.logGroup);
            this.MainMenuStrip = this.header;
            this.Name = "Form1";
            this.Text = "OT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.edspanel.ResumeLayout(false);
            this.edspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridEds)).EndInit();
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridMain)).EndInit();
            this.logGroup.ResumeLayout(false);
            this.logGroup.PerformLayout();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.GroupBox edspanel;
        private System.Windows.Forms.Label labelEdsName;
        private System.Windows.Forms.DateTimePicker pDateEds;
        private System.Windows.Forms.TextBox pPriceEds;
        private System.Windows.Forms.TextBox pCountEds;
        private System.Windows.Forms.TextBox pAboutEds;
        private System.Windows.Forms.TextBox pNameEds;
        private System.Windows.Forms.Label labelEdsExpDate;
        private System.Windows.Forms.Label labelEdsPrice;
        private System.Windows.Forms.Label labelEdsCount;
        private System.Windows.Forms.Label labelEdsEq;
        private System.Windows.Forms.Label labelEdsAbout;
        private System.Windows.Forms.CheckBox dateCheckBoxEds;
        private System.Windows.Forms.Button deleteBtnEds;
        private System.Windows.Forms.Button editBtnEds;
        private System.Windows.Forms.Button addBtnEds;
        private System.Windows.Forms.MenuStrip header;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.GroupBox main;
        private System.Windows.Forms.GroupBox logGroup;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label totalPriceMain;
        private System.Windows.Forms.DataGridView datagridEds;
        private System.Windows.Forms.Label labelEdsTicket;
        private System.Windows.Forms.ListBox pEquivalentEds;
        private System.Windows.Forms.ComboBox productBoxEds;
        private System.Windows.Forms.CheckBox showExtrasBoxEds;
        private System.Windows.Forms.TextBox pBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkboxEdit;
        private System.Windows.Forms.CheckBox checkBoxDelete;
        private System.Windows.Forms.RichTextBox explainerEds;
        private System.Windows.Forms.CheckBox dateExtraBox;
        private System.Windows.Forms.DataGridView datagridMain;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button scanProductMain;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button sellProductMain;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.DataGridView datagridLog;
    }
}

