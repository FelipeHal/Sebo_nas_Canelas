using SeboNasCanelas.Win.AppObjects;
using SeboNasCanelas.Win.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeboNasCanelas.Win.Forms.Games
{
    public partial class frmEditGames : Form
    {
        private readonly GamesRepository gamesRepository;
        private Game game;
        public frmEditGames()
        {
            InitializeComponent();
        }

        public void newGame()
        {
            game = new Game();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Please check if all the informations were provided!");
                return;
            }

            game.Title = txtTitle.Text;
            game.Price = Convert.ToDecimal(txtPrice.Text);

            gamesRepository.Insert(game);

            MessageBox.Show("Book successfully inserted!");
            txtTitle.Text = "";
            txtPrice.Text = "";
        }
    }
}
