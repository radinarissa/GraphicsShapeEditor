using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_471223015
{
    public partial class CircleForm : Form
    {
        private float radius;
        public CircleForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            drawButton.Click+= new EventHandler(drawButton_Click);
        }
        private void areaCalulation_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxRadius.Text, out radius))
            {
                double area = Math.PI * radius * radius;
                labelAreaResult.Text = $"{area:F2}";
                double perimeter = 2 * Math.PI * radius;
                labelPerimeterResult.Text = $"{perimeter:F2}";
            }
        }
        private void drawButton_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxRadius.Text, out radius))
            {
                MainForm mainForm = (MainForm)this.Owner;
                mainForm.circleRadius = radius;
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
