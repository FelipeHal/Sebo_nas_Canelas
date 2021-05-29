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


        private void frmList_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Book selectedbook = (Book)dgvData.SelectedRows[0].DataBoundItem;

            frmEditBooks editBooks = new frmEditBooks();
            editBooks.editBook(selectedbook.ID);
            OpenEditForm(editBooks);
        }

        public void LoadBooks()
        {
            dgvData.DataSource = null;

            dgvData.AutoGenerateColumns = false;
            dgvData.DataSource = booksRepository.List();
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
