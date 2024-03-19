namespace Proj.PresentationLayerWF
{
	partial class frmProductMng
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
			this.btnAddProduct = new System.Windows.Forms.Button();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.numProductPrice = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lstProducts = new System.Windows.Forms.ListBox();
			this.btnDeleteProduct = new System.Windows.Forms.Button();
			this.btnUpdateProduct = new System.Windows.Forms.Button();
			this.btnMain = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numProductPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAddProduct
			// 
			this.btnAddProduct.BackColor = System.Drawing.Color.Lime;
			this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAddProduct.Location = new System.Drawing.Point(90, 96);
			this.btnAddProduct.Name = "btnAddProduct";
			this.btnAddProduct.Size = new System.Drawing.Size(171, 38);
			this.btnAddProduct.TabIndex = 0;
			this.btnAddProduct.Text = "Ürünü Ekle";
			this.btnAddProduct.UseVisualStyleBackColor = false;
			this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
			// 
			// txtProductName
			// 
			this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtProductName.Location = new System.Drawing.Point(90, 25);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(173, 23);
			this.txtProductName.TabIndex = 1;
			// 
			// numProductPrice
			// 
			this.numProductPrice.DecimalPlaces = 2;
			this.numProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.numProductPrice.Location = new System.Drawing.Point(90, 58);
			this.numProductPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numProductPrice.Name = "numProductPrice";
			this.numProductPrice.Size = new System.Drawing.Size(173, 23);
			this.numProductPrice.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(13, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Ürün Adı : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(38, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Fiyat : ";
			// 
			// lstProducts
			// 
			this.lstProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lstProducts.FormattingEnabled = true;
			this.lstProducts.ItemHeight = 18;
			this.lstProducts.Location = new System.Drawing.Point(294, 25);
			this.lstProducts.Name = "lstProducts";
			this.lstProducts.Size = new System.Drawing.Size(457, 202);
			this.lstProducts.TabIndex = 5;
			this.lstProducts.Click += new System.EventHandler(this.lstProducts_Click);
			// 
			// btnDeleteProduct
			// 
			this.btnDeleteProduct.BackColor = System.Drawing.Color.Red;
			this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDeleteProduct.Location = new System.Drawing.Point(90, 144);
			this.btnDeleteProduct.Name = "btnDeleteProduct";
			this.btnDeleteProduct.Size = new System.Drawing.Size(171, 37);
			this.btnDeleteProduct.TabIndex = 6;
			this.btnDeleteProduct.Text = "Ürünü Sil";
			this.btnDeleteProduct.UseVisualStyleBackColor = false;
			this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
			// 
			// btnUpdateProduct
			// 
			this.btnUpdateProduct.BackColor = System.Drawing.Color.Turquoise;
			this.btnUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdateProduct.Location = new System.Drawing.Point(90, 190);
			this.btnUpdateProduct.Name = "btnUpdateProduct";
			this.btnUpdateProduct.Size = new System.Drawing.Size(171, 37);
			this.btnUpdateProduct.TabIndex = 7;
			this.btnUpdateProduct.Text = "Ürünü Güncelle";
			this.btnUpdateProduct.UseVisualStyleBackColor = false;
			this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
			// 
			// btnMain
			// 
			this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnMain.Location = new System.Drawing.Point(580, 233);
			this.btnMain.Name = "btnMain";
			this.btnMain.Size = new System.Drawing.Size(171, 30);
			this.btnMain.TabIndex = 8;
			this.btnMain.Text = "Ana Sayfa";
			this.btnMain.UseVisualStyleBackColor = true;
			this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
			// 
			// frmProductMng
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(782, 267);
			this.Controls.Add(this.btnMain);
			this.Controls.Add(this.btnUpdateProduct);
			this.Controls.Add(this.btnDeleteProduct);
			this.Controls.Add(this.lstProducts);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numProductPrice);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.btnAddProduct);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmProductMng";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ürün Yönetimi";
			this.Load += new System.EventHandler(this.frmProductMng_Load);
			((System.ComponentModel.ISupportInitialize)(this.numProductPrice)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAddProduct;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.NumericUpDown numProductPrice;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox lstProducts;
		private System.Windows.Forms.Button btnDeleteProduct;
		private System.Windows.Forms.Button btnUpdateProduct;
		private System.Windows.Forms.Button btnMain;
	}
}