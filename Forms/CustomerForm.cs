using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using VideoGameStoreBackend;

namespace Proyecto_blal.forms
{
    public partial class CustomerForm : Form
    {
        private const string FilePath = "customers.json";

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                Address = txtAddress.Text,
                BirthDate = dtpBirthDate.Value,
                Gender = txtGender.Text,
                Country = txtCountry.Text,
                IsSubscribed = chkSubscribed.Checked
            };

            if (!customer.IsValid())
            {
                MessageBox.Show("Datos inválidos.");
                return;
            }

            var customers = new List<Customer> { customer };
            Customer.SaveToFile(customers, FilePath);
            MessageBox.Show("Guardado exitosamente.");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var customers = Customer.LoadFromFile(FilePath);
            if (customers.Count > 0)
            {
                var c = customers[0];
                txtName.Text = c.Name;
                txtEmail.Text = c.Email;
                txtPhone.Text = c.Phone;
                txtAddress.Text = c.Address;
                dtpBirthDate.Value = c.BirthDate;
                txtGender.Text = c.Gender;
                txtCountry.Text = c.Country;
                chkSubscribed.Checked = c.IsSubscribed;
            }
        }
    }

}
