using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace group_1_Final
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        private int rowIndex = 0;
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        void CalcMaterialTotal()
        // Calculates the total cost of a material based on input quantity and unit pricing.
        {
            for (int i = 0; i < materialsTable.RowCount; ++i)
            {
                if (materialsTable.Rows[i].Cells[4].Value != null && materialsTable.Rows[i].Cells[5].Value != null)
                {
                    int quantity = Convert.ToInt32(materialsTable.Rows[i].Cells[4].Value);
                    double unitPrice = Convert.ToDouble(materialsTable.Rows[i].Cells[5].Value);
                    materialsTable.Rows[i].Cells[6].Value = (quantity * unitPrice).ToString("F2");
                }
            }
        }

        void CalcGrandTotal()
            // Calculates the grand cost of materials after individual material costs have been tallied.
        {
            double grandTotal = 0;
            for (int i = 0; i < materialsTable.RowCount; ++i)
            {
                if (materialsTable.Rows[i].Cells[6].Value != null)
                {
                    grandTotal += Convert.ToDouble(materialsTable.Rows[i].Cells[6].Value);
                }
            }
            grandTotalLabel.Text = "Grand Total\n" + grandTotal.ToString("F2");

        }

        void ExportToFile()
        // Outputs the contents of the dataGridView to a text file.

        {
            // Initializing delimiter for file output.
            char DELIM = ',';

  
            // Initializing FileStream and StreamWriter for file output.
            string fileName = @"" + exportFileBox.Text + ".txt";
   
            FileStream outFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            // Iterates through all rows and the dataGridView except for the final row, which will always be empty.
            for (int row = 0; row < materialsTable.RowCount - 1; ++row)
            {
                // Iterates through each column of the current row
                for (int column = 0; column < materialsTable.ColumnCount; ++column)
                {
                    // if the current cell is not empty it is written to the file. Each value is seperated by the delimiter held within the DELIM constant.
                    if (materialsTable.Rows[row].Cells[column].Value != null)
                        writer.Write(materialsTable.Rows[row].Cells[column].Value + DELIM.ToString());
                }

                // After all values are added to the file a new line is created which will hold the subsequent row's values.
                writer.Write("\n");
            }

            // Adds the calculated grand total value to the file.
            writer.WriteLine(grandTotalLabel.Text);

            // Clean up the writer and FileStream objects.
            writer.Close();
            outFile.Close();

            MessageBox.Show("File saved successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        // When the user right clicks within a cell the row is selected and a context menu appears at the location of the mouse cursor.
        {
            if (e.Button == MouseButtons.Right)
            {
                this.materialsTable.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.materialsTable.CurrentCell = this.materialsTable.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.materialsTable, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void ContextMenuStrip1_Click(object sender, EventArgs e)
        // When the deleteRowItem context menu item is clicked and the row is not new, deletes the selected row from the dataGridView.
        {
            if (!this.materialsTable.Rows[this.rowIndex].IsNewRow)
                this.materialsTable.Rows.RemoveAt(this.rowIndex);
        }

        private void DataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        // When a cell is no longer selected automatically calculates material and grand total values. This impleemntation renders a calculate button redundant, as it's done automatically by the program.
        {
            CalcMaterialTotal();
            CalcGrandTotal();
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        // When a cell is entered automatically calculates material and grand total values. This impleemntation renders a calculate button redundant, as it's done automatically by the program.
        {
            CalcMaterialTotal();
            CalcGrandTotal();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        // Ensures that the application exits properly when the second form is closed by the user.
        {
            Application.Exit();
        }

        private void SaveFileBtn_Click(object sender, EventArgs e)
        // Checks whether the fileInputBox is empty when the user clicks the saveFileBtn.
        {
            // Displays an alert to the user when they attempt to save a file without first entering a file name.
            if (string.IsNullOrEmpty(exportFileBox.Text))
                MessageBox.Show("You must enter a file name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // If there is text present in the fileInputBox when the user clicks the saveFileBtn hides the emptyBoxAlertLabel, calles the OutputToFile method and clears the contents of the fileInputBox. A confirmation MessageBox is displayed.
            else
                if (!string.IsNullOrEmpty(exportFileBox.Text))
                {
                    ExportToFile();
                    exportFileBox.Text = "";
                }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        // When the Clear button is clicked a MessageBox is displayed verifying that the user wants to clear the table. If the 'OK' button is clicked the table is wiped.
        {
            DialogResult warning;
            warning = MessageBox.Show("You are about to clear all data.\n Proceed?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if(warning == DialogResult.OK)
            {
                materialsTable.Rows.Clear();
                materialsTable.Refresh();
                materialsTable.ClearSelection();
            }
        }
    }
}
