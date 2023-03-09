using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group_1_Final
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Flooring", "Concrete","Ready to Mix Concrete", "50 lb bag",null, 10.99);
            dataGridView1.Rows.Add("Flooring", "Rebar", "Steel", "1/2 inch x 10 ft", null, 4.99);
            dataGridView1.Rows.Add("Flooring", "Tile", "Flat Clay Flooring","3 inches by 12 inches", null, 3.99);
            dataGridView1.Rows.Add(null, null, null, null, null, "Total", null);
            dataGridView1.Rows.Add(null, null, null, null, null, null, null);
            dataGridView1.Rows.Add("Walls", "Dry wall", "Walls", "1/2-in x 4-ft x 8-ft", null, 11.99);
            dataGridView1.Rows.Add("Walls", "Interior Paint", "Low Odor Paint Semi Gloss", "1 Quart", null, 14.99);
            dataGridView1.Rows.Add("Walls", "Exterior Paint", "Latex Paint", "5 gallon", null, 35.99);
            dataGridView1.Rows.Add(null, null, null, null, null, "Total", null);
            dataGridView1.Rows.Add(null, null, null, null, null, null, null);
            dataGridView1.Rows.Add("Windows", "Single Hung Window", "Vinyl insulated with grids", "35.5-in", null, 227.99);
            dataGridView1.Rows.Add(null, null, null, null, null, "Total", null);
            dataGridView1.Rows.Add(null, null, null, null, null, null, null);
            dataGridView1.Rows.Add("Door", "Modern Fiberglass Door", "Fiberglass for durability", "36-in x 80-in", null, 959.99);
            dataGridView1.Rows.Add(null, null, null, null, null, "Total", null);
            dataGridView1.Rows.Add(null, null, null, null, null, "Grand total", null);

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }//end of dgv1 

        
    }
}
