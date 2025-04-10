using System;
using System.Windows.Forms;

namespace project_471223015
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.removeBlackShapesButton = new System.Windows.Forms.Button();
            this.findRedShapesButton = new System.Windows.Forms.Button();
            this.showColorButton = new System.Windows.Forms.Button();
            this.move = new System.Windows.Forms.Button();
            this.redoButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.fillButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.triangleButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.removeBlackShapesButton);
            this.panel1.Controls.Add(this.findRedShapesButton);
            this.panel1.Controls.Add(this.showColorButton);
            this.panel1.Controls.Add(this.move);
            this.panel1.Controls.Add(this.redoButton);
            this.panel1.Controls.Add(this.undoButton);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.colorButton);
            this.panel1.Controls.Add(this.fillButton);
            this.panel1.Controls.Add(this.rectangleButton);
            this.panel1.Controls.Add(this.triangleButton);
            this.panel1.Controls.Add(this.circleButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 85);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // removeBlackShapesButton
            // 
            this.removeBlackShapesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBlackShapesButton.Image = ((System.Drawing.Image)(resources.GetObject("removeBlackShapesButton.Image")));
            this.removeBlackShapesButton.Location = new System.Drawing.Point(1024, 12);
            this.removeBlackShapesButton.Name = "removeBlackShapesButton";
            this.removeBlackShapesButton.Size = new System.Drawing.Size(71, 58);
            this.removeBlackShapesButton.TabIndex = 12;
            this.removeBlackShapesButton.UseVisualStyleBackColor = true;
            this.removeBlackShapesButton.Click += new System.EventHandler(this.removeBlackShapesButton_Click);
            // 
            // findRedShapesButton
            // 
            this.findRedShapesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findRedShapesButton.Image = ((System.Drawing.Image)(resources.GetObject("findRedShapesButton.Image")));
            this.findRedShapesButton.Location = new System.Drawing.Point(945, 15);
            this.findRedShapesButton.Name = "findRedShapesButton";
            this.findRedShapesButton.Size = new System.Drawing.Size(61, 53);
            this.findRedShapesButton.TabIndex = 11;
            this.findRedShapesButton.UseVisualStyleBackColor = true;
            this.findRedShapesButton.Click += new System.EventHandler(this.findRedShapesButton_Click);
            // 
            // showColorButton
            // 
            this.showColorButton.BackColor = System.Drawing.Color.White;
            this.showColorButton.Location = new System.Drawing.Point(30, 17);
            this.showColorButton.Name = "showColorButton";
            this.showColorButton.Size = new System.Drawing.Size(53, 47);
            this.showColorButton.TabIndex = 10;
            this.showColorButton.UseVisualStyleBackColor = false;
            this.showColorButton.Click += new System.EventHandler(this.showColorButton_Click);
            // 
            // move
            // 
            this.move.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.move.Image = ((System.Drawing.Image)(resources.GetObject("move.Image")));
            this.move.Location = new System.Drawing.Point(595, 17);
            this.move.Name = "move";
            this.move.Size = new System.Drawing.Size(64, 42);
            this.move.TabIndex = 9;
            this.move.UseVisualStyleBackColor = true;
            this.move.Click += new System.EventHandler(this.move_Click);
            // 
            // redoButton
            // 
            this.redoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redoButton.Image = ((System.Drawing.Image)(resources.GetObject("redoButton.Image")));
            this.redoButton.Location = new System.Drawing.Point(729, 23);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(43, 35);
            this.redoButton.TabIndex = 8;
            this.redoButton.UseVisualStyleBackColor = true;
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undoButton.Image = ((System.Drawing.Image)(resources.GetObject("undoButton.Image")));
            this.undoButton.Location = new System.Drawing.Point(680, 23);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(43, 35);
            this.undoButton.TabIndex = 7;
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.Image")));
            this.clearButton.Location = new System.Drawing.Point(850, 21);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(52, 40);
            this.clearButton.TabIndex = 6;
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(791, 21);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(53, 40);
            this.saveButton.TabIndex = 5;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // colorButton
            // 
            this.colorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton.Image = global::project_471223015.Properties.Resources.color;
            this.colorButton.Location = new System.Drawing.Point(113, 13);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(79, 55);
            this.colorButton.TabIndex = 4;
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // fillButton
            // 
            this.fillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fillButton.Image = ((System.Drawing.Image)(resources.GetObject("fillButton.Image")));
            this.fillButton.Location = new System.Drawing.Point(198, 13);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(79, 55);
            this.fillButton.TabIndex = 3;
            this.fillButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // rectangleButton
            // 
            this.rectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("rectangleButton.Image")));
            this.rectangleButton.Location = new System.Drawing.Point(493, 6);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(84, 62);
            this.rectangleButton.TabIndex = 2;
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triangleButton.Image = ((System.Drawing.Image)(resources.GetObject("triangleButton.Image")));
            this.triangleButton.Location = new System.Drawing.Point(403, 6);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(84, 62);
            this.triangleButton.TabIndex = 1;
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton.Image = ((System.Drawing.Image)(resources.GetObject("circleButton.Image")));
            this.circleButton.Location = new System.Drawing.Point(313, 6);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(84, 62);
            this.circleButton.TabIndex = 0;
            this.circleButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.Snow;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 85);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1304, 437);
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1304, 522);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рисуване";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button triangleButton;
        private System.Windows.Forms.PictureBox pic;
        private Button fillButton;
        private Button colorButton;
        private Button saveButton;
        private Button redoButton;
        private Button undoButton;
        private Button clearButton;
        private Button move;
        private Button showColorButton;
        private Button findRedShapesButton;
        private Button removeBlackShapesButton;
    }
}

