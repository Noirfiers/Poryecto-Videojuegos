using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using VideoGameStoreBackend;

namespace Proyecto_blal.forms
{
    public partial class InventoryForm : Form
    {
        private const string FilePath = "game.json";

        public InventoryForm()
        {
            InitializeComponent();
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!Guid.TryParse(txtGameId.Text, out Guid gameId) ||
                !int.TryParse(txtQuantity.Text, out int quantity) ||
                !decimal.TryParse(txtCost.Text, out decimal cost))
            {
                MessageBox.Show("Verifique los datos ingresados.");
                return;
            }

            var game = new Game
            {
                GameId = gameId,
                Title = txtTitle.Text,
                Genre = txtGenre.Text,
                Developer = txtDeveloper.Text,
                Publisher = txtPublisher.Text,
                ReleaseDate = dtpReleaseDate.Value,
                Price = cost,
                Platform = txtPlatform.Text,
                Quantity = quantity, // nuevo campo
                IsMultiplayer = chkMultiplayer.Checked
            };

            List<Game> games = new List<Game>();
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                games = JsonConvert.DeserializeObject<List<Game>>(json) ?? new List<Game>();
            }

            games.Add(game);
            File.WriteAllText(FilePath, JsonConvert.SerializeObject(games, Formatting.Indented));
            MessageBox.Show("Juego guardado exitosamente.");
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (!File.Exists(FilePath)) return;

            string json = File.ReadAllText(FilePath);
            var games = JsonConvert.DeserializeObject<List<Game>>(json);

            if (games != null && games.Count > 0)
            {
                var g = games[0];
                txtGameId.Text = g.GameId.ToString();
                txtTitle.Text = g.Title;
                txtGenre.Text = g.Genre;
                txtDeveloper.Text = g.Developer;
                txtPublisher.Text = g.Publisher;
                dtpReleaseDate.Value = g.ReleaseDate;
                txtCost.Text = g.Price.ToString();
                txtPlatform.Text = g.Platform;
                txtQuantity.Text = g.Quantity.ToString(); // nuevo campo
                chkMultiplayer.Checked = g.IsMultiplayer;
            }
        }
    }

}

