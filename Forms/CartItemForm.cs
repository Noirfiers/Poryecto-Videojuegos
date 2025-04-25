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
    public partial class CartItemForm : Form
    {
        private List<CartItem> cartItems = new List<CartItem>();

        public CartItemForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                cartItems = CartItem.LoadFromFile("cartItems.json");
                MessageBox.Show("Artículos del carrito cargados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar artículos del carrito: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CartItem.SaveToFile(cartItems, "cartItems.json");
                MessageBox.Show("Artículos del carrito guardados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar artículos del carrito: " + ex.Message);
            }
        }

        private void txtCartItemID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
