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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public List<Obrok> StudenskiObrok()
        {
            using (var context = new MenzaDbContext())
            {
                var obrok = context.Obroci.ToList();
                return obrok;
            }
        }
        private void LoadObroke()
        {
            var obrok = StudenskiObrok();
            var obroci = obrok.Select(p => new
            {
                p.Obrok_Id,
                p.Obrok_Name,
                p.Price,
            }).ToList();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = obroci;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            LoadObroke();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Pronađi ID selektovanog obroka
                int selectedObrokId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Obrok_Id"].Value);

                // Potvrda brisanja
                var confirmResult = MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj obrok?", "Potvrda brisanja", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // Brisanje obroka iz baze podataka
                    using (var context = new MenzaDbContext())
                    {
                        var obrokToDelete = context.Obroci.FirstOrDefault(p => p.Obrok_Id == selectedObrokId);
                        if (obrokToDelete != null)
                        {
                            context.Obroci.Remove(obrokToDelete);
                            context.SaveChanges();

                            // Osvežavanje DataGridView-a
                            LoadObroke();
                            MessageBox.Show("Obrok je uspešno obrisan.");
                        }
                        else
                        {
                            MessageBox.Show("Obrok nije pronađen.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Molimo odaberite obrok kojeg želite da obrišete.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                 !int.TryParse(txtPrice.Text, out int price) || price < 0)
            {
                MessageBox.Show("Molimo popunite sva polja ispravno. Cena mora biti pozitivan broj.");
                return;
            }

            var newObrok = new Obrok
            {
                Obrok_Name = txtName.Text,
                Price = price
            };

            using (var context = new MenzaDbContext())
            {
                context.Obroci.Add(newObrok);
                context.SaveChanges();

                LoadObroke();

                MessageBox.Show("Obrok je uspešno dodat!");
                txtName.Clear();
                txtPrice.Clear();


            }
        }
    }
}
