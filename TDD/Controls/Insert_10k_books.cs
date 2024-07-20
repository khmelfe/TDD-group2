using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDD.Controls
{

    public partial class Insert_10k_books : UserControl
    {
        Book_list booklist = GlobalBookList.BookList;
        public Insert_10k_books()
        {
            InitializeComponent();
        }

        private void Random_books_Click(object sender, EventArgs e)
        {
            Book[] list_show = booklist.getALL();

            for (int i = 0; i < booklist.getSize(); i++)
            {
                if (list_show[i] != null)
                {
                    //info
                    //MessageBox.Show(list_show[i].ToString(), "Book Details:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                
            }
        }
    }
}
