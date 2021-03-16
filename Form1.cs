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
        static int n, m;
        static Random rnd = new Random();
        static int[,] mas;

        public void button1_Click(object sender, EventArgs e)
        {
            switch (checkBox1.Checked)
            {
                case true:
                    {
                        n = rnd.Next(1, 10);
                        m = rnd.Next(1, 10);
                        textBox1.Text = n.ToString();
                        textBox2.Text = m.ToString();
                        break;
                    }
                case false:
                    {
                        n = Convert.ToInt32( textBox1.Text);
                        m = Convert.ToInt32( textBox2.Text);


                        break;
                    }
            }
           
          

            

            /*int[] str = new int[n];
            int[] col = new int[m];*/
            mas = new int[n, m];



            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.Next(1, 99);
                }
                clear_Grid();

                DataGridViewTextBoxColumn[] column = new DataGridViewTextBoxColumn[m];
                DataGridViewTextBoxColumn[] column2 = new DataGridViewTextBoxColumn[m];

                for (int z = 0; z < mas.GetLength(1); z++)
                {
                    column[z] = new DataGridViewTextBoxColumn(); // выделяем память для объекта
                    column2[z] = new DataGridViewTextBoxColumn();

                }

                this.dataGridView1.Columns.AddRange(column); // добавление столбцов
                for (int k = 1; k < mas.GetLength(0); k++)
                {
                    this.dataGridView1.Rows.Add();  // добавление строк
                }
                this.dataGridView2.Columns.AddRange(column2); // добавление столбцов
                for (int k = 1; k < mas.GetLength(0); k++)
                {

                }

                for (int x = 0; x < dataGridView1.ColumnCount; x++)
                {
                    for (int y = 0; y < dataGridView1.RowCount; y++)
                    {
                        this.dataGridView1[x, y].Value = rnd.Next(1, 99); // Значения берутся рандомно из заданного пользователем интервала
                    }

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
            label4.Text = "";
            
            int[] d = new int[mas.GetLength(1)];
            
            //ищем минимальные значения
            for (int i = 0; i < mas.GetLength(1); i++)
            {

                int min = Convert.ToInt32(dataGridView1[i,0].Value);
                for (int j = 0; j < mas.GetLength(0); j++)
                {
                    if (min > Convert.ToInt32(dataGridView1[i, j].Value))
                        min = Convert.ToInt32(dataGridView1[i, j].Value);
                    
                }
               
                dataGridView2[i, 0].Value = min;
               
            }
            
            for (int k=0;k<mas.GetLength(1); k++ )
            {
                d[k] = Convert.ToInt32(dataGridView2.Rows[0].Cells[k].Value);
                label4.Text = label4.Text + Convert.ToString(d[k]) + ' ';
            }
            label4.Text = "Массив D: "+label4.Text ;
        }

        private void стартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender,e);
        }

        private void минимумToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            switch (checkBox2.Checked)
            {
                case true:
                    {
                        label4.Visible = true;
                        break;
                    }
                case false:
                    {
                        label4.Visible = false;
                        break;
                    }
            }
               
            
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            switch (checkBox1.Checked)
            {
                case true:
                    {
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                        break;
                    }
                case false:
                    {
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        break;
                    }
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) contextMenuStrip1.Show(Cursor.Position);
        }
    }
    }


