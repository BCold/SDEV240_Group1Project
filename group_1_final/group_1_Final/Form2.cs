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
        private int rowIndex = 0;
        public Form2()
        {
            InitializeComponent();

        }
        void CalcMaterialTotal()
        // Calculates the total cost of a material based on input quantity and unit pricing
        {
            for (int i = 0; i < dataGridView1.RowCount; ++i)
            {
                if (dataGridView1.Rows[i].Cells[4].Value != null && dataGridView1.Rows[i].Cells[5].Value != null)
                {
                    int quantity = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                    double unitPrice = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    dataGridView1.Rows[i].Cells[6].Value = (quantity * unitPrice).ToString("F2");
                }
            }
        }

        void CalcGrandTotal()
        {
            double grandTotal = 0;
            for (int i = 0; i < dataGridView1.RowCount; ++i)
            {
                if (dataGridView1.Rows[i].Cells[6].Value != null)
                {
                    grandTotal += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                }
            }
            label1.Text = grandTotal.ToString("F2");

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Flooring", "Concrete", "Ready to Mix Concrete", "50 lb bag", 5, 10.99);
            dataGridView1.Rows.Add("Flooring", "Rebar", "Steel", "1/2 inch x 10 ft", 10, 4.99);
            dataGridView1.Rows.Add("Flooring", "Tile", "Flat Clay Flooring", "3 inches by 12 inches", 20, 3.99);
            dataGridView1.Rows.Add(null, null, null, null, null, "Total", null);
            dataGridView1.Rows.Add(null, null, null, null, null, null, null);
            dataGridView1.Rows.Add("Walls", "Dry wall", "Walls", "1/2-in x 4-ft x 8-ft", 5, 11.99);
            dataGridView1.Rows.Add("Walls", "Interior Paint", "Low Odor Paint Semi Gloss", "1 Quart", 2, 14.99);
            dataGridView1.Rows.Add("Walls", "Exterior Paint", "Latex Paint", "5 gallon", 1, 35.99);
            dataGridView1.Rows.Add(null, null, null, null, null, "Total", null);
            dataGridView1.Rows.Add(null, null, null, null, null, null, null);
            dataGridView1.Rows.Add("Windows", "Single Hung Window", "Vinyl insulated with grids", "35.5-in", null, 227.99);
            dataGridView1.Rows.Add(null, null, null, null, null, "Total", null);
            dataGridView1.Rows.Add(null, null, null, null, null, null, null);
            dataGridView1.Rows.Add("Door", "Modern Fiberglass Door", "Fiberglass for durability", "36-in x 80-in", null, 959.99);
            dataGridView1.Rows.Add(null, null, null, null, null, "Total", null);
            dataGridView1.Rows.Add(null, null, null, null, null, "Grand total", null);
        }

        private void DataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dataGridView1.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void ContextMenuStrip1_Click(object sender, EventArgs e)
        {
            if (!this.dataGridView1.Rows[this.rowIndex].IsNewRow)
                this.dataGridView1.Rows.RemoveAt(this.rowIndex);
        }

        private void DataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            CalcMaterialTotal();
            CalcGrandTotal();
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            CalcMaterialTotal();
            CalcGrandTotal();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
