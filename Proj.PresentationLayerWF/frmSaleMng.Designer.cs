namespace Proj.PresentationLayerWF
{
	partial class frmSaleMng
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
			this.btnMakeSale = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.cmbMovies = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbProducts = new System.Windows.Forms.ComboBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnMain = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lblTotalPrice = new System.Windows.Forms.Label();
			this.btnCompleteSalement = new System.Windows.Forms.Button();
			this.lstLastSales = new System.Windows.Forms.ListBox();
			this.btnCancelProduct = new System.Windows.Forms.Button();
			this.btnCancelMovie = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnMakeSale
			// 
			this.btnMakeSale.BackColor = System.Drawing.Color.LimeGreen;
			this.btnMakeSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnMakeSale.Location = new System.Drawing.Point(121, 184);
			this.btnMakeSale.Name = "btnMakeSale";
			this.btnMakeSale.Size = new System.Drawing.Size(209, 36);
			this.btnMakeSale.TabIndex = 0;
			this.btnMakeSale.Text = "Satış Yap";
			this.btnMakeSale.UseVisualStyleBackColor = false;
			this.btnMakeSale.Click += new System.EventHandler(this.btnMakeSale_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(31, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "Müşteri Adı : ";
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCustomerName.Location = new System.Drawing.Point(121, 12);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(209, 24);
			this.txtCustomerName.TabIndex = 2;
			// 
			// cmbMovies
			// 
			this.cmbMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbMovies.FormattingEnabled = true;
			this.cmbMovies.Location = new System.Drawing.Point(121, 48);
			this.cmbMovies.Name = "cmbMovies";
			this.cmbMovies.Size = new System.Drawing.Size(209, 26);
			this.cmbMovies.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(76, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Film : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(72, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 18);
			this.label3.TabIndex = 1;
			this.label3.Text = "Ürün : ";
			// 
			// cmbProducts
			// 
			this.cmbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbProducts.FormattingEnabled = true;
			this.cmbProducts.Location = new System.Drawing.Point(121, 87);
			this.cmbProducts.Name = "cmbProducts";
			this.cmbProducts.Size = new System.Drawing.Size(209, 26);
			this.cmbProducts.TabIndex = 3;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.OrangeRed;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCancel.Location = new System.Drawing.Point(121, 226);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(209, 36);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "İptal Et";
			this.btnCancel.UseVisualStyleBackColor = false;
			// 
			// btnMain
			// 
			this.btnMain.Location = new System.Drawing.Point(149, 268);
			this.btnMain.Name = "btnMain";
			this.btnMain.Size = new System.Drawing.Size(155, 30);
			this.btnMain.TabIndex = 5;
			this.btnMain.Text = "Ana Sayfa";
			this.btnMain.UseVisualStyleBackColor = true;
			this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(169, 167);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Toplam Tutar : ";
			// 
			// lblTotalPrice
			// 
			this.lblTotalPrice.AutoSize = true;
			this.lblTotalPrice.Location = new System.Drawing.Point(247, 168);
			this.lblTotalPrice.Name = "lblTotalPrice";
			this.lblTotalPrice.Size = new System.Drawing.Size(28, 13);
			this.lblTotalPrice.TabIndex = 7;
			this.lblTotalPrice.Text = "0,00";
			// 
			// btnCompleteSalement
			// 
			this.btnCompleteSalement.Location = new System.Drawing.Point(140, 130);
			this.btnCompleteSalement.Name = "btnCompleteSalement";
			this.btnCompleteSalement.Size = new System.Drawing.Size(175, 34);
			this.btnCompleteSalement.TabIndex = 8;
			this.btnCompleteSalement.Text = "Ürünü / Filmi Ekle";
			this.btnCompleteSalement.UseVisualStyleBackColor = true;
			this.btnCompleteSalement.Click += new System.EventHandler(this.btnCompleteSalement_Click);
			// 
			// lstLastSales
			// 
			this.lstLastSales.FormattingEnabled = true;
			this.lstLastSales.HorizontalScrollbar = true;
			this.lstLastSales.Location = new System.Drawing.Point(404, 12);
			this.lstLastSales.Name = "lstLastSales";
			this.lstLastSales.ScrollAlwaysVisible = true;
			this.lstLastSales.Size = new System.Drawing.Size(318, 277);
			this.lstLastSales.TabIndex = 9;
			// 
			// btnCancelProduct
			// 
			this.btnCancelProduct.BackColor = System.Drawing.Color.RosyBrown;
			this.btnCancelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCancelProduct.Location = new System.Drawing.Point(334, 87);
			this.btnCancelProduct.Name = "btnCancelProduct";
			this.btnCancelProduct.Size = new System.Drawing.Size(47, 26);
			this.btnCancelProduct.TabIndex = 10;
			this.btnCancelProduct.Text = "X";
			this.btnCancelProduct.UseVisualStyleBackColor = false;
			this.btnCancelProduct.Click += new System.EventHandler(this.btnCancelProduct_Click);
			// 
			// btnCancelMovie
			// 
			this.btnCancelMovie.BackColor = System.Drawing.Color.RosyBrown;
			this.btnCancelMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCancelMovie.Location = new System.Drawing.Point(334, 48);
			this.btnCancelMovie.Name = "btnCancelMovie";
			this.btnCancelMovie.Size = new System.Drawing.Size(47, 26);
			this.btnCancelMovie.TabIndex = 10;
			this.btnCancelMovie.Text = "X";
			this.btnCancelMovie.UseVisualStyleBackColor = false;
			this.btnCancelMovie.Click += new System.EventHandler(this.btnCancelMovie_Click);
			// 
			// frmSaleMng
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(734, 315);
			this.Controls.Add(this.btnCancelMovie);
			this.Controls.Add(this.btnCancelProduct);
			this.Controls.Add(this.lstLastSales);
			this.Controls.Add(this.btnCompleteSalement);
			this.Controls.Add(this.lblTotalPrice);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnMain);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.cmbProducts);
			this.Controls.Add(this.cmbMovies);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCustomerName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnMakeSale);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmSaleMng";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Satış Yönetimi";
			this.Load += new System.EventHandler(this.frmSaleMng_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnMakeSale;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.ComboBox cmbMovies;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbProducts;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnMain;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblTotalPrice;
		private System.Windows.Forms.Button btnCompleteSalement;
		private System.Windows.Forms.ListBox lstLastSales;
		private System.Windows.Forms.Button btnCancelProduct;
		private System.Windows.Forms.Button btnCancelMovie;
	}
}