namespace prototipo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAreaExe_Click(object sender, EventArgs e)
        {
            areaExe1.Show();
            areaExe1.BringToFront();
        }
    }
}