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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.Load += Form6_Load;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LoadCollages();
            LoadStudents();
        }
        private void LoadCollages()
        {
            var fakultet = FakultetList();
            var fakultetView = fakultet.Select(p => new
            {
                p.Fakultet_Id,
                p.Name,
                p.Location
            }).ToList();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = fakultetView;
        }
        public List<Fakultet> FakultetList()
        {
            using (var context = new MenzaDbContext())
            {
                var fakultet = context.Fakultets.ToList();
                return fakultet;
            }
        }
        public static List<Person> ShowStudents()
        {
            using (var context = new MenzaDbContext())
            {
                var students = context.Persons.ToList();
                Console.WriteLine($"Number of students retrieved: {students.Count}"); // Proveri broj studenata u Output konzoli
                return students;
            }
        }
        private void LoadStudents()
        {
            //List<Person> students = ShowStudents();
            //dataGridView1.AutoGenerateColumns = true; // Omogući automatsko generiranje kolona
            //dataGridView1.DataSource = students;

            var students = ShowStudents();
            var studentView = students.Select(p => new
            {
                p.Id,
                p.Name,
                p.Title,
                p.YearOfStudy,
                p.Fakultet_Id
            }).ToList();

            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.DataSource = studentView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtYearOfStudy.Text) ||
                string.IsNullOrWhiteSpace(txtFakultetId.Text))
            {
                MessageBox.Show("Molimo popunite sva polja ispravno.");
                return;
            }

            if (!int.TryParse(txtFakultetId.Text, out int fakultetId))
            {
                MessageBox.Show("Fakultet ID mora biti broj.");
                return;
            }

            var newStudent = new Person
            {
                Name = txtName.Text,
                Title = txtTitle.Text,
                YearOfStudy = txtYearOfStudy.Text,
                Fakultet_Id = fakultetId, 
            };

            using (var context = new MenzaDbContext())
            {
                context.Persons.Add(newStudent);
                context.SaveChanges(); 
            }

            MessageBox.Show("Student je uspešno dodat!");

            txtName.Clear();
            txtTitle.Clear();
            txtYearOfStudy.Clear();
            txtFakultetId.Clear();

            LoadStudents();
        }
    }
}
