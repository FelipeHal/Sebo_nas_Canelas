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

namespace SeboNasCanelas.Win.Forms.Books
{
    public partial class frmListBooks : Form
    {

        private readonly BooksRepository booksRepository;

        public frmListBooks()
        {
            InitializeComponent();

            booksRepository = new BooksRepository();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmList_Load(object sender, EventArgs e)
        {
            dgvData.AutoGenerateColumns = false;
            dgvData.DataSource = booksRepository.List();
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Book selectedbook = (Book)dgvData.SelectedRows[0].DataBoundItem;
            MessageBox.Show(selectedbook.ID.ToString());
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
