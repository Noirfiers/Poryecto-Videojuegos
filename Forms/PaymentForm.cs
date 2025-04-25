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
    public partial class PaymentForm : Form
    {
        private List<Payment> payments = new List<Payment>();

        public PaymentForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                payments = Payment.LoadFromFile("payments.json");
                MessageBox.Show("Pagos cargados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pagos: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Payment.SaveToFile(payments, "payments.json");
                MessageBox.Show("Pagos guardados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar pagos: " + ex.Message);
            }
        }
    }
}
