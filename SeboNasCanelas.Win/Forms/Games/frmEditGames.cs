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

            gamesRepository = new GamesRepository();
        }


        public void newGame()
        {
            game = new Game();
        }
        public void editGame(int id)
        {
            game = gamesRepository.Find(id);
            if (game != null)
            {                
                txtTitle.Text = game.Title;
                txtPrice.Text = Convert.ToString(game.Price);
            }
        }
        private void btnSaveData_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Please check if all the informations were provided!");
                return;
            }
            else if (String.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show("Please check if all the informations were provided!");
                return;
            }

            game.Title = txtTitle.Text;
            game.Price = Convert.ToDecimal(txtPrice.Text);

            if (game.ID <= 0)
            {
                gamesRepository.Insert(game);
            }
            else
            {
                gamesRepository.Update(game);
            }            

            MessageBox.Show("Game successfully inserted!");
            txtTitle.Text = "";
            txtPrice.Text = "";

            UpdateGamesList();
        }

        private void UpdateGamesList()
        {
            frmListGames listGames = null;

            foreach (Form form in Application.OpenForms)
            {
                if (form is frmListGames)
                {
                    listGames = (frmListGames)form;
                    break;
                }
            }

            if (listGames != null)
            {
                listGames.LoadGames();
            }
        }
    }
}
