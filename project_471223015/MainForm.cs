using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace project_471223015
{
    public partial class MainForm : Form
    {
        private Color new_color = Color.White;
        private enum ShapeEnum { None, Circle, Triangle, Rectangle };
        private ShapeEnum selectedShape = ShapeEnum.None;

        private List<Shape> shapes = new List<Shape>();
        private readonly Stack<List<Shape>> undoStack = new Stack<List<Shape>>();
        private readonly Stack<List<Shape>> redoStack = new Stack<List<Shape>>();

        Pen p = new Pen(Color.Yellow);
        ColorDialog colorDialog = new ColorDialog();

        private bool isFilling = false;
        private Shape selectedShape1;

        private bool isDragging = false;
        private bool isMovingEnabled = false;
        private Point lastMousePosition;
       
        public float circleRadius { get; set; }
        public int triangleRadius { get; set; }
        public float rectangleWidth { get; set; }
        public float rectangleHeight { get; set; }
        public float point1 { get; set; }
        public float point2 { get; set; }
        public float point3 { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }
     
        private void pic_Click(object sender, EventArgs e)
        {

        }
        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                    new_color = colorDialog.Color;
                    showColorButton.BackColor = colorDialog.Color;
                    p.Color = colorDialog.Color;
            }
            isMovingEnabled = false;
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (selectedShape != ShapeEnum.None && isMovingEnabled == false)
            {
                if (!isFilling)
                {
                    Create_Shape(e.Location); 
                }
                else
                {
                    Fill_Shape(e.Location);
                    isFilling= true;
                }

                pic.Invalidate(); 
            }
        }
        private void Create_Shape(Point coordinates)
        {
            switch (selectedShape)
            {
                case ShapeEnum.Circle:
                    Circle circle = new Circle(coordinates, circleRadius, new_color);
                    shapes.Add(circle.Clone());
                    selectedShape1 = circle;
                    break;
                case ShapeEnum.Triangle:
                    Triangle triangle = new Triangle(coordinates,triangleRadius, new_color);
                    shapes.Add(triangle.Clone());
                    selectedShape1 = triangle;
                    break;
                case ShapeEnum.Rectangle:
                    RectangleShape rectangle = new RectangleShape(coordinates,rectangleWidth,rectangleHeight,new_color);
                    shapes.Add(rectangle.Clone());
                    selectedShape1 = rectangle;
                    break;
            }
            AddToStack();
        }

        private void Fill_Shape(Point coordinates)
        {
            foreach (var shape in shapes)
            {
                if (shape.IsPointInside(coordinates))
                {
                    shape.FillColor = new_color;

                    shape.Fill(pic.CreateGraphics());
                    break;
                }
            }
            AddToStack();
            isMovingEnabled = false;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics); 
            }
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            selectedShape = ShapeEnum.Circle;
            isFilling = false;
            isMovingEnabled= false;

            CircleForm c = new CircleForm();
            c.Owner = this;
            c.ShowDialog();
        }
        private void triangleButton_Click(object sender, EventArgs e)
        {
            selectedShape = ShapeEnum.Triangle;
            isFilling = false;
            isMovingEnabled = false;

            TriangleForm t = new TriangleForm();
            t.Owner = this;
            t.ShowDialog();
        }
        
        private void rectangleButton_Click(object sender, EventArgs e)
        {
            selectedShape = ShapeEnum.Rectangle;
            isFilling = false;
            isMovingEnabled = false;

            RectangleForm r = new RectangleForm();
            r.Owner = this;
            r.ShowDialog();
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            isFilling = true;
            isMovingEnabled= false;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = new Bitmap(pic.Width, pic.Height);
                pic.DrawToBitmap(btm, new Rectangle(0, 0, pic.Width, pic.Height));
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)
            {
                if (shapes.Count > 0)
                {
                    shapes.RemoveAt(shapes.Count - 1);
                    pic.Invalidate();
                }

                var currentState = new List<Shape>(shapes);
                redoStack.Push(currentState);
                shapes = undoStack.Pop();

                pic.Invalidate();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            isMovingEnabled= false;
            isFilling= false;
            shapes.Clear();
            pic.Invalidate();
            undoStack.Clear();
            redoStack.Clear();

        }
        private void redoButton_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                var currentState = new List<Shape>(shapes);
                undoStack.Push(currentState);

                shapes = redoStack.Pop();

                pic.Invalidate();
            }
        }
        private void AddToStack()
        {
            var currentState = new List<Shape>();
            foreach (var shape in shapes)
            {
                currentState.Add(shape.Clone());
            }
            undoStack.Push(currentState);
            redoStack.Clear();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void shape_Click(object sender, EventArgs e)
        {
            selectedShape1 = (Shape)sender;
        }
        
        private void move_Click(object sender, EventArgs e)
        {
            isMovingEnabled = true;
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && isMovingEnabled)
            {

                foreach (var shape in shapes)
                {
                    if (shape.IsPointInside(e.Location))
                    {
                        selectedShape1 = shape;
                        isDragging = true;
                        lastMousePosition = e.Location;
                        break;
                    }
                }
            }
        }
        private void pic_MouseMove(object sender, MouseEventArgs e)
        {

                if (isDragging && isMovingEnabled && selectedShape1 != null)
                {
                    int deltaX = e.X - lastMousePosition.X;
                    int deltaY = e.Y - lastMousePosition.Y;
                    selectedShape1.Move(deltaX, deltaY);
                    lastMousePosition = e.Location;
                    pic.Invalidate();
                }
        }
        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMovingEnabled)
            {
                isDragging = false;
            }
        }
        private void showColorButton_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void findRedShapesButton_Click(object sender, EventArgs e)
        {
            Color redColor = Color.Red;
            var redShapes = shapes.Where(shape => shape.Color == redColor).ToList();

            if (redShapes.Any())
            {
                MessageBox.Show($"Намерени са {redShapes.Count} червени фигури.");
            }
            else
            {
                MessageBox.Show("Не са намерени червени фигури.");
            }
        }

        private void removeBlackShapesButton_Click(object sender, EventArgs e)
        {
            shapes = shapes.Where(shape => shape.Color != Color.Black).ToList();
            pic.Invalidate();
            MessageBox.Show("Изтрихте всички черни фигури.");
        }
    }
}