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
    public partial class frmEditMagazines : Form
    {
        private readonly MagazinesRepository magazinesRepository;
        private Magazine magazine;
        public frmEditMagazines()
        {
            InitializeComponent();

            magazinesRepository = new MagazinesRepository();
        }

        public void newMagazine()
        {
            magazine = new Magazine();
        }
        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Please check if all the informations were provided!");
                return;
            }

            magazine.Title = txtTitle.Text;
            magazine.Price = Convert.ToDecimal(txtPrice.Text);

            magazinesRepository.Insert(magazine);

            MessageBox.Show("Magazine successfully inserted!");
            txtTitle.Text = "";
            txtPrice.Text = "";
        }
    }
}
