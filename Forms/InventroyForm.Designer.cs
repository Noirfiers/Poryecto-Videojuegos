using System.Windows.Forms;
using System;

namespace Proyecto_blal.forms
{
    partial class InventoryForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtGameId, txtTitle, txtGenre, txtDeveloper, txtPublisher, txtPlatform, txtCost, txtQuantity;
        private DateTimePicker dtpReleaseDate;
        private CheckBox chkMultiplayer;
        private Button btnSave, btnLoad;

        private void InitializeComponent()
        {
            this.txtGameId = new TextBox();
            this.txtTitle = new TextBox();
            this.txtGenre = new TextBox();
            this.txtDeveloper = new TextBox();
            this.txtPublisher = new TextBox();
            this.txtPlatform = new TextBox();
            this.txtCost = new TextBox();
            this.txtQuantity = new TextBox(); // agregado
            this.dtpReleaseDate = new DateTimePicker();
            this.chkMultiplayer = new CheckBox();
            this.btnSave = new Button();
            this.btnLoad = new Button();

            this.SuspendLayout();

            txtGameId.Location = new System.Drawing.Point(20, 20);
            txtGameId.Size = new System.Drawing.Size(200, 20);
            txtTitle.Location = new System.Drawing.Point(20, 50);
            txtTitle.Size = new System.Drawing.Size(200, 20);
            txtGenre.Location = new System.Drawing.Point(20, 80);
            txtGenre.Size = new System.Drawing.Size(200, 20);
            txtDeveloper.Location = new System.Drawing.Point(20, 110);
            txtDeveloper.Size = new System.Drawing.Size(200, 20);
            txtPublisher.Location = new System.Drawing.Point(20, 140);
            txtPublisher.Size = new System.Drawing.Size(200, 20);
            dtpReleaseDate.Location = new System.Drawing.Point(20, 170);
            dtpReleaseDate.Size = new System.Drawing.Size(200, 20);
            txtPlatform.Location = new System.Drawing.Point(20, 200);
            txtPlatform.Size = new System.Drawing.Size(200, 20);
            txtCost.Location = new System.Drawing.Point(20, 230);
            txtCost.Size = new System.Drawing.Size(200, 20);
            txtQuantity.Location = new System.Drawing.Point(20, 260); // nuevo campo
            txtQuantity.Size = new System.Drawing.Size(200, 20);
            chkMultiplayer.Text = "Multiplayer";
            chkMultiplayer.Location = new System.Drawing.Point(20, 290);

            btnSave.Text = "Guardar";
            btnSave.Location = new System.Drawing.Point(20, 320);
            btnSave.Click += new EventHandler(BtnSave_Click);

            btnLoad.Text = "Cargar";
            btnLoad.Location = new System.Drawing.Point(120, 320);
            btnLoad.Click += new EventHandler(BtnLoad_Click);

            this.Controls.AddRange(new Control[] {
            txtGameId, txtTitle, txtGenre, txtDeveloper, txtPublisher, dtpReleaseDate,
            txtPlatform, txtCost, txtQuantity, chkMultiplayer, btnSave, btnLoad
        });

            this.Text = "Gestión de Juegos";
            this.ClientSize = new System.Drawing.Size(300, 370);
            this.ResumeLayout(false);
        }
    }

}