namespace project_471223015
{
    partial class RectangleForm
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
            this.calculateAreaRectangle = new System.Windows.Forms.Button();
            this.labelArea = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            this.panelRectangle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPerimetеr = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelRectangle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateAreaRectangle
            // 
            this.calculateAreaRectangle.Location = new System.Drawing.Point(62, 366);
            this.calculateAreaRectangle.Name = "calculateAreaRectangle";
            this.calculateAreaRectangle.Size = new System.Drawing.Size(97, 48);
            this.calculateAreaRectangle.TabIndex = 0;
            this.calculateAreaRectangle.Text = "Изчисли ";
            this.calculateAreaRectangle.UseVisualStyleBackColor = true;
            this.calculateAreaRectangle.Click += new System.EventHandler(this.calculateAreaRectangle_Click);
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArea.Location = new System.Drawing.Point(193, 11);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(0, 32);
            this.labelArea.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Лице";
            // 
            // drawButton
            // 
            this.drawButton.BackColor = System.Drawing.Color.White;
            this.drawButton.Location = new System.Drawing.Point(252, 366);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(97, 48);
            this.drawButton.TabIndex = 11;
            this.drawButton.Text = "Изчертай фигурата";
            this.drawButton.UseVisualStyleBackColor = false;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // panelRectangle
            // 
            this.panelRectangle.BackColor = System.Drawing.Color.ForestGreen;
            this.panelRectangle.Controls.Add(this.labelTitle);
            this.panelRectangle.Location = new System.Drawing.Point(0, -6);
            this.panelRectangle.Name = "panelRectangle";
            this.panelRectangle.Size = new System.Drawing.Size(453, 59);
            this.panelRectangle.TabIndex = 12;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Location = new System.Drawing.Point(107, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(216, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Правоъгълник";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWidth.Location = new System.Drawing.Point(51, 98);
            this.textBoxWidth.Multiline = true;
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(319, 32);
            this.textBoxWidth.TabIndex = 13;
            this.textBoxWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWidth.Location = new System.Drawing.Point(45, 77);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(137, 32);
            this.labelWidth.TabIndex = 14;
            this.labelWidth.Text = "Дължина";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxHeight.Location = new System.Drawing.Point(51, 169);
            this.textBoxHeight.Multiline = true;
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(319, 32);
            this.textBoxHeight.TabIndex = 15;
            this.textBoxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Височина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Периметър";
            // 
            // labelPerimetеr
            // 
            this.labelPerimetеr.AutoSize = true;
            this.labelPerimetеr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPerimetеr.Location = new System.Drawing.Point(193, 59);
            this.labelPerimetеr.Name = "labelPerimetеr";
            this.labelPerimetеr.Size = new System.Drawing.Size(0, 32);
            this.labelPerimetеr.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelPerimetеr);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelArea);
            this.panel1.Location = new System.Drawing.Point(51, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 107);
            this.panel1.TabIndex = 19;
            // 
            // RectangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(430, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.panelRectangle);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.calculateAreaRectangle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RectangleForm";
            this.Text = "RectangleForm";
            this.Load += new System.EventHandler(this.RectangleForm_Load);
            this.panelRectangle.ResumeLayout(false);
            this.panelRectangle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateAreaRectangle;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Panel panelRectangle;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPerimetеr;
        private System.Windows.Forms.Panel panel1;
    }
}