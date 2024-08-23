namespace RWA_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frmStudents = new Form2();
            frmStudents.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frmStudents = new Form3();
            frmStudents.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
