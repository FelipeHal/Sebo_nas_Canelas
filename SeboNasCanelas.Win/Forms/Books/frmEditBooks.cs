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
            if (book != null)
            {
                txtCategory.Text = book.Category;
                txtTitle.Text = book.Title;
                txtPrice.Text = Convert.ToString(book.Price);
            }

            //TODO. - inverter:
            //book.Category = txtCategory.Text;
            //book.Title = txtTitle.Text;
            //book.Price = Convert.ToDecimal(txtPrice.Text);
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Please check if all the informations were provided!");
                return;               
            }
            
            else if (String.IsNullOrEmpty(txtCategory.Text))
            {
                MessageBox.Show("Please check if all the informations were provided!");
                return;
            }
            else if (String.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show("Please check if all the informations were provided!");
                return;
            }           

            book.Category = txtCategory.Text;
            book.Title = txtTitle.Text;
            book.Price = Convert.ToDecimal(txtPrice.Text);

            if (book.ID <= 0)
            {
                booksRepository.Insert(book);
            }
            else
            {
                booksRepository.Update(book);
            }

            MessageBox.Show("Book successfully inserted!");
            txtCategory.Text = "";
            txtTitle.Text = "";
            txtPrice.Text = "";

            UpdateBooksList();
        }

        private void UpdateBooksList()
        {
            frmListBooks listBooks = null;

            foreach (Form form in Application.OpenForms)
            {
                if (form is frmListBooks)
                {
                    listBooks = (frmListBooks)form;
                    break;
                }
            }

            if (listBooks != null)
            {
                listBooks.LoadBooks();
            }
        }
    }
}
