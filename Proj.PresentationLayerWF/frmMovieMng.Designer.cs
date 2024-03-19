namespace Proj.PresentationLayerWF
{
	partial class frmMovieMng
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
			this.label3 = new System.Windows.Forms.Label();
			this.lstMovies = new System.Windows.Forms.ListBox();
			this.cmbCategories = new System.Windows.Forms.ComboBox();
			this.dateReleaseDate = new System.Windows.Forms.DateTimePicker();
			this.numPrice = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDirector = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMovieName = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnAddMovie = new System.Windows.Forms.Button();
			this.btnDeleteMovie = new System.Windows.Forms.Button();
			this.btnUpdateMovie = new System.Windows.Forms.Button();
			this.btnMain = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(534, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Mevcut Filmler";
			// 
			// lstMovies
			// 
			this.lstMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lstMovies.FormattingEnabled = true;
			this.lstMovies.ItemHeight = 18;
			this.lstMovies.Location = new System.Drawing.Point(401, 33);
			this.lstMovies.Name = "lstMovies";
			this.lstMovies.Size = new System.Drawing.Size(361, 292);
			this.lstMovies.TabIndex = 27;
			this.lstMovies.Click += new System.EventHandler(this.lstMovies_Click);
			// 
			// cmbCategories
			// 
			this.cmbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbCategories.FormattingEnabled = true;
			this.cmbCategories.Location = new System.Drawing.Point(127, 302);
			this.cmbCategories.Name = "cmbCategories";
			this.cmbCategories.Size = new System.Drawing.Size(229, 24);
			this.cmbCategories.TabIndex = 25;
			// 
			// dateReleaseDate
			// 
			this.dateReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dateReleaseDate.Location = new System.Drawing.Point(127, 227);
			this.dateReleaseDate.Name = "dateReleaseDate";
			this.dateReleaseDate.Size = new System.Drawing.Size(229, 23);
			this.dateReleaseDate.TabIndex = 24;
			// 
			// numPrice
			// 
			this.numPrice.DecimalPlaces = 2;
			this.numPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.numPrice.Location = new System.Drawing.Point(127, 46);
			this.numPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numPrice.Name = "numPrice";
			this.numPrice.Size = new System.Drawing.Size(229, 23);
			this.numPrice.TabIndex = 23;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(40, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 17);
			this.label2.TabIndex = 22;
			this.label2.Text = "Film Ücreti : ";
			// 
			// txtDirector
			// 
			this.txtDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtDirector.Location = new System.Drawing.Point(127, 267);
			this.txtDirector.Name = "txtDirector";
			this.txtDirector.Size = new System.Drawing.Size(229, 23);
			this.txtDirector.TabIndex = 19;
			// 
			// txtDescription
			// 
			this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtDescription.Location = new System.Drawing.Point(127, 82);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(229, 126);
			this.txtDescription.TabIndex = 20;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(53, 304);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 17);
			this.label6.TabIndex = 14;
			this.label6.Text = "Kategori : ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(42, 270);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 17);
			this.label5.TabIndex = 15;
			this.label5.Text = "Yönetmen : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(37, 230);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 17);
			this.label4.TabIndex = 16;
			this.label4.Text = "Çıkış Tarihi : ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(11, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 17);
			this.label1.TabIndex = 17;
			this.label1.Text = "Film Açıklaması : ";
			// 
			// txtMovieName
			// 
			this.txtMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtMovieName.Location = new System.Drawing.Point(127, 12);
			this.txtMovieName.Name = "txtMovieName";
			this.txtMovieName.Size = new System.Drawing.Size(229, 23);
			this.txtMovieName.TabIndex = 21;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.Location = new System.Drawing.Point(57, 13);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 17);
			this.label8.TabIndex = 18;
			this.label8.Text = "Film Adı : ";
			// 
			// btnAddMovie
			// 
			this.btnAddMovie.BackColor = System.Drawing.Color.Lime;
			this.btnAddMovie.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAddMovie.Location = new System.Drawing.Point(127, 344);
			this.btnAddMovie.Name = "btnAddMovie";
			this.btnAddMovie.Size = new System.Drawing.Size(229, 39);
			this.btnAddMovie.TabIndex = 12;
			this.btnAddMovie.Text = "Filmi Ekle";
			this.btnAddMovie.UseVisualStyleBackColor = false;
			this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
			// 
			// btnDeleteMovie
			// 
			this.btnDeleteMovie.BackColor = System.Drawing.Color.Red;
			this.btnDeleteMovie.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeleteMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDeleteMovie.Location = new System.Drawing.Point(401, 344);
			this.btnDeleteMovie.Name = "btnDeleteMovie";
			this.btnDeleteMovie.Size = new System.Drawing.Size(167, 39);
			this.btnDeleteMovie.TabIndex = 11;
			this.btnDeleteMovie.Text = "Filmi Sil";
			this.btnDeleteMovie.UseVisualStyleBackColor = false;
			this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
			// 
			// btnUpdateMovie
			// 
			this.btnUpdateMovie.BackColor = System.Drawing.Color.Turquoise;
			this.btnUpdateMovie.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUpdateMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdateMovie.Location = new System.Drawing.Point(595, 344);
			this.btnUpdateMovie.Name = "btnUpdateMovie";
			this.btnUpdateMovie.Size = new System.Drawing.Size(167, 39);
			this.btnUpdateMovie.TabIndex = 10;
			this.btnUpdateMovie.Text = "Filmi Güncelle";
			this.btnUpdateMovie.UseVisualStyleBackColor = false;
			this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
			// 
			// btnMain
			// 
			this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnMain.Location = new System.Drawing.Point(595, 389);
			this.btnMain.Name = "btnMain";
			this.btnMain.Size = new System.Drawing.Size(167, 30);
			this.btnMain.TabIndex = 28;
			this.btnMain.Text = "Ana Sayfa";
			this.btnMain.UseVisualStyleBackColor = true;
			this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
			// 
			// frmMovieMng
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(800, 425);
			this.Controls.Add(this.btnMain);
			this.Controls.Add(this.lstMovies);
			this.Controls.Add(this.cmbCategories);
			this.Controls.Add(this.dateReleaseDate);
			this.Controls.Add(this.numPrice);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtDirector);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtMovieName);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnUpdateMovie);
			this.Controls.Add(this.btnDeleteMovie);
			this.Controls.Add(this.btnAddMovie);
			this.Controls.Add(this.label3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmMovieMng";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Film Yönetimi";
			this.Load += new System.EventHandler(this.frmMovieMng_Load);
			((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox lstMovies;
		private System.Windows.Forms.ComboBox cmbCategories;
		private System.Windows.Forms.DateTimePicker dateReleaseDate;
		private System.Windows.Forms.NumericUpDown numPrice;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDirector;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMovieName;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnAddMovie;
		private System.Windows.Forms.Button btnDeleteMovie;
		private System.Windows.Forms.Button btnUpdateMovie;
		private System.Windows.Forms.Button btnMain;
	}
}