using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoGameStoreBackend;

namespace Proyecto_blal.forms
{
    public partial class ReviewForm : Form
    {
        private List<Review> reviews = new List<Review>();

        public ReviewForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                reviews = Review.LoadFromFile("reviews.json");
                MessageBox.Show("Reseñas cargadas correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar reseñas: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Review.SaveToFile(reviews, "reviews.json");
                MessageBox.Show("Reseñas guardadas correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar reseñas: " + ex.Message);
            }
        }
    }
}
