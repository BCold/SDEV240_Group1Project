namespace group_1_Final
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialsTable = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grandTotalLabel = new System.Windows.Forms.Label();
            this.exportFileBox = new System.Windows.Forms.TextBox();
            this.exportFileBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.categoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.materialsTable)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialsTable
            // 
            this.materialsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.materialsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.materialsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materialsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.materialsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.materialsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.materialsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryColumn,
            this.itemColumn,
            this.materialColumn,
            this.descriptionColumn,
            this.quantityColumn,
            this.unitCostColumn,
            this.costColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.materialsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.materialsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.materialsTable.Location = new System.Drawing.Point(0, 0);
            this.materialsTable.Margin = new System.Windows.Forms.Padding(2);
            this.materialsTable.Name = "materialsTable";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.materialsTable.RowHeadersVisible = false;
            this.materialsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialsTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.materialsTable.RowTemplate.Height = 46;
            this.materialsTable.Size = new System.Drawing.Size(2449, 1214);
            this.materialsTable.TabIndex = 0;
            this.materialsTable.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEnter);
            this.materialsTable.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellLeave);
            this.materialsTable.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 26);
            this.contextMenuStrip1.Click += new System.EventHandler(this.ContextMenuStrip1_Click);
            // 
            // deleteRowItem
            // 
            this.deleteRowItem.Name = "deleteRowItem";
            this.deleteRowItem.Size = new System.Drawing.Size(133, 22);
            this.deleteRowItem.Text = "Delete Row";
            // 
            // grandTotalLabel
            // 
            this.grandTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grandTotalLabel.AutoSize = true;
            this.grandTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotalLabel.Location = new System.Drawing.Point(2333, 1227);
            this.grandTotalLabel.Name = "grandTotalLabel";
            this.grandTotalLabel.Size = new System.Drawing.Size(104, 40);
            this.grandTotalLabel.TabIndex = 1;
            this.grandTotalLabel.Text = "Grand Total\r\n0.00";
            this.grandTotalLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exportFileBox
            // 
            this.exportFileBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.exportFileBox.Location = new System.Drawing.Point(1107, 1237);
            this.exportFileBox.Name = "exportFileBox";
            this.exportFileBox.Size = new System.Drawing.Size(240, 20);
            this.exportFileBox.TabIndex = 2;
            // 
            // exportFileBtn
            // 
            this.exportFileBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.exportFileBtn.Location = new System.Drawing.Point(1363, 1236);
            this.exportFileBtn.Name = "exportFileBtn";
            this.exportFileBtn.Size = new System.Drawing.Size(75, 23);
            this.exportFileBtn.TabIndex = 3;
            this.exportFileBtn.Text = "Save to File";
            this.exportFileBtn.UseVisualStyleBackColor = true;
            this.exportFileBtn.Click += new System.EventHandler(this.SaveFileBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearBtn.Location = new System.Drawing.Point(12, 1236);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear Table";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // categoryColumn
            // 
            this.categoryColumn.FillWeight = 10F;
            this.categoryColumn.HeaderText = "Category";
            this.categoryColumn.MinimumWidth = 80;
            this.categoryColumn.Name = "categoryColumn";
            // 
            // itemColumn
            // 
            this.itemColumn.FillWeight = 10F;
            this.itemColumn.HeaderText = "Item";
            this.itemColumn.MinimumWidth = 15;
            this.itemColumn.Name = "itemColumn";
            // 
            // materialColumn
            // 
            this.materialColumn.FillWeight = 10F;
            this.materialColumn.HeaderText = "Material";
            this.materialColumn.MinimumWidth = 15;
            this.materialColumn.Name = "materialColumn";
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.FillWeight = 10F;
            this.descriptionColumn.HeaderText = "Description";
            this.descriptionColumn.MinimumWidth = 15;
            this.descriptionColumn.Name = "descriptionColumn";
            // 
            // quantityColumn
            // 
            this.quantityColumn.FillWeight = 10F;
            this.quantityColumn.HeaderText = "Quantity";
            this.quantityColumn.MinimumWidth = 15;
            this.quantityColumn.Name = "quantityColumn";
            // 
            // unitCostColumn
            // 
            this.unitCostColumn.FillWeight = 10F;
            this.unitCostColumn.HeaderText = "Unit Cost";
            this.unitCostColumn.MinimumWidth = 15;
            this.unitCostColumn.Name = "unitCostColumn";
            // 
            // costColumn
            // 
            this.costColumn.FillWeight = 10F;
            this.costColumn.HeaderText = "Cost";
            this.costColumn.MinimumWidth = 15;
            this.costColumn.Name = "costColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2449, 1290);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.exportFileBtn);
            this.Controls.Add(this.exportFileBox);
            this.Controls.Add(this.grandTotalLabel);
            this.Controls.Add(this.materialsTable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materials List Estimator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialsTable)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView materialsTable;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteRowItem;
        private System.Windows.Forms.Label grandTotalLabel;
        private System.Windows.Forms.TextBox exportFileBox;
        private System.Windows.Forms.Button exportFileBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costColumn;
    }
}