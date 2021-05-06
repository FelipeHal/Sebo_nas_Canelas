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
    }
}
