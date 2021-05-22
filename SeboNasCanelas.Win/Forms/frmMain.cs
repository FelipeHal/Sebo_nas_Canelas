using SeboNasCanelas.Win.Forms.Books;
using SeboNasCanelas.Win.Forms.Games;
using SeboNasCanelas.Win.Forms.Magazines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeboNasCanelas.Win.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuBooks_Click(object sender, EventArgs e)
        {
            frmListBooks books = new frmListBooks();

            foreach (Form form in Application.OpenForms)
            {
                if (form is frmListBooks)
                {
                    return;
                }
            }

            books.MdiParent = this;
            books.Show();
        }

        private void mnuGames_Click(object sender, EventArgs e)
        {
            frmListGames games = new frmListGames();
            games.MdiParent = this;
            games.Show();
        }

        private void mnuMagazines_Click(object sender, EventArgs e)
        {
            frmListMagazines magazines = new frmListMagazines();
            magazines.MdiParent = this;
            magazines.Show();
        }
    }
}
