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
    public partial class GameForm : Form
    {
        private List<Game> games = new List<Game>();

        public GameForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                games = Game.LoadFromFile("games.json");
                MessageBox.Show("Juegos cargados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar juegos: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Game.SaveToFile(games, "games.json");
                MessageBox.Show("Juegos guardados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar juegos: " + ex.Message);
            }
        }
    }
}
