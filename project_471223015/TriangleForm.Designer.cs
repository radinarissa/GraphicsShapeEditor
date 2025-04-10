namespace project_471223015
{
    partial class TriangleForm
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
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateAreaTriangle = new System.Windows.Forms.Button();
            this.drawButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAreaResult = new System.Windows.Forms.Label();
            this.labelPerimeterResult = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxRadius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRadius.Location = new System.Drawing.Point(42, 115);
            this.textBoxRadius.Multiline = true;
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(343, 34);
            this.textBoxRadius.TabIndex = 1;
            this.textBoxRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Location = new System.Drawing.Point(126, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(180, 32);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Триъгълник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Радиус";
            // 
            // calculateAreaTriangle
            // 
            this.calculateAreaTriangle.Location = new System.Drawing.Point(62, 367);
            this.calculateAreaTriangle.Name = "calculateAreaTriangle";
            this.calculateAreaTriangle.Size = new System.Drawing.Size(91, 45);
            this.calculateAreaTriangle.TabIndex = 13;
            this.calculateAreaTriangle.Text = "Изчисли ";
            this.calculateAreaTriangle.UseVisualStyleBackColor = true;
            this.calculateAreaTriangle.Click += new System.EventHandler(this.calculateAreaTriangle_Click);
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(267, 365);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(91, 47);
            this.drawButton.TabIndex = 14;
            this.drawButton.Text = "Изчертай фигурата";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 64);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Лице";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Периметър";
            // 
            // labelAreaResult
            // 
            this.labelAreaResult.AutoSize = true;
            this.labelAreaResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAreaResult.Location = new System.Drawing.Point(206, 15);
            this.labelAreaResult.Name = "labelAreaResult";
            this.labelAreaResult.Size = new System.Drawing.Size(0, 25);
            this.labelAreaResult.TabIndex = 18;
            // 
            // labelPerimeterResult
            // 
            this.labelPerimeterResult.AutoSize = true;
            this.labelPerimeterResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPerimeterResult.Location = new System.Drawing.Point(206, 66);
            this.labelPerimeterResult.Name = "labelPerimeterResult";
            this.labelPerimeterResult.Size = new System.Drawing.Size(0, 25);
            this.labelPerimeterResult.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelPerimeterResult);
            this.panel2.Controls.Add(this.labelAreaResult);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(33, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 112);
            this.panel2.TabIndex = 20;
            // 
            // TriangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(430, 460);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.calculateAreaTriangle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRadius);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TriangleForm";
            this.Text = "TriangleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateAreaTriangle;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAreaResult;
        private System.Windows.Forms.Label labelPerimeterResult;
        private System.Windows.Forms.Panel panel2;
    }
}