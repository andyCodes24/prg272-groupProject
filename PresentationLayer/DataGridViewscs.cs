using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prg272_groupProject.PresentationLayer
{
    public partial class DataGridViewscs : Form
    {
        public DataGridViewscs()
        {
            InitializeComponent();
        }

        private void DataGridViewscs_Load(object sender, EventArgs e)
        {
            LoadHeroData();
        }
        private void LoadHeroData()
        {
            string filePath = @"C:\Users\Andile\Downloads\PRG272-GROUP PROJECT\prg272-groupProject\DataLayer\Superheroes.txt";

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);

                DataTable dt = new DataTable();
                dt.Columns.Add("Hero ID");
                dt.Columns.Add("Age");
                dt.Columns.Add("Name");
                dt.Columns.Add("SuperPower");
                dt.Columns.Add("Exam Score");

                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 4)
                        {
                            dt.Rows.Add(parts[0].Trim(), parts[1].Trim(), parts[2].Trim(), parts[3].Trim());
                        }
                    }
                }

                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No saved heroes found yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
