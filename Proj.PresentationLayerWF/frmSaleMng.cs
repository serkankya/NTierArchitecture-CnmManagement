using Proj.BusinessLogicLayer.DesignPatterns.GenericRepository.ConcreteRep;
using Proj.EntityLayer.Models;
using Proj.PresentationLayerWF.ViewModels;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proj.PresentationLayerWF
{
	public partial class frmSaleMng : Form
	{
		MovieRepository _movieRepo;
		ProductRepository _productRepo;
		SaleDetailRepository _saleDetailRepo;
		SaleRepository _saleRepo;
		public frmSaleMng()
		{
			InitializeComponent();
			_movieRepo = new MovieRepository();
			_productRepo = new ProductRepository();
			_saleDetailRepo = new SaleDetailRepository();
			_saleRepo = new SaleRepository();
		}

		void ListMovies()
		{
			cmbMovies.DataSource = _movieRepo.Select(x => new MovieVM
			{
				ID = x.ID,
				Name = x.Name,
				Description = x.Description,
				Director = x.Director,
				TicketPrice = x.TicketPrice,
				ReleaseDate = x.ReleaseDate,
				CategoryName = x.Category == null ? "Kategori Bulunamadı" : x.Category.Name,
				CategoryID = x.CategoryID
			}).ToList();

			cmbMovies.DisplayMember = "Name";
			cmbMovies.ValueMember = "ID";
		}

		void ListProducts()
		{
			cmbProducts.DataSource = _productRepo.Select(x => new ProductVM
			{
				ID = x.ID,
				Name = x.Name,
				Price = x.Price
			}).ToList();

			cmbProducts.DisplayMember = "Name";
			cmbProducts.ValueMember = "ID";
		}

		private void frmSaleMng_Load(object sender, EventArgs e)
		{
			ListMovies();
			ListProducts();

			this.MaximumSize = new Size(750, 354);
			this.MinimumSize = new Size(750, 354);
		}

		private void btnMakeSale_Click(object sender, EventArgs e)
		{
			if (cmbProducts.SelectedIndex < -1 || string.IsNullOrEmpty(txtCustomerName.Text))
			{
				MessageBox.Show("Lütfen ilgili yerleri doldurunuz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Sale _s = new Sale();
			_s.CustomerName = txtCustomerName.Text;
			_saleRepo.Add(_s);

			SaleDetail _sd = new SaleDetail();
			_sd.SaleID = Convert.ToInt32(_s.ID);
			_sd.ProductID = Convert.ToInt32(cmbProducts.SelectedValue);
			_sd.MovieID = Convert.ToInt32(cmbMovies.SelectedValue);
			_saleDetailRepo.Add(_sd);

			lstLastSales.Items.Add("İşlemi Yapan Müşteri : " + txtCustomerName.Text);
			lstLastSales.Items.Add("------------İşlem Sonu-------------");
			lstLastSales.Items.Add("-----------------------------------");

			MessageBox.Show("Satış başarıyla tamamlandı.", "Satış İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		int i = 0; decimal TotalPrice = 0;
		private void btnCompleteSalement_Click(object sender, EventArgs e)
		{
			i++;
			if (cmbMovies.SelectedItem != null && cmbProducts.SelectedItem != null)
			{
				lstLastSales.Items.Add($"{i}. Satış = Film : " + cmbMovies.SelectedItem + " / Ürün : " + cmbProducts.SelectedItem);
				TotalPrice += _productRepo.Find(Convert.ToInt32(cmbProducts.SelectedValue)).Price;
				TotalPrice += _movieRepo.Find(Convert.ToInt32(cmbMovies.SelectedValue)).TicketPrice;
				lblTotalPrice.Text = TotalPrice.ToString("C2");
			}
			else if (cmbProducts.SelectedItem == null && cmbMovies.SelectedItem != null)
			{
				lstLastSales.Items.Add($"{i}. Satış = Film : " + cmbMovies.SelectedItem + " / Ürün : YOK");
				TotalPrice += _movieRepo.Find(Convert.ToInt32(cmbMovies.SelectedValue)).TicketPrice;
				lblTotalPrice.Text = TotalPrice.ToString("C2");
			}
			else if (cmbProducts.SelectedItem != null && cmbMovies.SelectedItem == null)
			{
				lstLastSales.Items.Add($"{i}. Satış = Film : YOK" + " / Ürün : " + cmbProducts.SelectedItem);
				TotalPrice += _productRepo.Find(Convert.ToInt32(cmbProducts.SelectedValue)).Price;
				lblTotalPrice.Text = TotalPrice.ToString("C2");
			}
			else
			{
				MessageBox.Show("En az bir ürün ya da film seçmek zorundasınız.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCancelMovie_Click(object sender, EventArgs e)
		{
			cmbMovies.SelectedItem = null;
		}

		private void btnCancelProduct_Click(object sender, EventArgs e)
		{
			cmbProducts.SelectedItem = null;
		}

		private void btnMain_Click(object sender, EventArgs e)
		{
			frmMain main = new frmMain();
			main.Show();
			this.Hide();
		}
	}
}
