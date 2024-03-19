using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proj.PresentationLayerWF
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void btnProduct_Click(object sender, EventArgs e)
		{
			frmProductMng product = new frmProductMng();
			product.Show();
			this.Hide();
		}

		private void btnCategory_Click(object sender, EventArgs e)
		{
			frmCategoryMng category = new frmCategoryMng();
			category.Show();
			this.Hide();
		}

		private void btnMovie_Click(object sender, EventArgs e)
		{
			frmMovieMng movie = new frmMovieMng();
			movie.Show();
			this.Hide();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			this.MaximumSize = new Size(622, 642);
			this.MinimumSize = new Size(622, 642);
		}

		private void lblMakeSale_Click(object sender, EventArgs e)
		{
			frmSaleMng sale = new frmSaleMng();
			sale.Show();
			this.Hide();
		}
	}
}
