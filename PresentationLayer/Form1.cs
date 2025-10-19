using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prg272_groupProject.PresentationLayer;


namespace prg272_groupProject.Presentation_Layer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       // public Form1()
       // {
       //     InitializeComponent();
        //    dataGridViewHeroes.Visible = false; // hide it at startup
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!int.TryParse(textBox1.Text, out int value1))
            {
                MessageBox.Show("HeroID must be a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            if (!int.TryParse(textBox2.Text, out int value2))
            {
                MessageBox.Show(" Age must be a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            string value3 = textBox3.Text.Trim();
            string value4 = textBox4.Text.Trim();

            if (string.IsNullOrWhiteSpace(value3))
            {
                MessageBox.Show("Cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(value4))
            {
                MessageBox.Show("Cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return;
            }

            string filePath = @"C:\Users\Andile\Downloads\PRG272-GROUP PROJECT\prg272-groupProject\DataLayer\Superheroes.txt";


            try
            {
                string line = $"{value1}, {value2}, {value3}, {value4}{Environment.NewLine}";
                File.AppendAllText(filePath, line);

                MessageBox.Show("Input saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !int.TryParse(textBox1.Text, out _))
            {
                errorProvider1.SetError(textBox1, "HeroID must be a number!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           if(!string.IsNullOrWhiteSpace(textBox2.Text) && !int.TryParse(textBox2.Text, out _))
            {
                errorProvider1.SetError(textBox2, "Age must be a number!");
            }
              else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                errorProvider1.SetError(textBox3, "Cannot be empty!");
            }
            else if (textBox3.Text.Any(char.IsDigit))
            {
                errorProvider1.SetError(textBox3, "Numbers are not allowed!");
            }
            else
            {
                errorProvider1.Clear();
            }
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                errorProvider1.SetError(textBox3, "Cannot be empty!");
            }
            else if (textBox3.Text.Any(char.IsDigit))
            {
                errorProvider1.SetError(textBox3, "Numbers are not allowed!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewscs viewForm = new DataGridViewscs(); 
            viewForm.ShowDialog();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                errorProvider1.SetError(textBox6, "Cannot be empty!");
            }
            else if (!int.TryParse(textBox5.Text, out int score))
            {
                errorProvider1.SetError(textBox6, "Enter a valid number!");
            }
            else if (score < 0 || score > 100)
            {
                errorProvider1.SetError(textBox6, "Score must be between 0 and 100!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
    }

