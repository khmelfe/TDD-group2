using System.Windows.Forms;
using TDD.Controls;

namespace TDD
{
    public partial class Library : Form
    {
        Book_list myBookList = GlobalBookList.BookList;
        public Library()
        {

            InitializeComponent();
            insert_10k_books1.Hide();
            insert_onebook1.Hide();
            view_books1.Hide();



        }



        public void Exit_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Critical desicion.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                this.Close();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Books_Click(object sender, EventArgs e)//Insert 10k books button
        {
            //Book_list();
            MessageBox.Show("Hello");
        }
        private void Onebook_Click(object sender, EventArgs e)
        {
            view_books1.Hide();
            insert_10k_books1.Hide();
            insert_onebook1.Show();
            //MessageBox.Show("OneBook");

        }

        private void Insert_onebook_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Open_panel_10k(object sender, EventArgs e)//for button 10k.
        {
            view_books1.Hide();
            insert_onebook1.Hide();
            insert_10k_books1.Show();
            MessageBox.Show("10k books");

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void insert_10k_books1_Load(object sender, EventArgs e)
        {

        }

        private void List_books_Click(object sender, EventArgs e)
        {
            insert_10k_books1.Hide();
            insert_onebook1.Hide();
            view_books1.Show();



        }

        private void view_books1_Load(object sender, EventArgs e)
        {

        }

        private void view_books1_Load_1(object sender, EventArgs e)
        {

        }
        private void Minimize_button_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;

            }
            else
            {
                this.WindowState = FormWindowState.Minimized;

            }
        }
    }
}


//trying to commit to master
//Changing main branch
