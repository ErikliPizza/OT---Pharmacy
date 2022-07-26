
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.datagridMain = new System.Windows.Forms.DataGridView();
            this.datagridLog = new System.Windows.Forms.DataGridView();
            this.tabControl = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tabPageFirst = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.dateExtraBox = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.showExtrasBoxEds = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.styleManager1 = new MetroSet_UI.Components.StyleManager();
            this.checkBoxDelete = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.checkboxEdit = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.dateCheckBoxEds = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.pNameEds = new System.Windows.Forms.TextBox();
            this.pPriceEds = new System.Windows.Forms.TextBox();
            this.pBarcode = new System.Windows.Forms.TextBox();
            this.pDateEds = new System.Windows.Forms.DateTimePicker();
            this.labelEdsTicket = new System.Windows.Forms.Label();
            this.pAboutEds = new System.Windows.Forms.TextBox();
            this.addBtnEds = new System.Windows.Forms.Button();
            this.explainerEds = new System.Windows.Forms.RichTextBox();
            this.editBtnEds = new System.Windows.Forms.Button();
            this.datagridEds = new System.Windows.Forms.DataGridView();
            this.deleteBtnEds = new System.Windows.Forms.Button();
            this.productBoxEds = new System.Windows.Forms.ComboBox();
            this.pEquivalentEds = new System.Windows.Forms.ListBox();
            this.pCountEds = new System.Windows.Forms.TextBox();
            this.tabPageSecond = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.tabPageThird = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.totalPriceMain = new MetroSet_UI.Controls.MetroSetLabel();
            ((System.ComponentModel.ISupportInitialize)(this.datagridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridLog)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageFirst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridEds)).BeginInit();
            this.tabPageSecond.SuspendLayout();
            this.tabPageThird.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(3, 400);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(10, 23);
            this.textBox5.TabIndex = 12;
            this.textBox5.Visible = false;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox1.Location = new System.Drawing.Point(3, 234);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(22, 16);
            this.textBox1.TabIndex = 10;
            // 
            // datagridMain
            // 
            this.datagridMain.AllowUserToAddRows = false;
            this.datagridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridMain.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.datagridMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.datagridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridMain.Location = new System.Drawing.Point(0, 3);
            this.datagridMain.Name = "datagridMain";
            this.datagridMain.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;
            this.datagridMain.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridMain.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridMain.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.datagridMain.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridMain.Size = new System.Drawing.Size(1320, 228);
            this.datagridMain.TabIndex = 9;
            this.datagridMain.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridMain_CellEndEdit);
            this.datagridMain.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.datagridMain_EditingControlShowing);
            // 
            // datagridLog
            // 
            this.datagridLog.AllowUserToAddRows = false;
            this.datagridLog.AllowUserToDeleteRows = false;
            this.datagridLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridLog.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.datagridLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.datagridLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridLog.Location = new System.Drawing.Point(3, 3);
            this.datagridLog.Name = "datagridLog";
            this.datagridLog.ReadOnly = true;
            this.datagridLog.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;
            this.datagridLog.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridLog.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridLog.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.datagridLog.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridLog.Size = new System.Drawing.Size(1188, 500);
            this.datagridLog.TabIndex = 9;
            // 
            // tabControl
            // 
            this.tabControl.AnimateEasingType = MetroSet_UI.Enums.EasingType.QuintIn;
            this.tabControl.AnimateTime = 500;
            this.tabControl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabControl.Controls.Add(this.tabPageFirst);
            this.tabControl.Controls.Add(this.tabPageSecond);
            this.tabControl.Controls.Add(this.tabPageThird);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl.IsDerivedStyle = true;
            this.tabControl.ItemSize = new System.Drawing.Size(100, 38);
            this.tabControl.Location = new System.Drawing.Point(4, 33);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.SelectedTextColor = System.Drawing.Color.White;
            this.tabControl.Size = new System.Drawing.Size(1331, 601);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.Speed = 100;
            this.tabControl.Style = MetroSet_UI.Enums.Style.Dark;
            this.tabControl.StyleManager = this.styleManager1;
            this.tabControl.TabIndex = 0;
            this.tabControl.ThemeAuthor = "Narwin";
            this.tabControl.ThemeName = "MetroDark";
            this.tabControl.UnselectedTextColor = System.Drawing.Color.Gray;
            this.tabControl.UseAnimation = false;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            this.tabControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl_KeyDown);
            // 
            // tabPageFirst
            // 
            this.tabPageFirst.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPageFirst.Controls.Add(this.dateExtraBox);
            this.tabPageFirst.Controls.Add(this.showExtrasBoxEds);
            this.tabPageFirst.Controls.Add(this.checkBoxDelete);
            this.tabPageFirst.Controls.Add(this.checkboxEdit);
            this.tabPageFirst.Controls.Add(this.dateCheckBoxEds);
            this.tabPageFirst.Controls.Add(this.metroSetLabel7);
            this.tabPageFirst.Controls.Add(this.metroSetLabel6);
            this.tabPageFirst.Controls.Add(this.metroSetLabel5);
            this.tabPageFirst.Controls.Add(this.metroSetLabel4);
            this.tabPageFirst.Controls.Add(this.metroSetLabel3);
            this.tabPageFirst.Controls.Add(this.metroSetLabel2);
            this.tabPageFirst.Controls.Add(this.metroSetLabel1);
            this.tabPageFirst.Controls.Add(this.pNameEds);
            this.tabPageFirst.Controls.Add(this.pPriceEds);
            this.tabPageFirst.Controls.Add(this.pBarcode);
            this.tabPageFirst.Controls.Add(this.pDateEds);
            this.tabPageFirst.Controls.Add(this.labelEdsTicket);
            this.tabPageFirst.Controls.Add(this.pAboutEds);
            this.tabPageFirst.Controls.Add(this.addBtnEds);
            this.tabPageFirst.Controls.Add(this.explainerEds);
            this.tabPageFirst.Controls.Add(this.editBtnEds);
            this.tabPageFirst.Controls.Add(this.datagridEds);
            this.tabPageFirst.Controls.Add(this.deleteBtnEds);
            this.tabPageFirst.Controls.Add(this.productBoxEds);
            this.tabPageFirst.Controls.Add(this.pEquivalentEds);
            this.tabPageFirst.Controls.Add(this.pCountEds);
            this.tabPageFirst.Font = null;
            this.tabPageFirst.ImageIndex = 0;
            this.tabPageFirst.ImageKey = null;
            this.tabPageFirst.IsDerivedStyle = true;
            this.tabPageFirst.Location = new System.Drawing.Point(4, 42);
            this.tabPageFirst.Name = "tabPageFirst";
            this.tabPageFirst.Size = new System.Drawing.Size(1323, 555);
            this.tabPageFirst.Style = MetroSet_UI.Enums.Style.Dark;
            this.tabPageFirst.StyleManager = this.styleManager1;
            this.tabPageFirst.TabIndex = 0;
            this.tabPageFirst.Text = "Araçlar";
            this.tabPageFirst.ThemeAuthor = "Narwin";
            this.tabPageFirst.ThemeName = "MetroDark";
            this.tabPageFirst.ToolTipText = null;
            // 
            // dateExtraBox
            // 
            this.dateExtraBox.BackColor = System.Drawing.Color.Transparent;
            this.dateExtraBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dateExtraBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.dateExtraBox.Checked = true;
            this.dateExtraBox.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.dateExtraBox.CheckState = MetroSet_UI.Enums.CheckState.Checked;
            this.dateExtraBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateExtraBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.dateExtraBox.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateExtraBox.IsDerivedStyle = true;
            this.dateExtraBox.Location = new System.Drawing.Point(1053, 511);
            this.dateExtraBox.Name = "dateExtraBox";
            this.dateExtraBox.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.dateExtraBox.Size = new System.Drawing.Size(270, 16);
            this.dateExtraBox.Style = MetroSet_UI.Enums.Style.Dark;
            this.dateExtraBox.StyleManager = null;
            this.dateExtraBox.TabIndex = 17;
            this.dateExtraBox.Text = "Anormal Durumlarda Beni Uyar";
            this.dateExtraBox.ThemeAuthor = "Narwin";
            this.dateExtraBox.ThemeName = "MetroDark";
            // 
            // showExtrasBoxEds
            // 
            this.showExtrasBoxEds.BackColor = System.Drawing.Color.Transparent;
            this.showExtrasBoxEds.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.showExtrasBoxEds.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.showExtrasBoxEds.Checked = true;
            this.showExtrasBoxEds.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.showExtrasBoxEds.CheckState = MetroSet_UI.Enums.CheckState.Checked;
            this.showExtrasBoxEds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showExtrasBoxEds.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.showExtrasBoxEds.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showExtrasBoxEds.IsDerivedStyle = true;
            this.showExtrasBoxEds.Location = new System.Drawing.Point(847, 511);
            this.showExtrasBoxEds.Name = "showExtrasBoxEds";
            this.showExtrasBoxEds.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.showExtrasBoxEds.Size = new System.Drawing.Size(200, 16);
            this.showExtrasBoxEds.Style = MetroSet_UI.Enums.Style.Dark;
            this.showExtrasBoxEds.StyleManager = this.styleManager1;
            this.showExtrasBoxEds.TabIndex = 16;
            this.showExtrasBoxEds.Text = "Bilgi Kutularını Göster";
            this.showExtrasBoxEds.ThemeAuthor = "Narwin";
            this.showExtrasBoxEds.ThemeName = "MetroDark";
            // 
            // styleManager1
            // 
            this.styleManager1.CustomTheme = "C:\\Users\\samsam\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.styleManager1.MetroForm = this;
            this.styleManager1.Style = MetroSet_UI.Enums.Style.Dark;
            this.styleManager1.ThemeAuthor = "Narwin";
            this.styleManager1.ThemeName = "MetroDark";
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.checkBoxDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.checkBoxDelete.Checked = false;
            this.checkBoxDelete.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.checkBoxDelete.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.checkBoxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxDelete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.checkBoxDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDelete.IsDerivedStyle = true;
            this.checkBoxDelete.Location = new System.Drawing.Point(545, 511);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.SignStyle = MetroSet_UI.Enums.SignStyle.Shape;
            this.checkBoxDelete.Size = new System.Drawing.Size(115, 16);
            this.checkBoxDelete.Style = MetroSet_UI.Enums.Style.Dark;
            this.checkBoxDelete.StyleManager = null;
            this.checkBoxDelete.TabIndex = 12;
            this.checkBoxDelete.Text = "Çoklu Silme";
            this.checkBoxDelete.ThemeAuthor = "Narwin";
            this.checkBoxDelete.ThemeName = "MetroDark";
            this.checkBoxDelete.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.checkBoxDelete_CheckedChanged);
            // 
            // checkboxEdit
            // 
            this.checkboxEdit.BackColor = System.Drawing.Color.Transparent;
            this.checkboxEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.checkboxEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.checkboxEdit.Checked = false;
            this.checkboxEdit.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.checkboxEdit.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.checkboxEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkboxEdit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.checkboxEdit.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxEdit.IsDerivedStyle = true;
            this.checkboxEdit.Location = new System.Drawing.Point(377, 511);
            this.checkboxEdit.Name = "checkboxEdit";
            this.checkboxEdit.SignStyle = MetroSet_UI.Enums.SignStyle.Shape;
            this.checkboxEdit.Size = new System.Drawing.Size(162, 16);
            this.checkboxEdit.Style = MetroSet_UI.Enums.Style.Dark;
            this.checkboxEdit.StyleManager = this.styleManager1;
            this.checkboxEdit.TabIndex = 11;
            this.checkboxEdit.Text = "Düzenleme Modu";
            this.checkboxEdit.ThemeAuthor = "Narwin";
            this.checkboxEdit.ThemeName = "MetroDark";
            this.checkboxEdit.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.checkboxEdit_CheckedChanged);
            // 
            // dateCheckBoxEds
            // 
            this.dateCheckBoxEds.BackColor = System.Drawing.Color.Transparent;
            this.dateCheckBoxEds.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dateCheckBoxEds.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.dateCheckBoxEds.Checked = false;
            this.dateCheckBoxEds.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.dateCheckBoxEds.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.dateCheckBoxEds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateCheckBoxEds.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.dateCheckBoxEds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateCheckBoxEds.IsDerivedStyle = true;
            this.dateCheckBoxEds.Location = new System.Drawing.Point(351, 195);
            this.dateCheckBoxEds.Name = "dateCheckBoxEds";
            this.dateCheckBoxEds.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.dateCheckBoxEds.Size = new System.Drawing.Size(20, 16);
            this.dateCheckBoxEds.Style = MetroSet_UI.Enums.Style.Dark;
            this.dateCheckBoxEds.StyleManager = this.styleManager1;
            this.dateCheckBoxEds.TabIndex = 13;
            this.dateCheckBoxEds.ThemeAuthor = "Narwin";
            this.dateCheckBoxEds.ThemeName = "MetroDark";
            this.dateCheckBoxEds.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.dateCheckBoxEds_CheckedChanged);
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel7.IsDerivedStyle = true;
            this.metroSetLabel7.Location = new System.Drawing.Point(0, 220);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(120, 23);
            this.metroSetLabel7.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel7.StyleManager = this.styleManager1;
            this.metroSetLabel7.TabIndex = 12;
            this.metroSetLabel7.Text = "MUADİLLER";
            this.metroSetLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel7.ThemeAuthor = "Narwin";
            this.metroSetLabel7.ThemeName = "MetroDark";
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel6.IsDerivedStyle = true;
            this.metroSetLabel6.Location = new System.Drawing.Point(0, 191);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(120, 23);
            this.metroSetLabel6.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel6.StyleManager = this.styleManager1;
            this.metroSetLabel6.TabIndex = 12;
            this.metroSetLabel6.Text = "SKT";
            this.metroSetLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel6.ThemeAuthor = "Narwin";
            this.metroSetLabel6.ThemeName = "MetroDark";
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(3, 162);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(117, 23);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel5.StyleManager = this.styleManager1;
            this.metroSetLabel5.TabIndex = 18;
            this.metroSetLabel5.Text = "AÇIKLAMA";
            this.metroSetLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroDark";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(0, 125);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(120, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel4.StyleManager = this.styleManager1;
            this.metroSetLabel4.TabIndex = 12;
            this.metroSetLabel4.Text = "BARKOD*";
            this.metroSetLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroDark";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(3, 96);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(117, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel3.StyleManager = this.styleManager1;
            this.metroSetLabel3.TabIndex = 12;
            this.metroSetLabel3.Text = "BİRİM FİYAT*";
            this.metroSetLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroDark";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(7, 67);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(113, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel2.StyleManager = this.styleManager1;
            this.metroSetLabel2.TabIndex = 12;
            this.metroSetLabel2.Text = "ADET*";
            this.metroSetLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroDark";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(7, 38);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(113, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel1.StyleManager = this.styleManager1;
            this.metroSetLabel1.TabIndex = 12;
            this.metroSetLabel1.Text = "ÜRÜN*";
            this.metroSetLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroDark";
            // 
            // pNameEds
            // 
            this.pNameEds.BackColor = System.Drawing.SystemColors.Info;
            this.pNameEds.Location = new System.Drawing.Point(126, 38);
            this.pNameEds.Name = "pNameEds";
            this.pNameEds.Size = new System.Drawing.Size(219, 23);
            this.pNameEds.TabIndex = 0;
            this.pNameEds.TextChanged += new System.EventHandler(this.pNameEds_TextChanged);
            // 
            // pPriceEds
            // 
            this.pPriceEds.BackColor = System.Drawing.SystemColors.Info;
            this.pPriceEds.Location = new System.Drawing.Point(126, 96);
            this.pPriceEds.Name = "pPriceEds";
            this.pPriceEds.Size = new System.Drawing.Size(219, 23);
            this.pPriceEds.TabIndex = 2;
            this.pPriceEds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pPriceEds_KeyPress);
            // 
            // pBarcode
            // 
            this.pBarcode.BackColor = System.Drawing.SystemColors.Info;
            this.pBarcode.Location = new System.Drawing.Point(126, 125);
            this.pBarcode.Name = "pBarcode";
            this.pBarcode.Size = new System.Drawing.Size(219, 23);
            this.pBarcode.TabIndex = 3;
            // 
            // pDateEds
            // 
            this.pDateEds.CustomFormat = "MM-yyyy";
            this.pDateEds.Enabled = false;
            this.pDateEds.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pDateEds.Location = new System.Drawing.Point(126, 191);
            this.pDateEds.Name = "pDateEds";
            this.pDateEds.Size = new System.Drawing.Size(219, 23);
            this.pDateEds.TabIndex = 5;
            // 
            // labelEdsTicket
            // 
            this.labelEdsTicket.AutoSize = true;
            this.labelEdsTicket.BackColor = System.Drawing.Color.Transparent;
            this.labelEdsTicket.Location = new System.Drawing.Point(3, 538);
            this.labelEdsTicket.Name = "labelEdsTicket";
            this.labelEdsTicket.Size = new System.Drawing.Size(125, 17);
            this.labelEdsTicket.TabIndex = 8;
            this.labelEdsTicket.Text = "lorem ipsum - EDS";
            // 
            // pAboutEds
            // 
            this.pAboutEds.BackColor = System.Drawing.SystemColors.Info;
            this.pAboutEds.Location = new System.Drawing.Point(126, 162);
            this.pAboutEds.Name = "pAboutEds";
            this.pAboutEds.Size = new System.Drawing.Size(219, 23);
            this.pAboutEds.TabIndex = 4;
            // 
            // addBtnEds
            // 
            this.addBtnEds.BackColor = System.Drawing.SystemColors.GrayText;
            this.addBtnEds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtnEds.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtnEds.ForeColor = System.Drawing.Color.Black;
            this.addBtnEds.Location = new System.Drawing.Point(104, 418);
            this.addBtnEds.Name = "addBtnEds";
            this.addBtnEds.Size = new System.Drawing.Size(71, 27);
            this.addBtnEds.TabIndex = 8;
            this.addBtnEds.Text = "EKLE";
            this.addBtnEds.UseVisualStyleBackColor = false;
            this.addBtnEds.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // explainerEds
            // 
            this.explainerEds.BackColor = System.Drawing.SystemColors.Info;
            this.explainerEds.Location = new System.Drawing.Point(377, 420);
            this.explainerEds.Name = "explainerEds";
            this.explainerEds.ReadOnly = true;
            this.explainerEds.Size = new System.Drawing.Size(943, 85);
            this.explainerEds.TabIndex = 11;
            this.explainerEds.Text = "";
            // 
            // editBtnEds
            // 
            this.editBtnEds.BackColor = System.Drawing.SystemColors.GrayText;
            this.editBtnEds.Enabled = false;
            this.editBtnEds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtnEds.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtnEds.ForeColor = System.Drawing.Color.Black;
            this.editBtnEds.Location = new System.Drawing.Point(181, 418);
            this.editBtnEds.Name = "editBtnEds";
            this.editBtnEds.Size = new System.Drawing.Size(94, 27);
            this.editBtnEds.TabIndex = 9;
            this.editBtnEds.Text = "DÜZENLE";
            this.editBtnEds.UseVisualStyleBackColor = false;
            this.editBtnEds.Click += new System.EventHandler(this.editBtnEds_Click);
            // 
            // datagridEds
            // 
            this.datagridEds.AllowUserToAddRows = false;
            this.datagridEds.AllowUserToDeleteRows = false;
            this.datagridEds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridEds.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.datagridEds.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridEds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.datagridEds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridEds.Location = new System.Drawing.Point(377, 38);
            this.datagridEds.MultiSelect = false;
            this.datagridEds.Name = "datagridEds";
            this.datagridEds.ReadOnly = true;
            this.datagridEds.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;
            this.datagridEds.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridEds.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridEds.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.datagridEds.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridEds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridEds.Size = new System.Drawing.Size(943, 376);
            this.datagridEds.TabIndex = 13;
            this.datagridEds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridEds_CellClick);
            // 
            // deleteBtnEds
            // 
            this.deleteBtnEds.BackColor = System.Drawing.SystemColors.GrayText;
            this.deleteBtnEds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtnEds.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtnEds.ForeColor = System.Drawing.Color.Black;
            this.deleteBtnEds.Location = new System.Drawing.Point(281, 418);
            this.deleteBtnEds.Name = "deleteBtnEds";
            this.deleteBtnEds.Size = new System.Drawing.Size(79, 27);
            this.deleteBtnEds.TabIndex = 10;
            this.deleteBtnEds.Text = "SİL";
            this.deleteBtnEds.UseVisualStyleBackColor = false;
            this.deleteBtnEds.Click += new System.EventHandler(this.deleteBtnEds_Click);
            // 
            // productBoxEds
            // 
            this.productBoxEds.BackColor = System.Drawing.SystemColors.Info;
            this.productBoxEds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.productBoxEds.FormattingEnabled = true;
            this.productBoxEds.Location = new System.Drawing.Point(126, 220);
            this.productBoxEds.Name = "productBoxEds";
            this.productBoxEds.Size = new System.Drawing.Size(219, 99);
            this.productBoxEds.TabIndex = 6;
            this.productBoxEds.SelectedIndexChanged += new System.EventHandler(this.productBoxEds_SelectedIndexChanged);
            // 
            // pEquivalentEds
            // 
            this.pEquivalentEds.BackColor = System.Drawing.SystemColors.Info;
            this.pEquivalentEds.FormattingEnabled = true;
            this.pEquivalentEds.ItemHeight = 16;
            this.pEquivalentEds.Location = new System.Drawing.Point(126, 325);
            this.pEquivalentEds.Name = "pEquivalentEds";
            this.pEquivalentEds.Size = new System.Drawing.Size(219, 84);
            this.pEquivalentEds.TabIndex = 7;
            this.pEquivalentEds.SelectedIndexChanged += new System.EventHandler(this.pEquivalentEds_SelectedIndexChanged);
            // 
            // pCountEds
            // 
            this.pCountEds.BackColor = System.Drawing.SystemColors.Info;
            this.pCountEds.Location = new System.Drawing.Point(126, 67);
            this.pCountEds.Name = "pCountEds";
            this.pCountEds.Size = new System.Drawing.Size(219, 23);
            this.pCountEds.TabIndex = 1;
            this.pCountEds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pCountEds_KeyPress);
            // 
            // tabPageSecond
            // 
            this.tabPageSecond.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPageSecond.Controls.Add(this.totalPriceMain);
            this.tabPageSecond.Controls.Add(this.textBox5);
            this.tabPageSecond.Controls.Add(this.datagridMain);
            this.tabPageSecond.Controls.Add(this.textBox1);
            this.tabPageSecond.Font = null;
            this.tabPageSecond.ImageIndex = 0;
            this.tabPageSecond.ImageKey = null;
            this.tabPageSecond.IsDerivedStyle = true;
            this.tabPageSecond.Location = new System.Drawing.Point(4, 42);
            this.tabPageSecond.Name = "tabPageSecond";
            this.tabPageSecond.Size = new System.Drawing.Size(1323, 555);
            this.tabPageSecond.Style = MetroSet_UI.Enums.Style.Dark;
            this.tabPageSecond.StyleManager = this.styleManager1;
            this.tabPageSecond.TabIndex = 1;
            this.tabPageSecond.Text = "Ana";
            this.tabPageSecond.ThemeAuthor = "Narwin";
            this.tabPageSecond.ThemeName = "MetroDark";
            this.tabPageSecond.ToolTipText = null;
            this.tabPageSecond.Click += new System.EventHandler(this.tabPageSecond_Click);
            // 
            // tabPageThird
            // 
            this.tabPageThird.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPageThird.Controls.Add(this.datagridLog);
            this.tabPageThird.Font = null;
            this.tabPageThird.ImageIndex = 0;
            this.tabPageThird.ImageKey = null;
            this.tabPageThird.IsDerivedStyle = true;
            this.tabPageThird.Location = new System.Drawing.Point(4, 42);
            this.tabPageThird.Name = "tabPageThird";
            this.tabPageThird.Size = new System.Drawing.Size(1323, 555);
            this.tabPageThird.Style = MetroSet_UI.Enums.Style.Dark;
            this.tabPageThird.StyleManager = this.styleManager1;
            this.tabPageThird.TabIndex = 2;
            this.tabPageThird.Text = "Loglar";
            this.tabPageThird.ThemeAuthor = "Narwin";
            this.tabPageThird.ThemeName = "MetroDark";
            this.tabPageThird.ToolTipText = null;
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.Silver;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(1235, 2);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetControlBox1.StyleManager = this.styleManager1;
            this.metroSetControlBox1.TabIndex = 17;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroDark";
            // 
            // totalPriceMain
            // 
            this.totalPriceMain.AccessibleName = "";
            this.totalPriceMain.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceMain.IsDerivedStyle = true;
            this.totalPriceMain.Location = new System.Drawing.Point(1220, 234);
            this.totalPriceMain.Name = "totalPriceMain";
            this.totalPriceMain.Size = new System.Drawing.Size(100, 23);
            this.totalPriceMain.Style = MetroSet_UI.Enums.Style.Dark;
            this.totalPriceMain.StyleManager = null;
            this.totalPriceMain.TabIndex = 13;
            this.totalPriceMain.Text = "TOPLAM";
            this.totalPriceMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalPriceMain.ThemeAuthor = "Narwin";
            this.totalPriceMain.ThemeName = "MetroDark";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1363, 671);
            this.ControlBox = false;
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.tabControl);
            this.HeaderHeight = 30;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(12, 90, 12, 12);
            this.ShowLeftRect = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.StyleManager = this.styleManager1;
            this.Text = "PHARMA OT";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridLog)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageFirst.ResumeLayout(false);
            this.tabPageFirst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridEds)).EndInit();
            this.tabPageSecond.ResumeLayout(false);
            this.tabPageSecond.PerformLayout();
            this.tabPageThird.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion
        private System.Windows.Forms.DataGridView datagridMain;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView datagridLog;
        private MetroSet_UI.Controls.MetroSetTabControl tabControl;
        private MetroSet_UI.Child.MetroSetSetTabPage tabPageSecond;
        private MetroSet_UI.Child.MetroSetSetTabPage tabPageThird;
        private MetroSet_UI.Components.StyleManager styleManager1;
        private MetroSet_UI.Child.MetroSetSetTabPage tabPageFirst;
        private System.Windows.Forms.TextBox pNameEds;
        private System.Windows.Forms.TextBox pPriceEds;
        private System.Windows.Forms.TextBox pBarcode;
        private System.Windows.Forms.DateTimePicker pDateEds;
        private System.Windows.Forms.Label labelEdsTicket;
        private System.Windows.Forms.TextBox pAboutEds;
        private System.Windows.Forms.Button addBtnEds;
        private System.Windows.Forms.RichTextBox explainerEds;
        private System.Windows.Forms.Button editBtnEds;
        private System.Windows.Forms.DataGridView datagridEds;
        private System.Windows.Forms.Button deleteBtnEds;
        private System.Windows.Forms.ComboBox productBoxEds;
        private System.Windows.Forms.ListBox pEquivalentEds;
        private System.Windows.Forms.TextBox pCountEds;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetCheckBox dateCheckBoxEds;
        private MetroSet_UI.Controls.MetroSetCheckBox checkboxEdit;
        private MetroSet_UI.Controls.MetroSetCheckBox checkBoxDelete;
        private MetroSet_UI.Controls.MetroSetCheckBox dateExtraBox;
        private MetroSet_UI.Controls.MetroSetCheckBox showExtrasBoxEds;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetLabel totalPriceMain;
    }
}

