namespace Proj.PresentationLayerWF
{
	partial class frmCategoryMng
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.lstCategories = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnAddCategory = new System.Windows.Forms.Button();
			this.btnDeleteCategory = new System.Windows.Forms.Button();
			this.btnUpdateCategory = new System.Windows.Forms.Button();
			this.btnMain = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(68, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kategori Adı : ";
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtName.Location = new System.Drawing.Point(165, 18);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(167, 24);
			this.txtName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(22, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Kategori Açıklaması : ";
			// 
			// txtDescription
			// 
			this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtDescription.Location = new System.Drawing.Point(165, 49);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(167, 160);
			this.txtDescription.TabIndex = 1;
			// 
			// lstCategories
			// 
			this.lstCategories.FormattingEnabled = true;
			this.lstCategories.Location = new System.Drawing.Point(372, 49);
			this.lstCategories.Name = "lstCategories";
			this.lstCategories.Size = new System.Drawing.Size(374, 160);
			this.lstCategories.TabIndex = 2;
			this.lstCategories.Click += new System.EventHandler(this.lstCategories_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(488, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Mevcut Kategoriler";
			// 
			// btnAddCategory
			// 
			this.btnAddCategory.BackColor = System.Drawing.Color.Lime;
			this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAddCategory.Location = new System.Drawing.Point(165, 226);
			this.btnAddCategory.Name = "btnAddCategory";
			this.btnAddCategory.Size = new System.Drawing.Size(167, 39);
			this.btnAddCategory.TabIndex = 3;
			this.btnAddCategory.Text = "Kategoriyi Ekle";
			this.btnAddCategory.UseVisualStyleBackColor = false;
			this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
			// 
			// btnDeleteCategory
			// 
			this.btnDeleteCategory.BackColor = System.Drawing.Color.Red;
			this.btnDeleteCategory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeleteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDeleteCategory.Location = new System.Drawing.Point(372, 226);
			this.btnDeleteCategory.Name = "btnDeleteCategory";
			this.btnDeleteCategory.Size = new System.Drawing.Size(167, 39);
			this.btnDeleteCategory.TabIndex = 3;
			this.btnDeleteCategory.Text = "Kategoriyi Sil";
			this.btnDeleteCategory.UseVisualStyleBackColor = false;
			this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
			// 
			// btnUpdateCategory
			// 
			this.btnUpdateCategory.BackColor = System.Drawing.Color.Turquoise;
			this.btnUpdateCategory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUpdateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdateCategory.Location = new System.Drawing.Point(579, 226);
			this.btnUpdateCategory.Name = "btnUpdateCategory";
			this.btnUpdateCategory.Size = new System.Drawing.Size(167, 39);
			this.btnUpdateCategory.TabIndex = 3;
			this.btnUpdateCategory.Text = "Kategoriyi Güncelle";
			this.btnUpdateCategory.UseVisualStyleBackColor = false;
			this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
			// 
			// btnMain
			// 
			this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnMain.Location = new System.Drawing.Point(579, 271);
			this.btnMain.Name = "btnMain";
			this.btnMain.Size = new System.Drawing.Size(167, 30);
			this.btnMain.TabIndex = 29;
			this.btnMain.Text = "Ana Sayfa";
			this.btnMain.UseVisualStyleBackColor = true;
			this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
			// 
			// frmCategoryMng
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(800, 306);
			this.Controls.Add(this.btnMain);
			this.Controls.Add(this.btnUpdateCategory);
			this.Controls.Add(this.btnDeleteCategory);
			this.Controls.Add(this.btnAddCategory);
			this.Controls.Add(this.lstCategories);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmCategoryMng";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kategori Yönetimi";
			this.Load += new System.EventHandler(this.frmCategoryMng_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.ListBox lstCategories;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnAddCategory;
		private System.Windows.Forms.Button btnDeleteCategory;
		private System.Windows.Forms.Button btnUpdateCategory;
		private System.Windows.Forms.Button btnMain;
	}
}