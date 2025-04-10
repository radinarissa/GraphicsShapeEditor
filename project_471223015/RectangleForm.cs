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
    public partial class RectangleForm : Form
    {
        private float width;
        private float height;
        public RectangleForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            drawButton.Click += new EventHandler(drawButton_Click);
        }

        private void calculateAreaRectangle_Click(object sender, EventArgs e)
        {
            width = float.Parse(textBoxWidth.Text);
            height = float.Parse(textBoxHeight.Text);

            double area = width * height;
            labelArea.Text = $"{area:F2}";

            double perimetеr = 2 * (width+height);
            labelPerimetеr.Text = $"{perimetеr:F2}";
        }

        private void RectangleForm_Load(object sender, EventArgs e)
        {

        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxWidth.Text, out width) && float.TryParse(textBoxHeight.Text, out height))
            {
                MainForm mainForm = (MainForm)this.Owner;
                mainForm.rectangleWidth = width;
                mainForm.rectangleHeight = height;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid radius.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            this.Close();
        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
