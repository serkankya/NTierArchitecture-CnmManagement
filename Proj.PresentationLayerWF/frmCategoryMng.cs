using Proj.BusinessLogicLayer.DesignPatterns.GenericRepository.ConcreteRep;
using Proj.EntityLayer.Models;
using Proj.PresentationLayerWF.ViewModels;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Proj.PresentationLayerWF
{
	public partial class frmCategoryMng : Form
	{
		CategoryRepository _categoryRepo;
		public frmCategoryMng()
		{
			InitializeComponent();
			_categoryRepo = new CategoryRepository();
		}

		void ListCategories()
		{
			lstCategories.DataSource = _categoryRepo.Select(x => new CategoryVM
			{
				ID = x.ID,
				CategoryName = x.Name,
				CategoryDescription = x.Description,
				Movies = x.Movies
			}).ToList();
		}

		private void frmCategoryMng_Load(object sender, EventArgs e)
		{
			ListCategories();

			this.MaximumSize = new System.Drawing.Size(816, 345);
			this.MinimumSize = new System.Drawing.Size(816, 345);
		}

		private void btnAddCategory_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtDescription.Text))
			{
				MessageBox.Show("Lütfen ilgili alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Category _c = new Category();
			_c.Name = txtName.Text;
			_c.Description = txtDescription.Text;

			_categoryRepo.Add(_c);
			ListCategories();
			MessageBox.Show($"{txtName.Text} adlı kategori başarı ile eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		CategoryVM _selectedItem;
		private void lstCategories_Click(object sender, EventArgs e)
		{
			if (lstCategories.SelectedIndex > -1)
			{
				_selectedItem = lstCategories.SelectedItem as CategoryVM;
				txtName.Text = _selectedItem.CategoryName;
				txtDescription.Text = _selectedItem.CategoryDescription;
			}
		}

		private void btnDeleteCategory_Click(object sender, EventArgs e)
		{
			if (_selectedItem != null)
			{
				Category deletedItem = _categoryRepo.Find(_selectedItem.ID);
				_categoryRepo.Delete(deletedItem);
				ListCategories();
				MessageBox.Show($"{_selectedItem.CategoryName} adlı kategori başarı ile silindi.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				_selectedItem = null;
				txtName.Text = txtDescription.Text = null;
			}
			else
			{
				MessageBox.Show("Lütfen bir kategori seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnUpdateCategory_Click(object sender, EventArgs e)
		{
			if (_selectedItem != null)
			{
				Category updatedItem = _categoryRepo.Find(_selectedItem.ID);
				updatedItem.Name = txtName.Text;
				updatedItem.Description = txtDescription.Text;
				_categoryRepo.Update(updatedItem);
				ListCategories();
				MessageBox.Show($"{_selectedItem.CategoryName} adlı kategori başarı ile güncellendi.", "Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				_selectedItem = null;
				txtName.Text = txtDescription.Text = null;
			}
			else
			{
				MessageBox.Show("Lütfen bir kategori seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
