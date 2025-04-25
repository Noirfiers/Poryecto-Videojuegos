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
    public partial class OrderForm : Form
    {
        private List<Order> orders = new List<Order>();

        public OrderForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                orders = Order.LoadFromFile("orders.json");
                MessageBox.Show("Órdenes cargadas correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar órdenes: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Order.SaveToFile(orders, "orders.json");
                MessageBox.Show("Órdenes guardadas correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar órdenes: " + ex.Message);
            }
        }
    }
}
