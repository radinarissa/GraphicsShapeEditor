using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_471223015
{
    public partial class TriangleForm : Form
    {
        private int radius;
        public TriangleForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            drawButton.Click += new EventHandler(drawButton_Click);
        }

        private void calculateAreaTriangle_Click(object sender, EventArgs e)
        {
            radius = int.Parse(textBoxRadius.Text);
            double Pi = 3.14;
            double a = (3 * radius) / (2 * Math.Sin(Pi / 3));
            double Perimeter = 3*a;
            double Area = radius *radius *3*Math.Sqrt(3)/4;
            labelAreaResult.Text = $"{Area:F2}";
            labelPerimeterResult.Text = $"{Perimeter:F2}";
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxRadius.Text, out radius))
            {
                MainForm mainForm = (MainForm)this.Owner;
                mainForm.triangleRadius = radius;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid radius.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
