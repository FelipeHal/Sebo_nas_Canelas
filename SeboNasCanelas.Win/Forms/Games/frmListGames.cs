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
    public partial class frmListGames : Form
    {

        private readonly GamesRepository gamesRepository;


        public frmListGames()
        {
            InitializeComponent();

            gamesRepository = new GamesRepository(); 
        }


        private void frmList_Load(object sender, EventArgs e)
        {
            LoadGames();
        }
         
        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Game selectedgame = (Game)dgvData.SelectedRows[0].DataBoundItem;

            frmEditGames editGames = new frmEditGames();
            editGames.editGame(selectedgame.ID);
            OpenEditForm(editGames);
        }

        public void LoadGames()
        {
            dgvData.DataSource = null;

            dgvData.AutoGenerateColumns = false;
            dgvData.DataSource = gamesRepository.List();
        }
        private void OpenEditForm(Form openForm)
        {
            frmMain main = null;

            foreach (Form form in Application.OpenForms)
            {
                if (form is frmMain)
                {
                    main = (frmMain)form;
                    break;
                }
            }

            if (main != null)
            {
                main.OpenForm(openForm);
            }

        }
    }
}
