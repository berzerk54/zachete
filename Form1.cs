using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zachete
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void clear_Grid()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n, m;
            Random rnd = new Random();

            n = rnd.Next(1, 10);
            m= rnd.Next(1, 10);
            
            textBox1.Text = n.ToString();
            textBox2.Text = m.ToString();
            int[] str = new int[n];
            int[] col = new int[m];
            int[] d = new int[m];

            for (int i = 0; i < str.Length; i++)
            {
                str[i] = rnd.Next(1, 99);
            }
            for (int i = 0; i < col.Length; i++)
            {
                col[i] = rnd.Next(1, 99);
            }
            clear_Grid();

            DataGridViewTextBoxColumn[] column = new DataGridViewTextBoxColumn[n];
            DataGridViewTextBoxColumn[] column2 = new DataGridViewTextBoxColumn[n];

            for (int i = 0; i < n; i++)
            {
                column[i] = new DataGridViewTextBoxColumn(); // выделяем память для объекта
                column2[i] = new DataGridViewTextBoxColumn();
                column[i].HeaderText = "Header" + i;
                column[i].Name = "Header" + i;
            }

            this.dataGridView1.Columns.AddRange(column); // добавление столбцов
            for (int i = 0; i < m; i++)
            {
                this.dataGridView1.Rows.Add();  // добавление строк
            }
            this.dataGridView2.Columns.AddRange(column2); // добавление столбцов
            for (int i = 0; i < m; i++)
            {
               
            }

            for (int x = 0; x < dataGridView1.ColumnCount; x++)
            {
                for (int y = 0; y < dataGridView1.RowCount; y++)
                {
                    dataGridView1[x, y].Value = rnd.Next(1, 99); // Значения берутся рандомно из заданного пользователем интервала
                }

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработано Волжанкиным А.А., группа ПБТ-94", "А кто это сделал?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* for (int i = 0; i < str.Length; i++)
            {
                str[i] = rnd.Next(1, 99);
            }
            for (int i = 0; i < col.Length; i++)
            {
                col[i] = rnd.Next(1, 99);
            }*/

            for (int i = 0; i< )
        }

        //  field_Init(n, m);
    }
    
}
