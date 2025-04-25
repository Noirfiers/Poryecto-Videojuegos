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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnUserForm_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnCustomerForm_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }

        private void btnInventoryForm_Click(object sender, EventArgs e)
        {
            InventroyForm inventoryForm = new InventoryForm();
            inventoryForm.Show();
        }

        private void btnGameForm_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.Show();
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
        }

        private void btnReviewForm_Click(object sender, EventArgs e)
        {
            ReviewForm reviewForm = new ReviewForm();
            reviewForm.Show();
        }

        private void btnCartItemForm_Click(object sender, EventArgs e)
        {
            CartItemForm cartItemForm = new CartItemForm();
            cartItemForm.Show();
        }

        private void btnOrderForm_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
        }

        private void btnPaymentForm_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.Show();
        }

        private void btnTransactionForm_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.Show();
        }

        private void btnInvoiceForm_Click(object sender, EventArgs e)
        {
            InvoiceForm invoiceForm = new InvoiceForm();
            invoiceForm.Show();
        }
    }
}
