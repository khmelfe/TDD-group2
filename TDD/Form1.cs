namespace TDD
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
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
    }
}
//trying to commit to master
//Changing main branch
