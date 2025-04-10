namespace project_471223015
{
    partial class CircleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelArea = new System.Windows.Forms.Label();
            this.labelAreaResult = new System.Windows.Forms.Label();
            this.areaCalulation = new System.Windows.Forms.Button();
            this.drawButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.labelRadius = new System.Windows.Forms.Label();
            this.labelPerimeterResult = new System.Windows.Forms.Label();
            this.labelPerimetar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArea.Location = new System.Drawing.Point(3, 8);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(86, 32);
            this.labelArea.TabIndex = 2;
            this.labelArea.Text = "Лице";
            // 
            // labelAreaResult
            // 
            this.labelAreaResult.AutoSize = true;
            this.labelAreaResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAreaResult.Location = new System.Drawing.Point(194, 8);
            this.labelAreaResult.Name = "labelAreaResult";
            this.labelAreaResult.Size = new System.Drawing.Size(0, 32);
            this.labelAreaResult.TabIndex = 3;
            // 
            // areaCalulation
            // 
            this.areaCalulation.Location = new System.Drawing.Point(49, 328);
            this.areaCalulation.Name = "areaCalulation";
            this.areaCalulation.Size = new System.Drawing.Size(100, 42);
            this.areaCalulation.TabIndex = 4;
            this.areaCalulation.Text = "Изчисли ";
            this.areaCalulation.UseVisualStyleBackColor = true;
            this.areaCalulation.Click += new System.EventHandler(this.areaCalulation_Click);
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(240, 328);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(96, 42);
            this.drawButton.TabIndex = 5;
            this.drawButton.Text = "Изчертай фигурата";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 60);
            this.panel1.TabIndex = 6;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Location = new System.Drawing.Point(157, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(94, 38);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Кръг";
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxRadius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRadius.Location = new System.Drawing.Point(38, 112);
            this.textBoxRadius.Multiline = true;
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(313, 34);
            this.textBoxRadius.TabIndex = 7;
            this.textBoxRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRadius.Location = new System.Drawing.Point(32, 90);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(109, 32);
            this.labelRadius.TabIndex = 8;
            this.labelRadius.Text = "Радиус";
            // 
            // labelPerimeterResult
            // 
            this.labelPerimeterResult.AutoSize = true;
            this.labelPerimeterResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPerimeterResult.Location = new System.Drawing.Point(194, 64);
            this.labelPerimeterResult.Name = "labelPerimeterResult";
            this.labelPerimeterResult.Size = new System.Drawing.Size(0, 32);
            this.labelPerimeterResult.TabIndex = 9;
            // 
            // labelPerimetar
            // 
            this.labelPerimetar.AutoSize = true;
            this.labelPerimetar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPerimetar.Location = new System.Drawing.Point(3, 64);
            this.labelPerimetar.Name = "labelPerimetar";
            this.labelPerimetar.Size = new System.Drawing.Size(153, 29);
            this.labelPerimetar.TabIndex = 10;
            this.labelPerimetar.Text = "Периметър";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelPerimetar);
            this.panel2.Controls.Add(this.labelPerimeterResult);
            this.panel2.Controls.Add(this.labelAreaResult);
            this.panel2.Controls.Add(this.labelArea);
            this.panel2.Location = new System.Drawing.Point(38, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 109);
            this.panel2.TabIndex = 11;
            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(412, 413);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelRadius);
            this.Controls.Add(this.textBoxRadius);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.areaCalulation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CircleForm";
            this.Text = "CircleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelAreaResult;
        private System.Windows.Forms.Button areaCalulation;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.Label labelPerimeterResult;
        private System.Windows.Forms.Label labelPerimetar;
        private System.Windows.Forms.Panel panel2;
    }
}