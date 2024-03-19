namespace Proj.PresentationLayerWF
{
	partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.btnProduct = new System.Windows.Forms.Button();
			this.btnMovie = new System.Windows.Forms.Button();
			this.btnCategory = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblMakeSale = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnProduct
			// 
			this.btnProduct.BackColor = System.Drawing.Color.DarkOrange;
			this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnProduct.FlatAppearance.BorderSize = 0;
			this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnProduct.Location = new System.Drawing.Point(69, 12);
			this.btnProduct.Name = "btnProduct";
			this.btnProduct.Size = new System.Drawing.Size(235, 153);
			this.btnProduct.TabIndex = 0;
			this.btnProduct.Text = "Ürün Yönetimi";
			this.btnProduct.UseVisualStyleBackColor = false;
			this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
			// 
			// btnMovie
			// 
			this.btnMovie.BackColor = System.Drawing.Color.Lime;
			this.btnMovie.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMovie.FlatAppearance.BorderSize = 0;
			this.btnMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnMovie.Location = new System.Drawing.Point(69, 432);
			this.btnMovie.Name = "btnMovie";
			this.btnMovie.Size = new System.Drawing.Size(235, 153);
			this.btnMovie.TabIndex = 0;
			this.btnMovie.Text = "Film Yönetimi";
			this.btnMovie.UseVisualStyleBackColor = false;
			this.btnMovie.Click += new System.EventHandler(this.btnMovie_Click);
			// 
			// btnCategory
			// 
			this.btnCategory.BackColor = System.Drawing.Color.Aquamarine;
			this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCategory.FlatAppearance.BorderSize = 0;
			this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCategory.Location = new System.Drawing.Point(305, 12);
			this.btnCategory.Name = "btnCategory";
			this.btnCategory.Size = new System.Drawing.Size(235, 153);
			this.btnCategory.TabIndex = 0;
			this.btnCategory.Text = "Kategori Yönetimi";
			this.btnCategory.UseVisualStyleBackColor = false;
			this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(69, 165);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(471, 267);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// lblMakeSale
			// 
			this.lblMakeSale.BackColor = System.Drawing.Color.Violet;
			this.lblMakeSale.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblMakeSale.FlatAppearance.BorderSize = 0;
			this.lblMakeSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblMakeSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.lblMakeSale.Location = new System.Drawing.Point(305, 432);
			this.lblMakeSale.Name = "lblMakeSale";
			this.lblMakeSale.Size = new System.Drawing.Size(235, 153);
			this.lblMakeSale.TabIndex = 2;
			this.lblMakeSale.Text = "Satış Yap";
			this.lblMakeSale.UseVisualStyleBackColor = false;
			this.lblMakeSale.Click += new System.EventHandler(this.lblMakeSale_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(606, 603);
			this.Controls.Add(this.lblMakeSale);
			this.Controls.Add(this.btnCategory);
			this.Controls.Add(this.btnMovie);
			this.Controls.Add(this.btnProduct);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ana Sayfa";
			this.Load += new System.EventHandler(this.frmMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnProduct;
		private System.Windows.Forms.Button btnMovie;
		private System.Windows.Forms.Button btnCategory;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button lblMakeSale;
	}
}