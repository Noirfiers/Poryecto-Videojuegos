using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using VideoGameStoreBackend;

namespace Proyecto_blal.forms
{
    public partial class InventroyForm : Form
    {
        private List<InventoryItem> inventory = new List<InventoryItem>();

        public InventroyForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                inventory = InventoryItem.LoadFromFile("inventory.json");
                MessageBox.Show("Inventario cargado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar inventario: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                InventoryItem.SaveToFile(inventory, "inventory.json");
                MessageBox.Show("Inventario guardado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar inventario: " + ex.Message);
            }
        }
    }

}

