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
            //MessageBox.Show(selectedbook.ID.ToString());

            OpenForm(new frmEditBooks());
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
