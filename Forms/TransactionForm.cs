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
    public partial class TransactionForm : Form
    {
        private List<Transaction> transactions = new List<Transaction>();

        public TransactionForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                transactions = Transaction.LoadFromFile("transactions.json");
                MessageBox.Show("Transacciones cargadas correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar transacciones: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Transaction.SaveToFile(transactions, "transactions.json");
                MessageBox.Show("Transacciones guardadas correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar transacciones: " + ex.Message);
            }
        }
    }
}
