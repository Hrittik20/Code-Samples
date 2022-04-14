using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation_3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 14;
            dataGridView1.RowCount = 20;


            dataGridView1.Rows[0].Cells[6].Style.BackColor = Color.Black;
            dataGridView1.Rows[0].Cells[7].Style.BackColor = Color.Black;
            dataGridView1.Rows[0].Cells[11].Style.BackColor = Color.Black;


            for (int x = 1; x < dataGridView1.Rows.Count; x++)
            {
                for (int y = 0; y < dataGridView1.Rows[x].Cells.Count; y++)
                {
                    if (y > 0 && y < dataGridView1.ColumnCount - 1 )
                    {

                        if (dataGridView1.Rows[x - 1].Cells[y - 1].Style.BackColor == Color.Black && dataGridView1.Rows[x - 1].Cells[y].Style.BackColor == Color.Black
                            && dataGridView1.Rows[x - 1].Cells[y + 1].Style.BackColor != Color.Black)
                        {
                            dataGridView1.Rows[x].Cells[y].Style.BackColor = Color.Black;
                        }

                        if (dataGridView1.Rows[x - 1].Cells[y - 1].Style.BackColor == Color.Black && dataGridView1.Rows[x - 1].Cells[y].Style.BackColor != Color.Black
                            && dataGridView1.Rows[x - 1].Cells[y + 1].Style.BackColor == Color.Black)
                        {
                            dataGridView1.Rows[x].Cells[y].Style.BackColor = Color.Black;
                        }

                        if (dataGridView1.Rows[x - 1].Cells[y - 1].Style.BackColor != Color.Black && dataGridView1.Rows[x - 1].Cells[y].Style.BackColor == Color.Black
                            && dataGridView1.Rows[x - 1].Cells[y + 1].Style.BackColor == Color.Black)
                        {
                            dataGridView1.Rows[x].Cells[y].Style.BackColor = Color.Black;
                        }

                        if (dataGridView1.Rows[x - 1].Cells[y - 1].Style.BackColor != Color.Black && dataGridView1.Rows[x - 1].Cells[y].Style.BackColor == Color.Black
                            && dataGridView1.Rows[x - 1].Cells[y + 1].Style.BackColor != Color.Black)
                        {
                            dataGridView1.Rows[x].Cells[y].Style.BackColor = Color.Black;
                        }

                        if (dataGridView1.Rows[x - 1].Cells[y - 1].Style.BackColor != Color.Black && dataGridView1.Rows[x - 1].Cells[y].Style.BackColor != Color.Black
                            && dataGridView1.Rows[x - 1].Cells[y + 1].Style.BackColor == Color.Black)
                        {
                            dataGridView1.Rows[x].Cells[y].Style.BackColor = Color.Black;
                        }

                    }

                }
            }


        }
    }
}
