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
        private readonly IMagazinesRepository magazinesRepository;

        
        public frmListMagazines(IMagazinesRepository magazinesRepository)
        {
            InitializeComponent();
            this.magazinesRepository = magazinesRepository;
        }

        private void frmListMagazines_Load(object sender, EventArgs e)
        {
            LoadMagazines();
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Magazine selectedmagazine = (Magazine)dgvData.SelectedRows[0].DataBoundItem;

            frmEditMagazines editMagazines = new frmEditMagazines(magazinesRepository);
            editMagazines.editMagazine(selectedmagazine.ID);
            OpenEditForm(editMagazines);
        }

        public void LoadMagazines()
        {
            dgvData.DataSource = null;

            dgvData.AutoGenerateColumns = false;
            dgvData.DataSource = magazinesRepository.List();
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
