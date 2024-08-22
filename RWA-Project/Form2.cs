using DataAccessToProjectMenza.Data;
using ModelMenza.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    Form4 newForm = new Form4();
                    Hide();

                    newForm.ShowDialog();
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
