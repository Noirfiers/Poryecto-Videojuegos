using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_blal.forms
{
    public partial class InvoiceForm : Form
    {
        private List<Invoice> invoices = new List<Invoice>();

        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                invoices = Invoice.LoadFromFile("invoices.json");
                MessageBox.Show("Facturas cargadas correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar facturas: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Invoice.SaveToFile(invoices, "invoices.json");
                MessageBox.Show("Facturas guardadas correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar facturas: " + ex.Message);
            }
        }
    }
}
