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

namespace SeboNasCanelas.Win.Forms.Magazines
{
    public partial class frmListMagazines : Form
    {
        private readonly MagazinesRepository magazinesRepository;

        private void OpenForm (Form newForm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == newForm.GetType())
                {
                    return;
                }
            }

            newForm.Show();
        }
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

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Magazine selectedmagazine = (Magazine)dgvData.SelectedRows[0].DataBoundItem;

            OpenForm(new frmEditMagazines());
        }
    }
}
