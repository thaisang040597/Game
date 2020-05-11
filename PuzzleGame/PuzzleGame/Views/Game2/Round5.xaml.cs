using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace PuzzleGame.Views.Game2
{
    /// <summary>
    /// Interaction logic for Round5.xaml
    /// </summary>
    public partial class Round5 : UserControl, INotifyPropertyChanged
    {
        int[,] Board;
        public Point _BasePoint1 { get; set; }
        public Point _BasePoint2 { get; set; }
        public Point _BasePoint3 { get; set; }
        public Point _BasePoint4 { get; set; }
        public Point _BasePoint5 { get; set; }
        public Point _BasePoint6 { get; set; }
        public Point _BasePoint7 { get; set; }
        public Point _BasePoint8 { get; set; }
        public Point _BasePoint9 { get; set; }
        public Point _BasePoint10 { get; set; }
        public Point _BasePoint11 { get; set; }
        public Point _BasePoint12 { get; set; }
        public Point _BasePoint13 { get; set; }
        public Point _BasePoint14 { get; set; }
        public Point _BasePoint15 { get; set; }
        public Point _BasePoint16 { get; set; }

        public static Point pointtemp;

        private static Point currentPositionImage;
        private double DeltaX = 0.0;
        private double DeltaY = 0.0;
        private bool moving = false;
        private static Point PositionInImage;
        public Round5()
        {
            this.DataContext = this;
            InitializeComponent();
            InitBoard();
            CreatePositionImage();
            RanDomImage();
        }
        public double XPosition1
        {
            get { return _BasePoint1.X + DeltaX; }
        }
        public double YPosition1
        {
            get { return _BasePoint1.Y + DeltaY; }
        }
        public double XPosition2
        {
            get { return _BasePoint2.X + DeltaX; }
        }
        public double YPosition2
        {
            get { return _BasePoint2.Y + DeltaY; }
        }
        public double XPosition3
        {
            get { return _BasePoint3.X + DeltaX; }
        }
        public double YPosition3
        {
            get { return _BasePoint3.Y + DeltaY; }
        }
        public double XPosition4
        {
            get { return _BasePoint4.X + DeltaX; }
        }
        public double YPosition4
        {
            get { return _BasePoint4.Y + DeltaY; }
        }
        public double XPosition5
        {
            get { return _BasePoint5.X + DeltaX; }
        }
        public double YPosition5
        {
            get { return _BasePoint5.Y + DeltaY; }
        }
        public double XPosition6
        {
            get { return _BasePoint6.X + DeltaX; }
        }
        public double YPosition6
        {
            get { return _BasePoint6.Y + DeltaY; }
        }
        public double XPosition7
        {
            get { return _BasePoint7.X + DeltaX; }
        }
        public double YPosition7
        {
            get { return _BasePoint7.Y + DeltaY; }
        }
        public double XPosition8
        {
            get { return _BasePoint8.X + DeltaX; }
        }
        public double YPosition8
        {
            get { return _BasePoint8.Y + DeltaY; }
        }
        public double XPosition9
        {
            get { return _BasePoint9.X + DeltaX; }
        }
        public double YPosition9
        {
            get { return _BasePoint9.Y + DeltaY; }
        }
        public double XPosition10
        {
            get { return _BasePoint10.X + DeltaX; }
        }
        public double YPosition10
        {
            get { return _BasePoint10.Y + DeltaY; }
        }
        public double XPosition11
        {
            get { return _BasePoint11.X + DeltaX; }
        }
        public double YPosition11
        {
            get { return _BasePoint11.Y + DeltaY; }
        }
        public double XPosition12
        {
            get { return _BasePoint12.X + DeltaX; }
        }
        public double YPosition12
        {
            get { return _BasePoint12.Y + DeltaY; }
        }
        public double XPosition13
        {
            get { return _BasePoint13.X + DeltaX; }
        }
        public double YPosition13
        {
            get { return _BasePoint13.Y + DeltaY; }
        }
        public double XPosition14
        {
            get { return _BasePoint14.X + DeltaX; }
        }
        public double YPosition14
        {
            get { return _BasePoint14.Y + DeltaY; }
        }
        public double XPosition15
        {
            get { return _BasePoint15.X + DeltaX; }
        }
        public double YPosition15
        {
            get { return _BasePoint15.Y + DeltaY; }
        }
        public double XPosition16
        {
            get { return _BasePoint16.X + DeltaX; }
        }
        public double YPosition16
        {
            get { return _BasePoint16.Y + DeltaY; }
        }
        static int x = 0;
        static int y = 300;
        static int z = 600;
        static int t = 900;
        public Int32Rect Pieces1 { get { return new Int32Rect(x, x, 300, 300); } }
        public Int32Rect Pieces2 { get { return new Int32Rect(y, x, 300, 300); } }
        public Int32Rect Pieces3 { get { return new Int32Rect(z, x, 300, 300); } }
        public Int32Rect Pieces4 { get { return new Int32Rect(t, x, 300, 300); } }
        public Int32Rect Pieces5 { get { return new Int32Rect(x, y, 300, 300); } }
        public Int32Rect Pieces6 { get { return new Int32Rect(y, y, 300, 300); } }
        public Int32Rect Pieces7 { get { return new Int32Rect(z, y, 300, 300); } }
        public Int32Rect Pieces8 { get { return new Int32Rect(t, y, 300, 300); } }
        public Int32Rect Pieces9 { get { return new Int32Rect(x, z, 300, 300); } }
        public Int32Rect Pieces10 { get { return new Int32Rect(y, z, 300, 300); } }
        public Int32Rect Pieces11 { get { return new Int32Rect(z, z, 300, 300); } }
        public Int32Rect Pieces12 { get { return new Int32Rect(t, z, 300, 300); } }
        public Int32Rect Pieces13 { get { return new Int32Rect(x, t, 300, 300); } }
        public Int32Rect Pieces14 { get { return new Int32Rect(y, t, 300, 300); } }
        public Int32Rect Pieces15 { get { return new Int32Rect(z, t, 300, 300); } }
        public Int32Rect Pieces16 { get { return new Int32Rect(t, t, 300, 300); } }



        //private void CutImage(Int32Rect obj)
        //{
        //    Image croppedImage = new Image();
        //    CroppedBitmap cb = new CroppedBitmap(
        //       (BitmapSource)this.Resources["masterImage"],
        //       obj);
        //    croppedImage.Source = cb;
        //}
        private static List<Point> list;
        private void CreatePositionImage()
        {
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            list = new List<Point>(16);
            list.Add(_BasePoint1);
            list.Add(_BasePoint2);
            list.Add(_BasePoint3);
            list.Add(_BasePoint4);
            list.Add(_BasePoint5);
            list.Add(_BasePoint6);
            list.Add(_BasePoint7);
            list.Add(_BasePoint8);
            list.Add(_BasePoint9);
            list.Add(_BasePoint10);
            list.Add(_BasePoint11);
            list.Add(_BasePoint12);
            list.Add(_BasePoint13);
            list.Add(_BasePoint14);
            list.Add(_BasePoint15);
            list.Add(_BasePoint16);

            var points = list.ToArray();
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    points[count].Y = (screenHeight - 440) / 2 + 110 * i;
                    points[count].X = (screenWidth - 440) / 2 + 110 * j;
                    count++;
                }
            }
            int count1 = 0;
            foreach (var item in points)
            {
                list[count1] = item;
                count1++;
            }
            var temp = 0;
            var lst = this.GetType().GetProperties();
            foreach (var prop in lst)
            {
                if (prop.PropertyType.Name == typeof(Point).Name && prop.Name.Contains("_BasePoint"))
                {
                    var value = prop.GetValue(this, null);
                    prop.SetValue(this, list[temp], null);
                    temp++;
                }
            }
            for (int i = 1; i < 17; i++)
            {
                RaisePropertyChanged("XPosition" + i);
                RaisePropertyChanged("YPosition" + i);
            }
        }

        private void Feast_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image l = e.Source as Image;
            Panel.SetZIndex(img1, 1);
            Panel.SetZIndex(img2, 2);
            Panel.SetZIndex(img3, 3);
            Panel.SetZIndex(img4, 4);
            Panel.SetZIndex(img5, 5);
            Panel.SetZIndex(img6, 6);
            Panel.SetZIndex(img7, 7);
            Panel.SetZIndex(img8, 8);
            Panel.SetZIndex(img9, 9);
            Panel.SetZIndex(img10, 10);
            Panel.SetZIndex(img11, 11);
            Panel.SetZIndex(img12, 12);
            Panel.SetZIndex(img13, 13);
            Panel.SetZIndex(img14, 14);
            Panel.SetZIndex(img15, 15);
            Panel.SetZIndex(img16, 16);
            if (l != null)
            {
                if (l.Name == "img1")
                {
                    currentPositionImage = _BasePoint1;
                    img1.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img1);
                    Panel.SetZIndex(img1, 17);
                }
                else if (l.Name == "img2")
                {
                    currentPositionImage = _BasePoint2;
                    img2.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img2);
                    Panel.SetZIndex(img2, 17);
                }
                else if (l.Name == "img3")
                {
                    currentPositionImage = _BasePoint3;
                    img3.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img3);
                    Panel.SetZIndex(img3, 17);
                }
                else if (l.Name == "img4")
                {
                    currentPositionImage = _BasePoint4;
                    img4.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img4);
                    Panel.SetZIndex(img4, 17);
                }
                else if (l.Name == "img5")
                {
                    currentPositionImage = _BasePoint5;
                    img5.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img5);
                    Panel.SetZIndex(img5, 17);
                }
                else if (l.Name == "img6")
                {
                    currentPositionImage = _BasePoint6;
                    img6.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img6);
                    Panel.SetZIndex(img6, 17);
                }
                else if (l.Name == "img7")
                {
                    currentPositionImage = _BasePoint7;
                    img7.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img7);
                    Panel.SetZIndex(img7, 17);
                }
                else if (l.Name == "img8")
                {
                    currentPositionImage = _BasePoint8;
                    img8.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img8);
                    Panel.SetZIndex(img8, 17);
                }
                else if (l.Name == "img9")
                {
                    currentPositionImage = _BasePoint9;
                    img9.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img9);
                    Panel.SetZIndex(img9, 17);
                }
                else if (l.Name == "img10")
                {
                    currentPositionImage = _BasePoint10;
                    img10.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img10);
                    Panel.SetZIndex(img10, 17);
                }
                else if (l.Name == "img11")
                {
                    currentPositionImage = _BasePoint11;
                    img11.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img11);
                    Panel.SetZIndex(img11, 17);
                }
                else if (l.Name == "img12")
                {
                    currentPositionImage = _BasePoint12;
                    img12.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img12);
                    Panel.SetZIndex(img12, 17);
                }
                else if (l.Name == "img13")
                {
                    currentPositionImage = _BasePoint13;
                    img13.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img13);
                    Panel.SetZIndex(img13, 17);
                }
                else if (l.Name == "img14")
                {
                    currentPositionImage = _BasePoint14;
                    img14.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img14);
                    Panel.SetZIndex(img14, 17);
                }
                else if (l.Name == "img15")
                {
                    currentPositionImage = _BasePoint15;
                    img15.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img15);
                    Panel.SetZIndex(img15, 17);
                }
                else if (l.Name == "img16")
                {
                    currentPositionImage = _BasePoint16;
                    img16.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img16);
                    Panel.SetZIndex(img16, 17);
                }
            }
        }
        private void Feast_MouseUp(object sender, MouseButtonEventArgs e)
        {
            int temp = 0;
            Image l = e.Source as Image;
            if (l != null)
            {
                if (l.Name == "img1")
                {
                    temp = 1;
                    MouseUpImage(_BasePoint1, img1);
                    LocationImage(_BasePoint1);
                    _BasePoint1 = pointtemp;
                    img1.ReleaseMouseCapture();


                }
                else if (l.Name == "img2")
                {
                    temp = 2;
                    MouseUpImage(_BasePoint2, img2);
                    LocationImage(_BasePoint2);
                    _BasePoint2 = pointtemp;
                    img2.ReleaseMouseCapture();
                }
                else if (l.Name == "img3")
                {
                    temp = 3;
                    MouseUpImage(_BasePoint3, img3);
                    LocationImage(_BasePoint3);
                    _BasePoint3 = pointtemp;
                    img3.ReleaseMouseCapture();
                }
                else if (l.Name == "img4")
                {
                    temp = 4;
                    MouseUpImage(_BasePoint4, img4);
                    LocationImage(_BasePoint4);
                    _BasePoint4 = pointtemp;
                    img4.ReleaseMouseCapture();
                }
                else if (l.Name == "img5")
                {
                    temp = 5;
                    MouseUpImage(_BasePoint5, img5);
                    LocationImage(_BasePoint5);
                    _BasePoint5 = pointtemp;
                    img5.ReleaseMouseCapture();
                }
                else if (l.Name == "img6")
                {
                    temp = 6;
                    MouseUpImage(_BasePoint6, img6);
                    LocationImage(_BasePoint6);
                    _BasePoint6 = pointtemp;
                    img6.ReleaseMouseCapture();
                }
                else if (l.Name == "img7")
                {
                    temp = 7;
                    MouseUpImage(_BasePoint7, img7);
                    LocationImage(_BasePoint7);
                    _BasePoint7 = pointtemp;
                    img7.ReleaseMouseCapture();
                }
                else if (l.Name == "img8")
                {
                    temp = 8;
                    MouseUpImage(_BasePoint8, img8);
                    LocationImage(_BasePoint8);
                    _BasePoint8 = pointtemp;
                    img8.ReleaseMouseCapture();
                }
                else if (l.Name == "img9")
                {
                    temp = 9;
                    MouseUpImage(_BasePoint9, img9);
                    LocationImage(_BasePoint9);
                    _BasePoint9 = pointtemp;
                    img9.ReleaseMouseCapture();
                }
                else if (l.Name == "img10")
                {
                    temp = 10;
                    MouseUpImage(_BasePoint10, img10);
                    LocationImage(_BasePoint10);
                    _BasePoint10 = pointtemp;
                    img10.ReleaseMouseCapture();
                }
                else if (l.Name == "img11")
                {
                    temp = 11;
                    MouseUpImage(_BasePoint11, img11);
                    LocationImage(_BasePoint11);
                    _BasePoint11 = pointtemp;
                    img11.ReleaseMouseCapture();
                }
                else if (l.Name == "img12")
                {
                    temp = 12;
                    MouseUpImage(_BasePoint12, img12);
                    LocationImage(_BasePoint12);
                    _BasePoint12 = pointtemp;
                    img12.ReleaseMouseCapture();
                }
                else if (l.Name == "img13")
                {
                    temp = 13;
                    MouseUpImage(_BasePoint13, img13);
                    LocationImage(_BasePoint13);
                    _BasePoint13 = pointtemp;
                    img13.ReleaseMouseCapture();
                }
                else if (l.Name == "img14")
                {
                    temp = 14;
                    MouseUpImage(_BasePoint14, img14);
                    LocationImage(_BasePoint14);
                    _BasePoint14 = pointtemp;
                    img14.ReleaseMouseCapture();
                }
                else if (l.Name == "img15")
                {
                    temp = 15;
                    MouseUpImage(_BasePoint15, img15);
                    LocationImage(_BasePoint15);
                    _BasePoint15 = pointtemp;
                    img15.ReleaseMouseCapture();
                }
                else if (l.Name == "img16")
                {
                    temp = 16;
                    MouseUpImage(_BasePoint16, img16);
                    LocationImage(_BasePoint16);
                    _BasePoint16 = pointtemp;
                    img16.ReleaseMouseCapture();
                }

                PropertyChange(temp);
                if (checkWin())
                {
                    shadow1.Opacity = 0;
                    shadow2.Opacity = 0;
                    shadow3.Opacity = 0;
                    shadow4.Opacity = 0;
                    shadow5.Opacity = 0;
                    shadow6.Opacity = 0;
                    shadow7.Opacity = 0;
                    shadow8.Opacity = 0;
                    shadow9.Opacity = 0;
                    shadow10.Opacity = 0;
                    shadow11.Opacity = 0;
                    shadow12.Opacity = 0;
                    shadow13.Opacity = 0;
                    shadow14.Opacity = 0;
                    shadow15.Opacity = 0;
                    shadow16.Opacity = 0;
                    MessageBox.Show("Win");
                }
            }
        }
        private void Feast_MouseMove(object sender, MouseEventArgs e)
        {
            int temp = 0;
            Image l = e.Source as Image;
            if (moving)
            {
                if (l.Name == "img1")
                {
                    temp = 1;
                    MouseMoveImage(_BasePoint1, e);
                    _BasePoint1 = pointtemp;

                }
                else if (l.Name == "img2")
                {
                    temp = 2;
                    MouseMoveImage(_BasePoint2, e);
                    _BasePoint2 = pointtemp;
                }
                else if (l.Name == "img3")
                {
                    temp = 3;
                    MouseMoveImage(_BasePoint3, e);
                    _BasePoint3 = pointtemp;
                }
                else if (l.Name == "img4")
                {
                    temp = 4;
                    MouseMoveImage(_BasePoint4, e);
                    _BasePoint4 = pointtemp;
                }
                else if (l.Name == "img5")
                {
                    temp = 5;
                    MouseMoveImage(_BasePoint5, e);
                    _BasePoint5 = pointtemp;
                }
                else if (l.Name == "img6")
                {
                    temp = 6;
                    MouseMoveImage(_BasePoint6, e);
                    _BasePoint6 = pointtemp;
                }
                else if (l.Name == "img7")
                {
                    temp = 7;
                    MouseMoveImage(_BasePoint7, e);
                    _BasePoint7 = pointtemp;
                }
                else if (l.Name == "img8")
                {
                    temp = 8;
                    MouseMoveImage(_BasePoint8, e);
                    _BasePoint8 = pointtemp;
                }
                else if (l.Name == "img9")
                {
                    temp = 9;
                    MouseMoveImage(_BasePoint9, e);
                    _BasePoint9 = pointtemp;
                }
                else if (l.Name == "img10")
                {
                    temp = 10;
                    MouseMoveImage(_BasePoint10, e);
                    _BasePoint10 = pointtemp;
                }
                else if (l.Name == "img11")
                {
                    temp = 11;
                    MouseMoveImage(_BasePoint11, e);
                    _BasePoint11 = pointtemp;
                }
                else if (l.Name == "img12")
                {
                    temp = 12;
                    MouseMoveImage(_BasePoint12, e);
                    _BasePoint12 = pointtemp;
                }
                else if (l.Name == "img13")
                {
                    temp = 13;
                    MouseMoveImage(_BasePoint13, e);
                    _BasePoint13 = pointtemp;
                }
                else if (l.Name == "img14")
                {
                    temp = 14;
                    MouseMoveImage(_BasePoint14, e);
                    _BasePoint14 = pointtemp;
                }
                else if (l.Name == "img15")
                {
                    temp = 15;
                    MouseMoveImage(_BasePoint15, e);
                    _BasePoint15 = pointtemp;
                }
                else if (l.Name == "img16")
                {
                    temp = 16;
                    MouseMoveImage(_BasePoint16, e);
                    _BasePoint16 = pointtemp;
                }
                PropertyChange(temp);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private void InitBoard()
        {
            Board = new int[4, 4];
            int c = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Board[i, j] = c++;
                    if (c > 16) c = 0;
                }
            }
        }
        private void DrawBord()
        {
            cnBoard.Children.Clear();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Board[i, j] > 0)
                    {
                        UserControl1 cnv = new UserControl1
                        {
                            Width = cnBoard.Width / 4,
                            Height = cnBoard.Height / 4

                        };
                        Canvas.SetTop(cnv, i * cnBoard.Width / 4);
                        Canvas.SetLeft(cnv, j * cnBoard.Width / 4);
                        cnBoard.Children.Add(cnv);
                    }
                }
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DrawBord();
        }
        private void PropertyChange(int i)
        {
            RaisePropertyChanged("XPosition" + i);
            RaisePropertyChanged("YPosition" + i);
        }
        private void MouseUpImage(Point point, Image image)
        {

            var x = point.X + DeltaX;
            var y = point.Y + DeltaY;
            point = new Point(x, y);
            pointtemp = point;
            DeltaX = 0.0;
            DeltaY = 0.0;
            moving = false;
        }
        private void MouseMoveImage(Point point, MouseEventArgs e)
        {
            Point p = e.GetPosition(null);
            DeltaX = p.X - point.X - PositionInImage.X;
            DeltaY = p.Y - point.Y - PositionInImage.Y;
            var x = point.X + DeltaX;
            var y = point.Y + DeltaY;
            point = new Point(x, y);
            pointtemp = point;
        }
        private void LocationImage(Point point)
        {
            int count = 0;
            var lstX = new List<Point>(16);
            Point p = new Point();
            for (int i = 0; i < 4;)
            {
                if (count == 16)
                {
                    break;
                }
                for (int j = 0; j < 4; j++)
                {
                    p.X = i * 110 + j * 110;
                    p.Y = j * 110 + 110;
                    lstX.Add(p);
                    count++;
                }
            }
            var lstY = new List<Point>(16);
            int count1 = 0;
            for (int i = 0; i < 4; i++)
            {
                if (count1 == 16)
                {
                    break;
                }
                for (int j = 0; j < 4; j++)
                {
                    p.X = i * 110;
                    p.Y = i * 110 + 110;
                    lstY.Add(p);
                    count1++;
                }
            }
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            int x1 = (int)(point.X) + 55 - (int)(screenWidth - 440) / 2;
            int y1 = (int)(point.Y) + 55 - (int)(screenHeight - 440) / 2;
            if ((x1 > lstX[0].X && x1 <= lstX[0].Y) && (y1 > lstY[0].X && y1 <= lstY[0].Y))
            {
                point = new Point(list[0].X, list[0].Y);
                checkDuplicate(point);
                pointtemp = point;
            }
            else if ((x1 > lstX[1].X && x1 <= lstX[1].Y) && (y1 > lstY[1].X && y1 <= lstY[1].Y))
            {
                point = new Point(list[1].X, list[1].Y);
                checkDuplicate(point);
                pointtemp = point;
            }
            else if ((x1 > lstX[2].X && x1 <= lstX[2].Y) && (y1 > lstY[2].X && y1 <= lstY[2].Y))
            {
                point = new Point(list[2].X, list[2].Y);
                checkDuplicate(point);
                pointtemp = point;
            }
            else if ((x1 > lstX[3].X && x1 <= lstX[3].Y) && (y1 > lstY[3].X && y1 <= lstY[3].Y))
            {
                point = new Point(list[3].X, list[3].Y);
                checkDuplicate(point);
                pointtemp = point;
            }
            else if ((x1 > lstX[4].X && x1 <= lstX[4].Y) && (y1 > lstY[4].X && y1 <= lstY[4].Y))
            {
                point = new Point(list[4].X, list[4].Y);
                checkDuplicate(point);
                pointtemp = point;
            }
            else if ((x1 > lstX[5].X && x1 <= lstX[5].Y) && (y1 > lstY[5].X && y1 <= lstY[5].Y))
            {
                point = new Point(list[5].X, list[5].Y);
                checkDuplicate(point);
                pointtemp = point;
            }
            else if ((x1 > lstX[6].X && x1 <= lstX[6].Y) && (y1 > lstY[6].X && y1 <= lstY[6].Y))
            {
                point = new Point(list[6].X, list[6].Y);
                checkDuplicate(point);
                pointtemp = point;
            }
            else if ((x1 > lstX[7].X && x1 <= lstX[7].Y) && (y1 > lstY[7].X && y1 <= lstY[7].Y))
            {
                point = new Point(list[7].X, list[7].Y);
                checkDuplicate(point);
                pointtemp = point;
            }
            else if ((x1 > lstX[8].X && x1 <= lstX[8].Y) && (y1 > lstY[8].X && y1 <= lstY[8].Y))
            {
                point = new Point(list[8].X, list[8].Y);
                checkDuplicate(point);
                pointtemp = point;
            }
            else if ((x1 > lstX[9].X && x1 <= lstX[9].Y) && (y1 > lstY[9].X && y1 <= lstY[9].Y))
            {
                point = new Point(list[9].X, list[9].Y);
                checkDuplicate(point);
                pointtemp = point;
            }
            else if ((x1 > lstX[10].X && x1 <= lstX[10].Y) && (y1 > lstY[10].X && y1 <= lstY[10].Y))
            {
                point = new Point(list[10].X, list[10].Y);
                checkDuplicate(point);
                pointtemp = point;
            }
            else if ((x1 > lstX[11].X && x1 <= lstX[11].Y) && (y1 > lstY[11].X && y1 <= lstY[11].Y))
            {
                point = new Point(list[11].X, list[11].Y);
                checkDuplicate(point);
                pointtemp = point;
            }
            else if ((x1 > lstX[12].X && x1 <= lstX[12].Y) && (y1 > lstY[12].X && y1 <= lstY[12].Y))
            {
                point = new Point(list[12].X, list[12].Y);
                checkDuplicate(point);
                pointtemp = point;
            }
            else if ((x1 > lstX[13].X && x1 <= lstX[13].Y) && (y1 > lstY[13].X && y1 <= lstY[13].Y))
            {
                point = new Point(list[13].X, list[13].Y);
                checkDuplicate(point);
                pointtemp = point;
            }
            else if ((x1 > lstX[14].X && x1 <= lstX[14].Y) && (y1 > lstY[14].X && y1 <= lstY[14].Y))
            {
                point = new Point(list[14].X, list[14].Y);
                checkDuplicate(point);
                pointtemp = point;
            }
            else if ((x1 > lstX[15].X && x1 <= lstX[15].Y) && (y1 > lstY[15].X && y1 <= lstY[15].Y))
            {
                point = new Point(list[15].X, list[15].Y);
                checkDuplicate(point);
                pointtemp = point;
            }

        }
        private bool checkWin()
        {
            List<Point> listPointTemp = new List<Point>(16);
            var lst = this.GetType().GetProperties();
            foreach (var prop in lst)
            {
                if (prop.PropertyType.Name == typeof(Point).Name && prop.Name.Contains("_BasePoint"))
                {
                    Point value = (Point)prop.GetValue(this, null);
                    listPointTemp.Add(value);
                }
            }
            bool k = true;
            for (int i = 0; i < 16; i++)
            {
                if (listPointTemp[i] != list[i])
                {
                    k = false;
                }
            }
            return k;
        }
        private void RanDomImage()
        {
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            List<Point> points = new List<Point>();
            Point point = new Point();
            int xWidth = ((int)(screenWidth - 440) / 2 - 220) / 3;
            int yHeight = ((int)(screenHeight - 440) / 5);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    point.X = (j + 1) * xWidth + j * 110;
                    point.Y = (i + 1) * yHeight + i * 110;
                    points.Add(point);
                }
            }

            int xWidth1 = xWidth * 3 + 220 + 440;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    point.X = (j + 1) * xWidth + xWidth1 + j * 110;
                    point.Y = (i + 1) * yHeight + i * 110;
                    points.Add(point);
                }
            }
            Random rd = new Random();
            int n = points.Count;
            while (n > 1)
            {
                n--;
                int k = rd.Next(n + 1);
                Point value = points[k];
                points[k] = points[n];
                points[n] = value;
            }
            var temp = 0;
            var lst = this.GetType().GetProperties();
            foreach (var prop in lst)
            {
                if (prop.PropertyType.Name == typeof(Point).Name && prop.Name.Contains("_BasePoint"))
                {
                    var value = prop.GetValue(this, null);
                    prop.SetValue(this, points[temp], null);
                    temp++;
                }
            }
            for (int i = 1; i < 17; i++)
            {
                RaisePropertyChanged("XPosition" + i);
                RaisePropertyChanged("YPosition" + i);
            }

        }

        private void checkDuplicate(Point point)
        {
            var lst = this.GetType().GetProperties();
            foreach (var prop in lst)
            {
                if (prop.PropertyType.Name == typeof(Point).Name && prop.Name.Contains("_BasePoint"))
                {
                    Point value = (Point)prop.GetValue(this, null);
                    if (value == point)
                    {
                        value = currentPositionImage;
                        prop.SetValue(this, value, null);
                        break;
                    }
                }
            }
            for (int i = 1; i < 17; i++)
            {
                RaisePropertyChanged("XPosition" + i);
                RaisePropertyChanged("YPosition" + i);
            }
        }

        private void getHint(object sender, RoutedEventArgs e)
        {

        }

        private void rePlay(object sender, RoutedEventArgs e)
        {
            RanDomImage();
            shadow1.Opacity = 100;
            shadow2.Opacity = 100;
            shadow3.Opacity = 100;
            shadow4.Opacity = 100;
            shadow5.Opacity = 100;
            shadow6.Opacity = 100;
            shadow7.Opacity = 100;
            shadow8.Opacity = 100;
            shadow9.Opacity = 100;
            shadow10.Opacity = 100;
            shadow11.Opacity = 100;
            shadow12.Opacity = 100;
            shadow13.Opacity = 100;
            shadow14.Opacity = 100;
            shadow15.Opacity = 100;
            shadow16.Opacity = 100;
        }



        private void Pause1_Click(object sender, RoutedEventArgs e)
        {
            Pause1.Visibility = Visibility.Collapsed;
            Resume1.Visibility = Visibility.Visible;
            canvas1.IsEnabled = false;
            canvas1.Focusable = false;
        }

        private void Resume1_Click(object sender, RoutedEventArgs e)
        {
            Resume1.Visibility = Visibility.Collapsed;
            Pause1.Visibility = Visibility.Visible;
            canvas1.IsEnabled = true;
            canvas1.Focusable = true;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            Countdown.Stop(this);
            Countdown.Remove(this);
        }
    }
}
