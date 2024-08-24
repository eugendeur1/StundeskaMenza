using DataAccessToProjectMenza.Data;
using ModelMenza.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RWA_Project
{
    public partial class Form4 : Form
    {
        private int _loggedInStudentId;

        public Form4(int loggedInStudentId)
        {
            InitializeComponent();
            _loggedInStudentId = loggedInStudentId;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadObroke();
        }

        public List<Obrok> StudenskiObrok()
        {
            using (var context = new MenzaDbContext())
            {
                return context.Obroci.ToList();
            }
        }

        private void LoadObroke()
        {
            var obrok = StudenskiObrok();
            var obroci = obrok.Select(p => new
            {
                p.Obrok_Id,
                p.Obrok_Name,
                p.Price
            }).ToList();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = obroci;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int obrokId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Obrok_Id"].Value);
                DateTime orderDate = DateTime.Now;

                AddOrder(_loggedInStudentId, obrokId, orderDate);

                MessageBox.Show("Primili smo vašu narudžbu. Hvala!");

                LoadObroke(); // Osvežavanje DataGridView-a nakon dodavanja narudžbe
            }
            else
            {
                MessageBox.Show("Molimo odaberite obrok koji želite naručiti.");
            }
        }

        private void AddOrder(int studentId, int obrokId, DateTime orderDate)
        {
            using (var context = new MenzaDbContext())
            {
                var newOrder = new Order
                {
                    StudentId = studentId,
                    OrderDate = orderDate,
                    ObrokId = obrokId
                };

                context.Order.Add(newOrder);
                context.SaveChanges();
            }
        }
    }
}
