using System.Windows.Forms;
using System;

namespace Proyecto_blal.forms
{
    partial class CustomerForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtName, txtEmail, txtPhone, txtAddress, txtGender, txtCountry;
        private DateTimePicker dtpBirthDate;
        private CheckBox chkSubscribed;
        private Button btnSave, btnLoad;

        private void InitializeComponent()
        {
            this.txtName = new TextBox();
            this.txtEmail = new TextBox();
            this.txtPhone = new TextBox();
            this.txtAddress = new TextBox();
            this.txtGender = new TextBox();
            this.txtCountry = new TextBox();
            this.dtpBirthDate = new DateTimePicker();
            this.chkSubscribed = new CheckBox();
            this.btnSave = new Button();
            this.btnLoad = new Button();

            this.SuspendLayout();

            txtName.Location = new System.Drawing.Point(20, 20);
            txtName.Size = new System.Drawing.Size(200, 20);
            txtEmail.Location = new System.Drawing.Point(20, 50);
            txtEmail.Size = new System.Drawing.Size(200, 20);
            txtPhone.Location = new System.Drawing.Point(20, 80);
            txtPhone.Size = new System.Drawing.Size(200, 20);
            txtAddress.Location = new System.Drawing.Point(20, 110);
            txtAddress.Size = new System.Drawing.Size(200, 20);
            dtpBirthDate.Location = new System.Drawing.Point(20, 140);
            dtpBirthDate.Size = new System.Drawing.Size(200, 20);
            txtGender.Location = new System.Drawing.Point(20, 170);
            txtGender.Size = new System.Drawing.Size(200, 20);
            txtCountry.Location = new System.Drawing.Point(20, 200);
            txtCountry.Size = new System.Drawing.Size(200, 20);
            chkSubscribed.Text = "Subscribed";
            chkSubscribed.Location = new System.Drawing.Point(20, 230);
            btnSave.Text = "Save";
            btnSave.Location = new System.Drawing.Point(20, 260);
            btnSave.Click += new EventHandler(btnSave_Click);
            btnLoad.Text = "Load";
            btnLoad.Location = new System.Drawing.Point(100, 260);
            btnLoad.Click += new EventHandler(btnLoad_Click);

            this.Controls.AddRange(new Control[] {
            txtName, txtEmail, txtPhone, txtAddress, dtpBirthDate,
            txtGender, txtCountry, chkSubscribed, btnSave, btnLoad
        });

            this.Text = "Customer Form";
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);
        }
    }


}