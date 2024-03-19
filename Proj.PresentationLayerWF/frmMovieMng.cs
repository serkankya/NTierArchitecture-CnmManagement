using Proj.BusinessLogicLayer.DesignPatterns.GenericRepository.ConcreteRep;
using Proj.EntityLayer.Models;
using Proj.PresentationLayerWF.ViewModels;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proj.PresentationLayerWF
{
	public partial class frmMovieMng : Form
	{
		CategoryRepository _categoryRepo;
		MovieRepository _movieRepo;
		public frmMovieMng()
		{
			InitializeComponent();
			_categoryRepo = new CategoryRepository();
			_movieRepo = new MovieRepository();
		}

		void ListCategories()
		{
			cmbCategories.DataSource = _categoryRepo.Select(x => new CategoryVM
			{
				ID = x.ID,
				CategoryName = x.Name,
				CategoryDescription = x.Description,
				Movies = x.Movies
			}).ToList();

			cmbCategories.DisplayMember = "CategoryName";
			cmbCategories.ValueMember = "ID";
		}

		void ListMovies()
		{
			lstMovies.DataSource = _movieRepo.Select(x => new MovieVM
			{
				ID = x.ID,
				Name = x.Name,
				TicketPrice = x.TicketPrice,
				Description = x.Description,
				Director = x.Director,
				ReleaseDate = x.ReleaseDate,
				CategoryName = x.Category == null ? "Kategori Bulunamadı" : x.Category.Name,
				CategoryID = x.CategoryID
			}).ToList();
		}

		private void frmMovieMng_Load(object sender, EventArgs e)
		{
			ListCategories();
			ListMovies();

			this.MaximumSize = new Size(816, 464);
			this.MinimumSize = new Size(816, 464);
		}

		private void btnAddMovie_Click(object sender, EventArgs e)
		{
			try
			{
				Movie _m = new Movie();
				_m.Name = txtMovieName.Text;
				_m.Description = txtDescription.Text;
				_m.TicketPrice = numPrice.Value;
				_m.ReleaseDate = dateReleaseDate.Value;
				_m.Director = txtDirector.Text;
				if (cmbCategories.SelectedIndex > -1)
				{
					_m.CategoryID = Convert.ToInt32(cmbCategories.SelectedValue);
				}

				_movieRepo.Add(_m);
				ListMovies();
				MessageBox.Show($"{txtMovieName.Text} adlı kategori başarı ile eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu. Hata : " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btnDeleteMovie_Click(object sender, EventArgs e)
		{
			if (_selectedItem != null)
			{
				Movie deletedItem = _movieRepo.Find(_selectedItem.ID);
				_movieRepo.Delete(deletedItem);
				ListMovies();
				MessageBox.Show($"{_selectedItem.Name} adlı kategori başarı ile silindi.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				_selectedItem = null;
				txtMovieName.Text = txtDescription.Text = txtDirector.Text = null;
				numPrice.Value = 0;
				dateReleaseDate.Value = DateTime.Now;
				cmbCategories.SelectedIndex = -1;
			}
			else
			{
				MessageBox.Show("Lütfen bir film seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnUpdateMovie_Click(object sender, EventArgs e)
		{
			if (_selectedItem != null && _selectedItem.ID != 0)
			{
				Movie updatedItem = _movieRepo.Find(_selectedItem.ID);
				updatedItem.Name = txtMovieName.Text;
				updatedItem.Description = txtDescription.Text;
				updatedItem.Director = txtDirector.Text;
				updatedItem.ReleaseDate = dateReleaseDate.Value;
				updatedItem.TicketPrice = numPrice.Value;
				if (cmbCategories.SelectedIndex > -1)
				{
					updatedItem.CategoryID = Convert.ToInt32(cmbCategories.SelectedValue);
				}
				_movieRepo.Update(updatedItem);
				ListMovies();
				MessageBox.Show($"{_selectedItem.Name} adlı kategori başarı ile güncellendi.", "Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				_selectedItem = null;
				txtMovieName.Text = txtDescription.Text = txtDirector.Text = null;
				numPrice.Value = 0;
				dateReleaseDate.Value = DateTime.Now;
				cmbCategories.SelectedIndex = -1;
			}
			else
			{
				MessageBox.Show("Lütfen bir film seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		MovieVM _selectedItem;
		private void lstMovies_Click(object sender, EventArgs e)
		{
			if (lstMovies.SelectedIndex > -1)
			{
				_selectedItem = lstMovies.SelectedItem as MovieVM;
				txtMovieName.Text = _selectedItem.Name;
				txtDirector.Text = _selectedItem.Director;
				txtDescription.Text = _selectedItem.Description;
				numPrice.Value = _selectedItem.TicketPrice;
				dateReleaseDate.Value = _selectedItem.ReleaseDate;
				cmbCategories.SelectedValue = _selectedItem.CategoryID;
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
