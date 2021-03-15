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
        int[,] Mas { get; set; }
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
      
        public  void mas_init(int n, int m)
        {
            
            
            
        }
        public void button1_Click(object sender, EventArgs e)
        {
            int n, m;
            Random rnd = new Random();

            n = rnd.Next(1, 10);
            m = rnd.Next(1, 10);

            textBox1.Text = n.ToString();
            textBox2.Text = m.ToString();
           
            /*int[] str = new int[n];
            int[] col = new int[m];*/
            int[,] mas = new int[n, m];
            int[] d = new int[m];


            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.Next(1, 99);
                }
                clear_Grid();

                DataGridViewTextBoxColumn[] column = new DataGridViewTextBoxColumn[n];
                DataGridViewTextBoxColumn[] column2 = new DataGridViewTextBoxColumn[n];

                for (int z = 0; z < mas.GetLength(0); z++)
                {
                    column[z] = new DataGridViewTextBoxColumn(); // выделяем память для объекта
                    column2[z] = new DataGridViewTextBoxColumn();

                }

                this.dataGridView1.Columns.AddRange(column); // добавление столбцов
                for (int k = 1; k < mas.GetLength(1); k++)
                {
                    this.dataGridView1.Rows.Add();  // добавление строк
                }
                this.dataGridView2.Columns.AddRange(column2); // добавление столбцов
                for (int k = 1; k < mas.GetLength(1); k++)
                {

                }

                for (int x = 0; x < dataGridView1.ColumnCount; x++)
                {
                    for (int y = 0; y < dataGridView1.RowCount; y++)
                    {
                        this.dataGridView1[x, y].Value = rnd.Next(1, 99); // Значения берутся рандомно из заданного пользователем интервала
                    }

                }

                //сортируем столбцы

                /*for ( i = 0; i < mas.GetLength(0); i++)
                {

                    int min = Convert.ToInt32(dataGridView1[i, 0].Value);
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        if (min > Convert.ToInt32(dataGridView1[i, j].Value))
                            min = Convert.ToInt32(dataGridView1[i, j].Value);
                    }
                    dataGridView2[i, 0].Value = min;
                }
                */
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
            
            
            for (int i = 0; i < Mas.GetLength(0); i++)
            {

                int min = Convert.ToInt32(dataGridView1[i, 0].Value);
                for (int j = 0; j < Mas.GetLength(1); j++)
                {
                    if (min > Convert.ToInt32(dataGridView1[i, j].Value))
                        min = Convert.ToInt32(dataGridView1[i, j].Value);
                }
                dataGridView2[i, 0].Value = min;
            }

        }

        private void стартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender,e);
        }

        private void минимумToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) contextMenuStrip1.Show(Cursor.Position);
        }
    }
    }


