using DataAccessToProjectMenza.Data;
using ModelMenza.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RWA_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;

            using (var context = new MenzaDbContext())
            {
                Person person = context.Persons
                    .FirstOrDefault(p => p.Name == username && p.Title == password);

                if (person != null)
                {
                    int loggedInStudentId = person.Id; 
                    Form4 newForm = new Form4(loggedInStudentId); 
                    Hide();
                    newForm.ShowDialog();
                    Show(); 
                }
                else
                {
                    // Prikazati poruku o pogrešnom unosu
                    MessageBox.Show("Pogrešno korisničko ime ili lozinka!");
                }
            }
        }
    }
}
