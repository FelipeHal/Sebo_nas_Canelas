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

        private void OpenForm (Form newForm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == newForm.GetType())
                {
                    return;
                }
            }
            //newForm.MdiParent = this;
            newForm.Show();
        }
        public frmListGames()
        {
            InitializeComponent();

            gamesRepository = new GamesRepository(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmList_Load(object sender, EventArgs e)
        {
            dgvData.AutoGenerateColumns = false;
            dgvData.DataSource = gamesRepository.List();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Game selectedgame = (Game)dgvData.SelectedRows[0].DataBoundItem;            

            OpenForm(new frmEditGames());
        }
    }
}
