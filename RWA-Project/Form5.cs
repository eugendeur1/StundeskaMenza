using DataAccessToProjectMenza.Data;
using ModelMenza.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RWA_Project
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.Load += Form5_Load;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadStudents();
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

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = studentView;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 frmStudents = new Form6();
            frmStudents.ShowDialog();
        }
    }
}
