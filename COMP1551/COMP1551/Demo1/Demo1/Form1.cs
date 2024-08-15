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

namespace Demo1
{
    public partial class Form1 : Form
    {
        private string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines(@"D:/demo.txt");

                int sum = 0;

                foreach (string line in lines)
                {
                    if (int.TryParse(line, out int number))
                    {
                        sum += number;
                    }
                    else
                    {
                        MessageBox.Show($"Invalid number: {line}");
                    }
                }

                txt_result1.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        private void btn_sort_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines(@"D:/demo.txt");


                int[] numbers = Array.ConvertAll(lines, int.Parse);


                Array.Sort(numbers);


                txt_result2.Text = string.Join(", ", numbers);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"D:/demo.txt");

            int max = 0;

            foreach (string line in lines)
            {
                int a = (int)Convert.ToInt32(line);
                if (a > max)
                {
                    max = a;
                }
            }
            txt_result1.Text += max;
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"D:/demo.txt");

            int min = 0;

            foreach(string line in lines)
            {
                int a = (int)Convert.ToInt32(line);
                if (a < min)
                {
                    min = a;
                }
            }
            txt_result1.Text += min;
        }

        private void btn_sort_reverse_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines(@"D:/demo.txt");

                int[] numbers = Array.ConvertAll(lines, int.Parse);

                Array.Reverse(numbers);

                txt_result2.Text = string.Join(", ", numbers);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
