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
            using (var context = new  MenzaDbContext())
                    {
                        var fakultet = context.Fakultets.ToList();
                        return fakultet;
                    }
        }

    }
}
