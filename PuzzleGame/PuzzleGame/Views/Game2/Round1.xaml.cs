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
using System.Windows.Threading;

namespace PuzzleGame.Views.Game2
{
    /// <summary>
    /// Interaction logic for Round1.xaml
    /// </summary>
    public partial class Round1 : UserControl , INotifyPropertyChanged
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
        public static Point pointtemp;
        MediaPlayer playMedia = new MediaPlayer();
        private static Point currentPositionImage;
        private double DeltaX = 0.0;
        private double DeltaY = 0.0;
        private bool moving = false;
        private static Point PositionInImage;
        public static bool flat = true;
      
       
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

        static int x = 0;
        static int y = 300;
        static int z = 600;
        public Int32Rect Pieces1 { get { return new Int32Rect(x, x, 300, 300); } }
        public Int32Rect Pieces2 { get { return new Int32Rect(y, x, 300, 300); } }
        public Int32Rect Pieces3 { get { return new Int32Rect(z, x, 300, 300); } }
        public Int32Rect Pieces4 { get { return new Int32Rect(x, y, 300, 300); } }
        public Int32Rect Pieces5 { get { return new Int32Rect(y, y, 300, 300); } }
        public Int32Rect Pieces6 { get { return new Int32Rect(z, y, 300, 300); } }
        public Int32Rect Pieces7 { get { return new Int32Rect(x, z, 300, 300); } }
        public Int32Rect Pieces8 { get { return new Int32Rect(y, z, 300, 300); } }
        public Int32Rect Pieces9 { get { return new Int32Rect(z, z, 300, 300); } }
        public Round1()
        {
           
            this.DataContext = this;
            InitializeComponent();
            InitBoard();
            CreatePositionImage();
            RanDomImage();
        }


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
            list = new List<Point>(9);
            list.Add(_BasePoint1);
            list.Add(_BasePoint2);
            list.Add(_BasePoint3);
            list.Add(_BasePoint4);
            list.Add(_BasePoint5);
            list.Add(_BasePoint6);
            list.Add(_BasePoint7);
            list.Add(_BasePoint8);
            list.Add(_BasePoint9);
            var points = list.ToArray();
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    points[count].Y = (screenHeight - 450) / 2 + 150 * i;
                    points[count].X = (screenWidth - 450) / 2 + 150 * j;
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
            for (int i = 1; i < 10; i++)
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
            Panel.SetZIndex(voi, 8);
            Panel.SetZIndex(img9, 9);
            if (l != null)
            {
                if (l.Name == "img1")
                {
                    currentPositionImage = _BasePoint1;
                    img1.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img1);
                    Panel.SetZIndex(img1, 10);
                }
                else if (l.Name == "img2")
                {
                    currentPositionImage = _BasePoint2;
                    img2.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img2);
                    Panel.SetZIndex(img2, 10);
                }
                else if (l.Name == "img3")
                {
                    currentPositionImage = _BasePoint3;
                    img3.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img3);
                    Panel.SetZIndex(img3, 10);
                }
                else if (l.Name == "img4")
                {
                    currentPositionImage = _BasePoint4;
                    img4.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img4);
                    Panel.SetZIndex(img4, 10);
                }
                else if (l.Name == "img5")
                {
                    currentPositionImage = _BasePoint5;
                    img5.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img5);
                    Panel.SetZIndex(img5, 10);
                }
                else if (l.Name == "img6")
                {
                    currentPositionImage = _BasePoint6;
                    img6.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img6);
                    Panel.SetZIndex(img6, 10);
                }
                else if (l.Name == "img7")
                {
                    currentPositionImage = _BasePoint7;
                    img7.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img7);
                    Panel.SetZIndex(img7, 10);
                }
                else if (l.Name == "voi")
                {
                    currentPositionImage = _BasePoint8;
                    voi.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(voi);
                    Panel.SetZIndex(voi, 10);
                }
                else if (l.Name == "img9")
                {
                    currentPositionImage = _BasePoint9;
                    img9.CaptureMouse();
                    moving = true;
                    PositionInImage = e.GetPosition(img9);
                    Panel.SetZIndex(img9, 10);
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
                else if (l.Name == "voi")
                {
                    temp = 8;
                    MouseUpImage(_BasePoint8, voi);
                    LocationImage(_BasePoint8);
                    _BasePoint8 = pointtemp;
                    voi.ReleaseMouseCapture();
                }
                else if (l.Name == "img9")
                {
                    temp = 9;
                    MouseUpImage(_BasePoint9, img9);
                    LocationImage(_BasePoint9);
                    _BasePoint9 = pointtemp;
                    img9.ReleaseMouseCapture();
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
                    report.Visibility = Visibility.Visible;
                    Uri uri = new Uri(@"..\..\..\Sound\chucmung.mp3", UriKind.Relative); // "/PuzzleGame;component/Sound/Ilikeme.wav", UriKind.Relative, browsing to the sound folder and then the WAV file location
                    playMedia.Open(uri); // inserting the URI to the media player
                    playMedia.Play();
                    UCWin uCWin = new UCWin();
                    uc.Children.Add(uCWin);
                    //Countdown.Stop(this);
                    //Countdown.Remove(this);
                    //MessageBox.Show("Win");   
                    //checkwin nè kk thieu border thong bao;

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
                else if (l.Name == "voi")
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
            Board = new int[3, 3];
            int c = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Board[i, j] = c++;
                    if (c > 9) c = 0;
                }
            }
        }
        private void DrawBord()
        {
            cnBoard.Children.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Board[i, j] > 0)
                    {
                        UserControl1 cnv = new UserControl1
                        {
                            Width = cnBoard.Width / 3,
                            Height = cnBoard.Height / 3

                        };
                        Canvas.SetTop(cnv, i * cnBoard.Width / 3);
                        Canvas.SetLeft(cnv, j * cnBoard.Width / 3);
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
            Uri uri = new Uri(@"..\..\..\Sound\Ting.mp3", UriKind.Relative);
            playMedia.Open(uri); // inserting the URI to the media player
            playMedia.Play();
            playMedia.Open(new Uri(@"..\..\Sound\Ting.mp3", UriKind.Relative));
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
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            int count = 0;
            var lstX = new List<Point>(9);
            Point p = new Point();
            for (int i = 0; i < 3;)
            {
                if (count == 9)
                {
                    break;
                }
                for (int j = 0; j < 3; j++)
                {
                    p.X = i * 150 + j * 150;
                    p.Y = j * 150 + 150;
                    lstX.Add(p);
                    count++;
                }
            }
            var lstY = new List<Point>(9);
            int count1 = 0;
            for (int i = 0; i < 3; i++)
            {
                if (count1 == 9)
                {
                    break;
                }
                for (int j = 0; j < 3; j++)
                {
                    p.X = i * 150;
                    p.Y = i * 150 + 150;
                    lstY.Add(p);
                    count1++;
                }
            }
            int x1 = (int)(point.X) + 75 - (int)(screenWidth - 450) / 2;
            int y1 = (int)(point.Y) + 75 - (int)(screenHeight - 450) / 2;

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

        }
        private bool checkWin()
        {
            List<Point> listPointTemp = new List<Point>(9);
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
            for (int i = 0; i < 9; i++)
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
            int xWidth = (int)(screenWidth - (150 * 5)) / 6;
            int yHeight = (int)(((screenHeight - 450) / 2 - 150) / 2);
            for (int i = 0; i < 5; i++)
            {
                point.X = 150 * i + (i + 1) * xWidth;
                point.Y = yHeight;
                points.Add(point);
            }
            int yHeight68 = (int)((screenHeight - (150 * 3) - yHeight) / 3);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    point.X = 150 * j + (j + 1) * xWidth + j * 150 * 3 + j * xWidth * 3;
                    point.Y = (yHeight68 + 150 + yHeight) + (150 + yHeight68) * i;
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
            for (int i = 1; i < 10; i++)
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
            for (int i = 1; i < 10; i++)
            {
                RaisePropertyChanged("XPosition" + i);
                RaisePropertyChanged("YPosition" + i);
            }
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
            report.Visibility = Visibility.Collapsed;
           
            //Countdown.Remove(this);
            
            //Countdown.Begin(this);
            //Countdown.Begin(this, true);






            //Resume1.Visibility = Visibility.Collapsed;
        }



        //private void Pause1_Click(object sender, RoutedEventArgs e)
        //{
        //    Pause1.Visibility = Visibility.Collapsed;
        //    Resume1.Visibility = Visibility.Visible;
        //    canvas1.IsEnabled = false;
        //    canvas1.Focusable = false;
        //}

        //private void Resume1_Click(object sender, RoutedEventArgs e)
        //{
        //    Resume1.Visibility = Visibility.Collapsed;
        //    Pause1.Visibility = Visibility.Visible;
        //    canvas1.IsEnabled = true;
        //    canvas1.Focusable = true;
        //}

        //private void Hint(object sender, MouseButtonEventArgs e)
        //{
        //    anhgoc.Visibility = Visibility.Collapsed;
        //}

        //private void getHint(object sender, MouseButtonEventArgs e)
        //{
        //    anhgoc.Visibility = Visibility.Visible;
        //}
        private DispatcherTimer timer;
        private int time;
        private void getHint(object sender, RoutedEventArgs e)
        {
            time = 2;
            gethint.Visibility = Visibility.Visible;
            canvas1.Opacity = 0.2;
            canvas1.IsEnabled = false;
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_tick;
            timer.Start();

        }
        void Timer_tick(object sender, EventArgs e)
        {

            if (time > 0)
            {
                time--;
            }
            else
            {
                timer.Stop();
                gethint.Visibility = Visibility.Collapsed;
                canvas1.Opacity = 1;
                canvas1.IsEnabled = true;
            }

        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            //Countdown.Stop(this);
            //Countdown.Remove(this);
        }

       
    }
}

