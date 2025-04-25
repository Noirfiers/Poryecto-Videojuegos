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
    public partial class CategoryForm : Form
    {
        private List<Category> categories = new List<Category>();

        public CategoryForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                categories = Category.LoadFromFile("categories.json");
                MessageBox.Show("Categorías cargadas correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Category.SaveToFile(categories, "categories.json");
                MessageBox.Show("Categorías guardadas correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar categorías: " + ex.Message);
            }
        }
    }
}
