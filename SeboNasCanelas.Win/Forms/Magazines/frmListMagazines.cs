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

namespace SeboNasCanelas.Win.Forms.Magazines
{
    public partial class frmListMagazines : Form
    {
        private readonly MagazinesRepository magazinesRepository;

        public frmListMagazines()
        {
            InitializeComponent();
            magazinesRepository = new MagazinesRepository();
        }

        private void frmListMagazines_Load(object sender, EventArgs e)
        {
            dgvData.AutoGenerateColumns = false;
            dgvData.DataSource = magazinesRepository.List();
        }
    }
}
