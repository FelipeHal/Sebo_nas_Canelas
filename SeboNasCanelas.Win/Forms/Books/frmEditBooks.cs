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
    public partial class frmEditBooks : Form
    {
        private readonly BooksRepository booksRepository;
        private Book book;

        public frmEditBooks()
        {
            InitializeComponent();

            booksRepository = new BooksRepository();
        }

        public void newBook()
        {
            book = new Book();
        }

        public void editBook(int id)
        {
            book = booksRepository.Find(id);

            //TODO. - inverter:
            //book.Category = txtCategory.Text;
            //book.Title = txtTitle.Text;
            //book.Price = Convert.ToDecimal(txtPrice.Text);
        }


        private void btnSaveData_Click(object sender, EventArgs e)
        {
            if (true)
            {
                return;
            }

            book.Category = txtCategory.Text;
            book.Title = txtTitle.Text;
            book.Price = Convert.ToDecimal(txtPrice.Text);

            booksRepository.Insert(book);

            MessageBox.Show("Book successfully inserted!");
            txtCategory.Text = "";
            txtTitle.Text = "";
            txtPrice.Text = "";
        }

        private void frmEditBooks_Load(object sender, EventArgs e)
        {

        }
    }
}
