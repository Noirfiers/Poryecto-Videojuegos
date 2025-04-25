using System.Windows.Forms;

namespace Proyecto_blal.forms
{
    partial class CartItemForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnLoad;
        private Button btnSave;
        private TextBox txtCartItemID;
        private TextBox txtGameID;
        private TextBox txtQuantity;
        private TextBox txtPrice;

        private void InitializeComponent()
        {
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCartItemID = new System.Windows.Forms.TextBox();
            this.txtGameID = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 150);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Cargar";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 180);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCartItemID
            // 
            this.txtCartItemID.Location = new System.Drawing.Point(12, 12);
            this.txtCartItemID.Name = "txtCartItemID";
            this.txtCartItemID.Size = new System.Drawing.Size(100, 22);
            this.txtCartItemID.TabIndex = 2;
            this.txtCartItemID.TextChanged += new System.EventHandler(this.txtCartItemID_TextChanged);
            // 
            // txtGameID
            // 
            this.txtGameID.Location = new System.Drawing.Point(12, 38);
            this.txtGameID.Name = "txtGameID";
            this.txtGameID.Size = new System.Drawing.Size(100, 22);
            this.txtGameID.TabIndex = 3;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(12, 64);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(12, 90);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 5;
            // 
            // CartItemForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtGameID);
            this.Controls.Add(this.txtCartItemID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Name = "CartItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}