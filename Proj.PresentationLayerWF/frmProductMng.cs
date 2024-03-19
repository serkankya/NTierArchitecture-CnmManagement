using Proj.BusinessLogicLayer.DesignPatterns.GenericRepository.ConcreteRep;
using Proj.EntityLayer.Models;
using Proj.PresentationLayerWF.ViewModels;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Proj.PresentationLayerWF
{
	public partial class frmProductMng : Form
	{
		ProductRepository _productRepo;
		public frmProductMng()
		{
			InitializeComponent();
			_productRepo = new ProductRepository();
		}

		void ListProducts()
		{
			lstProducts.DataSource = _productRepo.Select(x => new ProductVM
			{
				ID = x.ID,
				Name = x.Name,
				Price = x.Price
			}).ToList(); ;
		}

		ProductVM _selectedItem;
		private void lstProducts_Click(object sender, EventArgs e)
		{
			if (lstProducts.SelectedIndex > -1)
			{
				_selectedItem = lstProducts.SelectedItem as ProductVM;
				txtProductName.Text = _selectedItem.Name;
				numProductPrice.Value = _selectedItem.Price;
			}
		}

		private void frmProductMng_Load(object sender, EventArgs e)
		{
			ListProducts();

			this.MaximumSize = new System.Drawing.Size(798, 306);
			this.MinimumSize = new System.Drawing.Size(798, 306);
		}

		private void btnAddProduct_Click(object sender, EventArgs e)
		{
			try
			{
				if (!string.IsNullOrEmpty(txtProductName.Text) && numProductPrice.Value > 0)
				{
					Product _p = new Product();
					_p.Name = txtProductName.Text;
					_p.Price = numProductPrice.Value;
					_productRepo.Add(_p);
					ListProducts();
					MessageBox.Show($"{txtProductName.Text} adlı ürün başarı ile eklendi.", "Ürün Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtProductName.Text = null; numProductPrice.Value = 0;
				}
				else
				{
					MessageBox.Show("Lütfen ilgili yerleri doldurunuz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bir hata oluştu. Hata : " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnDeleteProduct_Click(object sender, EventArgs e)
		{
			if (_selectedItem != null)
			{
				Product toBeDeleted = _productRepo.Find(_selectedItem.ID);
				_productRepo.Delete(toBeDeleted);
				ListProducts();
				MessageBox.Show($"{_selectedItem.Name} adlı ürün başarı ile silindi.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				_selectedItem = null;
				txtProductName.Text = null; numProductPrice.Value = 0;
			}
			else
			{
				MessageBox.Show("Lütfen bir ürün seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnUpdateProduct_Click(object sender, EventArgs e)
		{
			if (_selectedItem != null)
			{
				Product toBeUpdated = _productRepo.Find(_selectedItem.ID);
				toBeUpdated.Name = txtProductName.Text;
				toBeUpdated.Price = numProductPrice.Value;
				_productRepo.Update(toBeUpdated);
				ListProducts();
				MessageBox.Show($"{_selectedItem.Name} adlı ürün başarı ile güncellendi.", "Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				_selectedItem = null;
				txtProductName.Text = null; numProductPrice.Value = 0;
			}
			else
			{
				MessageBox.Show("Lütfen bir ürün seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnMain_Click(object sender, EventArgs e)
		{
			frmMain main = new frmMain();
			main.Show();
			this.Hide();
		}
	}
}
