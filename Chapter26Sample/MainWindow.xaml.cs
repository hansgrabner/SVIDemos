using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chapter26Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private enum SelectedShape
        { Circle, Rectangle, Line }
        private SelectedShape _currentShape;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void myRect_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Change color of Rectangle when clicked.
            myRect.Fill = Brushes.Pink;
        }
        private void CircleOption_Click(object sender, RoutedEventArgs e)
        {
            _currentShape = SelectedShape.Circle;
        }

        private void RectOption_Click(object sender, RoutedEventArgs e)
        {
            _currentShape = SelectedShape.Rectangle;
        }
        private void LineOption_Click(object sender, RoutedEventArgs e)
        {
            _currentShape = SelectedShape.Line;
        }

        private void CanvasDrawingArea_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Shape shapeToRender = null;
            // Configure the correct shape to draw.
            switch (_currentShape)
            {
                case SelectedShape.Circle:
                    shapeToRender = new Ellipse() { Fill = Brushes.Green, Height = 35, Width = 35 };
                    break;
                case SelectedShape.Rectangle:
                    shapeToRender = new Rectangle()
                    { Fill = Brushes.Red, Height = 35, Width = 35, RadiusX = 10, RadiusY = 10 };
                    break;
                case SelectedShape.Line:
                    shapeToRender = new Line()
                    {
                        Stroke = Brushes.Blue,
                        StrokeThickness = 10,
                        X1 = 0,
                        X2 = 50,
                        Y1 = 0,
                        Y2 = 50,
                        StrokeStartLineCap = PenLineCap.Triangle,
                        StrokeEndLineCap = PenLineCap.Round
                    };
                    break;
                default:
                    return;
            }
            // Set top/left position to draw in the canvas.
            Canvas.SetLeft(shapeToRender, e.GetPosition(canvasDrawingArea).X);
            Canvas.SetTop(shapeToRender, e.GetPosition(canvasDrawingArea).Y);
            // Draw shape!
            canvasDrawingArea.Children.Add(shapeToRender);
        }
        private void CanvasDrawingArea_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            // First, get the X,Y location of where the user clicked.
            Point pt = e.GetPosition((Canvas)sender);
            // Use the HitTest() method of VisualTreeHelper to see if the user clicked
            // on an item in the canvas.
            HitTestResult result = VisualTreeHelper.HitTest(canvasDrawingArea, pt);
            // If the result is not null, they DID click on a shape!
            if (result != null)
            {
                // Get the underlying shape clicked on, and remove it from
                // the canvas.
                canvasDrawingArea.Children.Remove(result.VisualHit as Shape);
            }
        }
    }
}
