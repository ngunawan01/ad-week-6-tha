namespace ad_sem2_week6_tha_winsform_soalRoccaIdol
{
    partial class Form1
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
            this.dgvKiri = new System.Windows.Forms.DataGridView();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelStok = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelKategori = new System.Windows.Forms.Label();
            this.textBoxNamaKiri = new System.Windows.Forms.TextBox();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.textBoxStok = new System.Windows.Forms.TextBox();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.labelKategoriJudul = new System.Windows.Forms.Label();
            this.dgvKanan = new System.Windows.Forms.DataGridView();
            this.labelNamaKanan = new System.Windows.Forms.Label();
            this.textBoxNamaKanan = new System.Windows.Forms.TextBox();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.buttonRemoveCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKanan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKiri
            // 
            this.dgvKiri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKiri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKiri.Location = new System.Drawing.Point(31, 46);
            this.dgvKiri.Name = "dgvKiri";
            this.dgvKiri.RowHeadersWidth = 51;
            this.dgvKiri.RowTemplate.Height = 24;
            this.dgvKiri.Size = new System.Drawing.Size(403, 207);
            this.dgvKiri.TabIndex = 0;
            this.dgvKiri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKiri_CellClick);
            this.dgvKiri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKiri_CellContentClick);
            this.dgvKiri.SelectionChanged += new System.EventHandler(this.dgvKiri_SelectionChanged);
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(32, 11);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(53, 16);
            this.labelProduct.TabIndex = 1;
            this.labelProduct.Text = "Product";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Location = new System.Drawing.Point(39, 277);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(49, 16);
            this.labelDetails.TabIndex = 2;
            this.labelDetails.Text = "Details";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(48, 324);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(47, 16);
            this.labelNama.TabIndex = 3;
            this.labelNama.Text = "Nama:";
            // 
            // labelStok
            // 
            this.labelStok.AutoSize = true;
            this.labelStok.Location = new System.Drawing.Point(48, 425);
            this.labelStok.Name = "labelStok";
            this.labelStok.Size = new System.Drawing.Size(37, 16);
            this.labelStok.TabIndex = 4;
            this.labelStok.Text = "Stok:";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Location = new System.Drawing.Point(40, 395);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(48, 16);
            this.labelHarga.TabIndex = 5;
            this.labelHarga.Text = "Harga:";
            // 
            // labelKategori
            // 
            this.labelKategori.AutoSize = true;
            this.labelKategori.Location = new System.Drawing.Point(35, 358);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(60, 16);
            this.labelKategori.TabIndex = 6;
            this.labelKategori.Text = "Kategori:";
            // 
            // textBoxNamaKiri
            // 
            this.textBoxNamaKiri.Location = new System.Drawing.Point(109, 320);
            this.textBoxNamaKiri.Name = "textBoxNamaKiri";
            this.textBoxNamaKiri.Size = new System.Drawing.Size(306, 22);
            this.textBoxNamaKiri.TabIndex = 7;
            this.textBoxNamaKiri.TextChanged += new System.EventHandler(this.textBoxNamaKiri_TextChanged);
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(109, 392);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(100, 22);
            this.textBoxHarga.TabIndex = 8;
            this.textBoxHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHarga_KeyPress);
            // 
            // textBoxStok
            // 
            this.textBoxStok.Location = new System.Drawing.Point(109, 423);
            this.textBoxStok.Name = "textBoxStok";
            this.textBoxStok.Size = new System.Drawing.Size(100, 22);
            this.textBoxStok.TabIndex = 9;
            this.textBoxStok.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxStok_KeyDown);
            this.textBoxStok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStok_KeyPress);
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(109, 355);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(100, 24);
            this.comboBoxKategori.TabIndex = 10;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(218, 370);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(66, 59);
            this.buttonAddProduct.TabIndex = 11;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Location = new System.Drawing.Point(286, 370);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(69, 59);
            this.buttonEditProduct.TabIndex = 12;
            this.buttonEditProduct.Text = "Edit Product";
            this.buttonEditProduct.UseVisualStyleBackColor = true;
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(355, 370);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(71, 59);
            this.buttonRemove.TabIndex = 13;
            this.buttonRemove.Text = "Remove Product";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAll
            // 
            this.buttonAll.Location = new System.Drawing.Point(137, 11);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(75, 23);
            this.buttonAll.TabIndex = 14;
            this.buttonAll.Text = "Al";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(218, 11);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 15;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(305, 11);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFilter.TabIndex = 16;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // labelKategoriJudul
            // 
            this.labelKategoriJudul.AutoSize = true;
            this.labelKategoriJudul.Location = new System.Drawing.Point(494, 18);
            this.labelKategoriJudul.Name = "labelKategoriJudul";
            this.labelKategoriJudul.Size = new System.Drawing.Size(57, 16);
            this.labelKategoriJudul.TabIndex = 17;
            this.labelKategoriJudul.Text = "Kategori";
            // 
            // dgvKanan
            // 
            this.dgvKanan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKanan.Location = new System.Drawing.Point(497, 46);
            this.dgvKanan.Name = "dgvKanan";
            this.dgvKanan.RowHeadersWidth = 51;
            this.dgvKanan.RowTemplate.Height = 24;
            this.dgvKanan.Size = new System.Drawing.Size(240, 150);
            this.dgvKanan.TabIndex = 18;
            this.dgvKanan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKanan_CellClick);
            // 
            // labelNamaKanan
            // 
            this.labelNamaKanan.AutoSize = true;
            this.labelNamaKanan.Location = new System.Drawing.Point(511, 223);
            this.labelNamaKanan.Name = "labelNamaKanan";
            this.labelNamaKanan.Size = new System.Drawing.Size(47, 16);
            this.labelNamaKanan.TabIndex = 19;
            this.labelNamaKanan.Text = "Nama:";
            this.labelNamaKanan.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNamaKanan
            // 
            this.textBoxNamaKanan.Location = new System.Drawing.Point(564, 220);
            this.textBoxNamaKanan.Name = "textBoxNamaKanan";
            this.textBoxNamaKanan.Size = new System.Drawing.Size(160, 22);
            this.textBoxNamaKanan.TabIndex = 20;
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(564, 261);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(75, 45);
            this.buttonAddCategory.TabIndex = 21;
            this.buttonAddCategory.Text = "Add Category";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // buttonRemoveCategory
            // 
            this.buttonRemoveCategory.Location = new System.Drawing.Point(645, 261);
            this.buttonRemoveCategory.Name = "buttonRemoveCategory";
            this.buttonRemoveCategory.Size = new System.Drawing.Size(75, 45);
            this.buttonRemoveCategory.TabIndex = 22;
            this.buttonRemoveCategory.Text = "Remove Category";
            this.buttonRemoveCategory.UseVisualStyleBackColor = true;
            this.buttonRemoveCategory.Click += new System.EventHandler(this.buttonRemoveCategory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRemoveCategory);
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.textBoxNamaKanan);
            this.Controls.Add(this.labelNamaKanan);
            this.Controls.Add(this.dgvKanan);
            this.Controls.Add(this.labelKategoriJudul);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEditProduct);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.comboBoxKategori);
            this.Controls.Add(this.textBoxStok);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.textBoxNamaKiri);
            this.Controls.Add(this.labelKategori);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelStok);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.dgvKiri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKiri;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelStok;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.TextBox textBoxNamaKiri;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxStok;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonEditProduct;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Label labelKategoriJudul;
        private System.Windows.Forms.DataGridView dgvKanan;
        private System.Windows.Forms.Label labelNamaKanan;
        private System.Windows.Forms.TextBox textBoxNamaKanan;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Button buttonRemoveCategory;
    }
}

