
namespace SuperMarket_Projesi
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.productdv2 = new System.Windows.Forms.DataGridView();
            this.Supply = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PurchasePriceTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeletBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.UpdateBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.InsertBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PriceTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Detailstxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.QuenTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NameTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.prodId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CatCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sells = new System.Windows.Forms.Button();
            this.Category = new System.Windows.Forms.Button();
            this.Bills1 = new System.Windows.Forms.Button();
            this.Date1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productdv2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.Date1);
            this.panel1.Controls.Add(this.productdv2);
            this.panel1.Controls.Add(this.Supply);
            this.panel1.Controls.Add(this.PurchasePriceTxt);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuThinButton23);
            this.panel1.Controls.Add(this.DeletBtn);
            this.panel1.Controls.Add(this.UpdateBtn);
            this.panel1.Controls.Add(this.InsertBtn);
            this.panel1.Controls.Add(this.PriceTxt);
            this.panel1.Controls.Add(this.Detailstxt);
            this.panel1.Controls.Add(this.QuenTxt);
            this.panel1.Controls.Add(this.NameTxt);
            this.panel1.Controls.Add(this.prodId);
            this.panel1.Controls.Add(this.CatCB);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(111, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 504);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // productdv2
            // 
            this.productdv2.BackgroundColor = System.Drawing.Color.White;
            this.productdv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productdv2.Location = new System.Drawing.Point(319, 78);
            this.productdv2.Name = "productdv2";
            this.productdv2.Size = new System.Drawing.Size(400, 383);
            this.productdv2.TabIndex = 43;
            this.productdv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productdv2_CellContentClick_1);
            this.productdv2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productdv2_CellMouseClick);
            this.productdv2.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productdv2_ColumnHeaderMouseClick);
            this.productdv2.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productdv2_ColumnHeaderMouseDoubleClick);
            // 
            // Supply
            // 
            this.Supply.BackColor = System.Drawing.Color.DarkOrange;
            this.Supply.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Supply.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Supply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Supply.HintForeColor = System.Drawing.Color.Empty;
            this.Supply.HintText = "";
            this.Supply.isPassword = false;
            this.Supply.LineFocusedColor = System.Drawing.Color.Blue;
            this.Supply.LineIdleColor = System.Drawing.Color.White;
            this.Supply.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Supply.LineThickness = 4;
            this.Supply.Location = new System.Drawing.Point(104, 315);
            this.Supply.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Supply.Name = "Supply";
            this.Supply.Size = new System.Drawing.Size(126, 31);
            this.Supply.TabIndex = 42;
            this.Supply.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PurchasePriceTxt
            // 
            this.PurchasePriceTxt.BackColor = System.Drawing.Color.DarkOrange;
            this.PurchasePriceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PurchasePriceTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.PurchasePriceTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PurchasePriceTxt.HintForeColor = System.Drawing.Color.Empty;
            this.PurchasePriceTxt.HintText = "";
            this.PurchasePriceTxt.isPassword = false;
            this.PurchasePriceTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.PurchasePriceTxt.LineIdleColor = System.Drawing.Color.White;
            this.PurchasePriceTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.PurchasePriceTxt.LineThickness = 4;
            this.PurchasePriceTxt.Location = new System.Drawing.Point(102, 203);
            this.PurchasePriceTxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PurchasePriceTxt.Name = "PurchasePriceTxt";
            this.PurchasePriceTxt.Size = new System.Drawing.Size(126, 31);
            this.PurchasePriceTxt.TabIndex = 39;
            this.PurchasePriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(0, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 25);
            this.label10.TabIndex = 38;
            this.label10.Text = "Alışfiyatı";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(2, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 25);
            this.label9.TabIndex = 37;
            this.label9.Text = "Tedarikçi";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(3, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "Tarih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(209, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 37);
            this.label1.TabIndex = 32;
            this.label1.Text = "ÜRÜNLERİ YÖNET";
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.DarkOrange;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "yenile";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.Location = new System.Drawing.Point(612, 38);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(84, 37);
            this.bunifuThinButton23.TabIndex = 31;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeletBtn
            // 
            this.DeletBtn.ActiveBorderThickness = 1;
            this.DeletBtn.ActiveCornerRadius = 20;
            this.DeletBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.DeletBtn.ActiveForecolor = System.Drawing.Color.White;
            this.DeletBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.DeletBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.DeletBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeletBtn.BackgroundImage")));
            this.DeletBtn.ButtonText = "Sil";
            this.DeletBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletBtn.ForeColor = System.Drawing.Color.Transparent;
            this.DeletBtn.IdleBorderThickness = 1;
            this.DeletBtn.IdleCornerRadius = 20;
            this.DeletBtn.IdleFillColor = System.Drawing.Color.White;
            this.DeletBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.DeletBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.DeletBtn.Location = new System.Drawing.Point(202, 425);
            this.DeletBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DeletBtn.Name = "DeletBtn";
            this.DeletBtn.Size = new System.Drawing.Size(71, 46);
            this.DeletBtn.TabIndex = 26;
            this.DeletBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeletBtn.Click += new System.EventHandler(this.DeletBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.ActiveBorderThickness = 1;
            this.UpdateBtn.ActiveCornerRadius = 20;
            this.UpdateBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.UpdateBtn.ActiveForecolor = System.Drawing.Color.White;
            this.UpdateBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.UpdateBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.UpdateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.BackgroundImage")));
            this.UpdateBtn.ButtonText = "Güncelle";
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.IdleBorderThickness = 1;
            this.UpdateBtn.IdleCornerRadius = 20;
            this.UpdateBtn.IdleFillColor = System.Drawing.Color.White;
            this.UpdateBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.UpdateBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.UpdateBtn.Location = new System.Drawing.Point(102, 425);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(88, 46);
            this.UpdateBtn.TabIndex = 25;
            this.UpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateBtn.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.ActiveBorderThickness = 1;
            this.InsertBtn.ActiveCornerRadius = 20;
            this.InsertBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.InsertBtn.ActiveForecolor = System.Drawing.Color.White;
            this.InsertBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.InsertBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.InsertBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InsertBtn.BackgroundImage")));
            this.InsertBtn.ButtonText = "Ekle";
            this.InsertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBtn.ForeColor = System.Drawing.Color.Transparent;
            this.InsertBtn.IdleBorderThickness = 1;
            this.InsertBtn.IdleCornerRadius = 20;
            this.InsertBtn.IdleFillColor = System.Drawing.Color.White;
            this.InsertBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.InsertBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.InsertBtn.Location = new System.Drawing.Point(4, 425);
            this.InsertBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(80, 46);
            this.InsertBtn.TabIndex = 23;
            this.InsertBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InsertBtn.Click += new System.EventHandler(this.EkleButton_Click);
            // 
            // PriceTxt
            // 
            this.PriceTxt.BackColor = System.Drawing.Color.DarkOrange;
            this.PriceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.PriceTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PriceTxt.HintForeColor = System.Drawing.Color.Empty;
            this.PriceTxt.HintText = "";
            this.PriceTxt.isPassword = false;
            this.PriceTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.PriceTxt.LineIdleColor = System.Drawing.Color.White;
            this.PriceTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.PriceTxt.LineThickness = 4;
            this.PriceTxt.Location = new System.Drawing.Point(102, 170);
            this.PriceTxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(126, 31);
            this.PriceTxt.TabIndex = 22;
            this.PriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PriceTxt.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox5_OnValueChanged);
            // 
            // Detailstxt
            // 
            this.Detailstxt.BackColor = System.Drawing.Color.DarkOrange;
            this.Detailstxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Detailstxt.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Detailstxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Detailstxt.HintForeColor = System.Drawing.Color.Empty;
            this.Detailstxt.HintText = "";
            this.Detailstxt.isPassword = false;
            this.Detailstxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.Detailstxt.LineIdleColor = System.Drawing.Color.White;
            this.Detailstxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Detailstxt.LineThickness = 4;
            this.Detailstxt.Location = new System.Drawing.Point(102, 232);
            this.Detailstxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Detailstxt.Name = "Detailstxt";
            this.Detailstxt.Size = new System.Drawing.Size(126, 31);
            this.Detailstxt.TabIndex = 21;
            this.Detailstxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Detailstxt.OnValueChanged += new System.EventHandler(this.Detailstxt_OnValueChanged);
            // 
            // QuenTxt
            // 
            this.QuenTxt.BackColor = System.Drawing.Color.DarkOrange;
            this.QuenTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuenTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuenTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QuenTxt.HintForeColor = System.Drawing.Color.Empty;
            this.QuenTxt.HintText = "";
            this.QuenTxt.isPassword = false;
            this.QuenTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.QuenTxt.LineIdleColor = System.Drawing.Color.White;
            this.QuenTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.QuenTxt.LineThickness = 4;
            this.QuenTxt.Location = new System.Drawing.Point(102, 131);
            this.QuenTxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.QuenTxt.Name = "QuenTxt";
            this.QuenTxt.Size = new System.Drawing.Size(126, 31);
            this.QuenTxt.TabIndex = 20;
            this.QuenTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.QuenTxt.OnValueChanged += new System.EventHandler(this.QuenTxt_OnValueChanged);
            // 
            // NameTxt
            // 
            this.NameTxt.BackColor = System.Drawing.Color.DarkOrange;
            this.NameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameTxt.HintForeColor = System.Drawing.Color.Empty;
            this.NameTxt.HintText = "";
            this.NameTxt.isPassword = false;
            this.NameTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.NameTxt.LineIdleColor = System.Drawing.Color.White;
            this.NameTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.NameTxt.LineThickness = 4;
            this.NameTxt.Location = new System.Drawing.Point(102, 96);
            this.NameTxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(126, 31);
            this.NameTxt.TabIndex = 19;
            this.NameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NameTxt.OnValueChanged += new System.EventHandler(this.NameTxt_OnValueChanged);
            // 
            // prodId
            // 
            this.prodId.BackColor = System.Drawing.Color.DarkOrange;
            this.prodId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodId.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prodId.HintForeColor = System.Drawing.Color.Empty;
            this.prodId.HintText = "";
            this.prodId.isPassword = false;
            this.prodId.LineFocusedColor = System.Drawing.Color.Blue;
            this.prodId.LineIdleColor = System.Drawing.Color.White;
            this.prodId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.prodId.LineThickness = 4;
            this.prodId.Location = new System.Drawing.Point(102, 57);
            this.prodId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.prodId.Name = "prodId";
            this.prodId.Size = new System.Drawing.Size(126, 31);
            this.prodId.TabIndex = 18;
            this.prodId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CatCB
            // 
            this.CatCB.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatCB.ForeColor = System.Drawing.Color.DarkOrange;
            this.CatCB.FormattingEnabled = true;
            this.CatCB.Location = new System.Drawing.Point(102, 369);
            this.CatCB.Name = "CatCB";
            this.CatCB.Size = new System.Drawing.Size(121, 25);
            this.CatCB.TabIndex = 17;
            this.CatCB.Text = "Tedarikçi tipi Seç";
            this.CatCB.SelectedIndexChanged += new System.EventHandler(this.CatCB_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(1, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kategori";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(-1, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Açıklama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(3, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Satışfiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(2, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Miktar";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(1, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(1, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün ID";
            // 
            // Sells
            // 
            this.Sells.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sells.ForeColor = System.Drawing.Color.DarkOrange;
            this.Sells.Location = new System.Drawing.Point(12, 176);
            this.Sells.Name = "Sells";
            this.Sells.Size = new System.Drawing.Size(75, 32);
            this.Sells.TabIndex = 2;
            this.Sells.Text = " Satış";
            this.Sells.UseVisualStyleBackColor = true;
            this.Sells.Click += new System.EventHandler(this.button2_Click);
            // 
            // Category
            // 
            this.Category.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.ForeColor = System.Drawing.Color.DarkOrange;
            this.Category.Location = new System.Drawing.Point(3, 235);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(102, 32);
            this.Category.TabIndex = 3;
            this.Category.Text = "Kategori";
            this.Category.UseVisualStyleBackColor = true;
            this.Category.Click += new System.EventHandler(this.button3_Click);
            // 
            // Bills1
            // 
            this.Bills1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bills1.ForeColor = System.Drawing.Color.DarkOrange;
            this.Bills1.Location = new System.Drawing.Point(3, 124);
            this.Bills1.Name = "Bills1";
            this.Bills1.Size = new System.Drawing.Size(100, 32);
            this.Bills1.TabIndex = 4;
            this.Bills1.Text = "Faturalar";
            this.Bills1.UseVisualStyleBackColor = true;
            this.Bills1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Date1
            // 
            this.Date1.BackColor = System.Drawing.Color.Honeydew;
            this.Date1.BorderRadius = 0;
            this.Date1.ForeColor = System.Drawing.Color.DarkOrange;
            this.Date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date1.FormatCustom = "yyyy/MM/dd";
            this.Date1.Location = new System.Drawing.Point(102, 283);
            this.Date1.Name = "Date1";
            this.Date1.Size = new System.Drawing.Size(128, 26);
            this.Date1.TabIndex = 45;
            this.Date1.Value = new System.DateTime(2021, 12, 12, 0, 0, 0, 0);
            // 
            // ProductForm
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(839, 495);
            this.Controls.Add(this.Bills1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Sells);
            this.Name = "ProductForm";
            this.Text = "ÜrünForm";
            this.Load += new System.EventHandler(this.ÜrünForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productdv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Sells;
        private System.Windows.Forms.Button Category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CatCB;
        private Bunifu.Framework.UI.BunifuMaterialTextbox prodId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PriceTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Detailstxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox QuenTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NameTxt;
        private Bunifu.Framework.UI.BunifuThinButton2 InsertBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 UpdateBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 DeletBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PurchasePriceTxt;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Supply;
        private System.Windows.Forms.Button Bills1;
        private System.Windows.Forms.DataGridView productdv2;
        private Bunifu.Framework.UI.BunifuDatepicker Date1;
    }
}