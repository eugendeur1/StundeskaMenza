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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            LoadObroke();
        }
        public List<Order> ListOfOrders()
        {
            using ( var context=new MenzaDbContext())
            {
                var order=context.Order.ToList();
                return order;
            }
        }
        private void LoadObroke()
        {
            var order = ListOfOrders();
            var orders = order.Select(p => new
            {
                p.Order_Id,
                p.StudentId,
                p.OrderDate,
                p.ObrokId,
            }).ToList();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = orders;
        }
       
    }
}
