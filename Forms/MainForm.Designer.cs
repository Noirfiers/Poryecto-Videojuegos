using System.Windows.Forms;

namespace Proyecto_blal.forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnUserForm;
        private Button btnCustomerForm;
        private Button btnInventoryForm;
        private Button btnGameForm;
        private Button btnCategoryForm;
        private Button btnReviewForm;
        private Button btnCartItemForm;
        private Button btnOrderForm;
        private Button btnPaymentForm;
        private Button btnTransactionForm;
        private Button btnInvoiceForm;

        private void InitializeComponent()
        {
            this.btnUserForm = new System.Windows.Forms.Button();
            this.btnCustomerForm = new System.Windows.Forms.Button();
            this.btnInventoryForm = new System.Windows.Forms.Button();
            this.btnGameForm = new System.Windows.Forms.Button();
            this.btnCategoryForm = new System.Windows.Forms.Button();
            this.btnReviewForm = new System.Windows.Forms.Button();
            this.btnCartItemForm = new System.Windows.Forms.Button();
            this.btnOrderForm = new System.Windows.Forms.Button();
            this.btnPaymentForm = new System.Windows.Forms.Button();
            this.btnTransactionForm = new System.Windows.Forms.Button();
            this.btnInvoiceForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUserForm
            // 
            this.btnUserForm.Location = new System.Drawing.Point(12, 12);
            this.btnUserForm.Name = "btnUserForm";
            this.btnUserForm.Size = new System.Drawing.Size(100, 23);
            this.btnUserForm.TabIndex = 0;
            this.btnUserForm.Text = "User Form";
            this.btnUserForm.UseVisualStyleBackColor = true;
            this.btnUserForm.Click += new System.EventHandler(this.btnUserForm_Click);
            // 
            // btnCustomerForm
            // 
            this.btnCustomerForm.Location = new System.Drawing.Point(12, 41);
            this.btnCustomerForm.Name = "btnCustomerForm";
            this.btnCustomerForm.Size = new System.Drawing.Size(100, 23);
            this.btnCustomerForm.TabIndex = 1;
            this.btnCustomerForm.Text = "Customer Form";
            this.btnCustomerForm.UseVisualStyleBackColor = true;
            this.btnCustomerForm.Click += new System.EventHandler(this.btnCustomerForm_Click);
            // 
            // btnInventoryForm
            // 
            this.btnInventoryForm.Location = new System.Drawing.Point(12, 70);
            this.btnInventoryForm.Name = "btnInventoryForm";
            this.btnInventoryForm.Size = new System.Drawing.Size(100, 23);
            this.btnInventoryForm.TabIndex = 2;
            this.btnInventoryForm.Text = "Inventory Form";
            this.btnInventoryForm.UseVisualStyleBackColor = true;
            this.btnInventoryForm.Click += new System.EventHandler(this.btnInventoryForm_Click);
            // 
            // btnGameForm
            // 
            this.btnGameForm.Location = new System.Drawing.Point(12, 99);
            this.btnGameForm.Name = "btnGameForm";
            this.btnGameForm.Size = new System.Drawing.Size(100, 23);
            this.btnGameForm.TabIndex = 3;
            this.btnGameForm.Text = "Game Form";
            this.btnGameForm.UseVisualStyleBackColor = true;
            this.btnGameForm.Click += new System.EventHandler(this.btnGameForm_Click);
            // 
            // btnCategoryForm
            // 
            this.btnCategoryForm.Location = new System.Drawing.Point(12, 128);
            this.btnCategoryForm.Name = "btnCategoryForm";
            this.btnCategoryForm.Size = new System.Drawing.Size(100, 23);
            this.btnCategoryForm.TabIndex = 4;
            this.btnCategoryForm.Text = "Category Form";
            this.btnCategoryForm.UseVisualStyleBackColor = true;
            this.btnCategoryForm.Click += new System.EventHandler(this.btnCategoryForm_Click);
            // 
            // btnReviewForm
            // 
            this.btnReviewForm.Location = new System.Drawing.Point(12, 157);
            this.btnReviewForm.Name = "btnReviewForm";
            this.btnReviewForm.Size = new System.Drawing.Size(100, 23);
            this.btnReviewForm.TabIndex = 5;
            this.btnReviewForm.Text = "Review Form";
            this.btnReviewForm.UseVisualStyleBackColor = true;
            this.btnReviewForm.Click += new System.EventHandler(this.btnReviewForm_Click);
            // 
            // btnCartItemForm
            // 
            this.btnCartItemForm.Location = new System.Drawing.Point(12, 186);
            this.btnCartItemForm.Name = "btnCartItemForm";
            this.btnCartItemForm.Size = new System.Drawing.Size(100, 23);
            this.btnCartItemForm.TabIndex = 6;
            this.btnCartItemForm.Text = "Cart Item Form";
            this.btnCartItemForm.UseVisualStyleBackColor = true;
            this.btnCartItemForm.Click += new System.EventHandler(this.btnCartItemForm_Click);
            // 
            // btnOrderForm
            // 
            this.btnOrderForm.Location = new System.Drawing.Point(12, 215);
            this.btnOrderForm.Name = "btnOrderForm";
            this.btnOrderForm.Size = new System.Drawing.Size(100, 23);
            this.btnOrderForm.TabIndex = 7;
            this.btnOrderForm.Text = "Order Form";
            this.btnOrderForm.UseVisualStyleBackColor = true;
            this.btnOrderForm.Click += new System.EventHandler(this.btnOrderForm_Click);
            // 
            // btnPaymentForm
            // 
            this.btnPaymentForm.Location = new System.Drawing.Point(12, 244);
            this.btnPaymentForm.Name = "btnPaymentForm";
            this.btnPaymentForm.Size = new System.Drawing.Size(100, 23);
            this.btnPaymentForm.TabIndex = 8;
            this.btnPaymentForm.Text = "Payment Form";
            this.btnPaymentForm.UseVisualStyleBackColor = true;
            this.btnPaymentForm.Click += new System.EventHandler(this.btnPaymentForm_Click);
            // 
            // btnTransactionForm
            // 
            this.btnTransactionForm.Location = new System.Drawing.Point(12, 273);
            this.btnTransactionForm.Name = "btnTransactionForm";
            this.btnTransactionForm.Size = new System.Drawing.Size(100, 23);
            this.btnTransactionForm.TabIndex = 9;
            this.btnTransactionForm.Text = "Transaction Form";
            this.btnTransactionForm.UseVisualStyleBackColor = true;
            this.btnTransactionForm.Click += new System.EventHandler(this.btnTransactionForm_Click);
            // 
            // btnInvoiceForm
            // 
            this.btnInvoiceForm.Location = new System.Drawing.Point(12, 302);
            this.btnInvoiceForm.Name = "btnInvoiceForm";
            this.btnInvoiceForm.Size = new System.Drawing.Size(100, 23);
            this.btnInvoiceForm.TabIndex = 10;
            this.btnInvoiceForm.Text = "Invoice Form";
            this.btnInvoiceForm.UseVisualStyleBackColor = true;
            this.btnInvoiceForm.Click += new System.EventHandler(this.btnInvoiceForm_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.btnInvoiceForm);
            this.Controls.Add(this.btnTransactionForm);
            this.Controls.Add(this.btnPaymentForm);
            this.Controls.Add(this.btnOrderForm);
            this.Controls.Add(this.btnCartItemForm);
            this.Controls.Add(this.btnReviewForm);
            this.Controls.Add(this.btnCategoryForm);
            this.Controls.Add(this.btnGameForm);
            this.Controls.Add(this.btnInventoryForm);
            this.Controls.Add(this.btnCustomerForm);
            this.Controls.Add(this.btnUserForm);
            this.Name = "MainForm";
            this.ResumeLayout(false);
        }
    }
}