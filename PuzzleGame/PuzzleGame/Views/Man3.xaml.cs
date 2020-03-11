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

namespace PuzzleGame.Views
{
    /// <summary>
    /// Interaction logic for Man3.xaml
    /// </summary>
    public partial class Man3 : UserControl, INotifyPropertyChanged
    {

        private Point BasePoint = new Point(1150, 700);
        private Point BasePoint1 = new Point(400, 0.0);
        private double DeltaX = 0.0;
        private double DeltaY = 0.0;
        private double DeltaX1 = 0.0;
        private double DeltaY1 = 0.0;
        private bool moving = false;
        private Point PositionImage;
        private static bool chua = false;
        private static bool carot = false;//không cho chọn khi đúng hình;
        private bool replay = false;
        private int temp = 0;
        public Man3()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public double XPosition
        {
            get { return BasePoint.X + DeltaX; }
        }

        public double YPosition
        {
            get { return BasePoint.Y + DeltaY; }
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }

        private void Feast_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image l = e.Source as Image;
            if (l != null)
            {
                //bantay.Visibility = Visibility.Hidden;
                if (l.Name == "a" && chua == false)
                {
                    a.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(a);
                    //bantay1.Visibility = Visibility.Visible;

                }
                //if (l.Name == "carrot" && carot == false)
                //{
                //    carrot.CaptureMouse();
                //    moving = true;
                //    PositionImage = e.GetPosition(carrot);
                //}
                //playMedia.Stop();



            }
        }

        private void Feast_MouseUp(object sender, MouseButtonEventArgs e)
        {
            double m = Canvas.GetLeft(a1);
            double n = Canvas.GetTop(a1);
            //double x = Canvas.GetLeft(gau);
            //double y = Canvas.GetTop(gau);
            Image l = e.Source as Image;
            if (l != null)
            {
                if (l.Name == "a")
                {
                    a.ReleaseMouseCapture();
                    BasePoint.X += DeltaX;
                    BasePoint.Y += DeltaY;
                    DeltaX = 0.0;
                    DeltaY = 0.0;
                    moving = false;
                    //if ((((BasePoint.X - 10) < m) && (BasePoint.X + 10) > m) && (((BasePoint.Y - 10) < n) && ((BasePoint.Y + 10) > n)))
                    //{
                    //    BasePoint.X = m;
                    //    BasePoint.Y = n;
                    //    RaisePropertyChanged("XPosition");
                    //    RaisePropertyChanged("YPosition");
                    //    //gau.Visibility = Visibility.Hidden;
                    //    //hoa.Visibility = Visibility.Visible;
                    //    chua = true;
                    //    //Uri ting = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/Gaukeu.mp3");
                    //    //playMedia.Open(ting);
                    //    //playMedia.Play();
                    //    //bantay1.Visibility = Visibility.Hidden;

                    //}
                }
                //if (l.Name == "carrot")
                //{
                //    carrot.ReleaseMouseCapture();
                //    BasePoint1.X += DeltaX1;
                //    BasePoint1.Y += DeltaY1;
                //    DeltaX1 = 0.0;
                //    DeltaY1 = 0.0;
                //    moving = false;
                //    if ((((BasePoint1.X - 100) < m) && (BasePoint1.X + 100) > m) && (((BasePoint1.Y - 80) < n) && ((BasePoint1.Y + 100) > n)))
                //    {
                //        BasePoint1.X = m + 65;
                //        BasePoint1.Y = n + 45;
                //        RaisePropertyChanged("XPosition1");
                //        RaisePropertyChanged("YPosition1");

                //        carot = true;
                //        Uri ting = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/thokeu.mp3");
                //        playMedia.Open(ting);
                //        playMedia.Play();

                //    }
                //}



            }
        }

        private void Feast_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                Image l = e.Source as Image;
                if (l.Name == "a")
                {
                    Point p = e.GetPosition(null);
                    DeltaX = p.X - BasePoint.X - PositionImage.X;
                    DeltaY = p.Y - (BasePoint.Y-650) - PositionImage.Y;
                    BasePoint.X += DeltaX;
                    BasePoint.Y += DeltaY;
                    RaisePropertyChanged("XPosition");
                    RaisePropertyChanged("YPosition");


                }
                //if (l.Name == "carrot")
                //{
                //    Point p = e.GetPosition(null);
                //    DeltaX1 = p.X - BasePoint1.X - PositionImage.X;
                //    DeltaY1 = p.Y - BasePoint1.Y - PositionImage.Y;
                //    BasePoint1.X += DeltaX1;
                //    BasePoint1.Y += DeltaY1;
                //    RaisePropertyChanged("XPosition1");
                //    RaisePropertyChanged("YPosition1");
                //    //    if ((((BasePoint1.X - 50) < m) && (BasePoint1.X + 50) > m) && (((BasePoint1.Y - 50) < n) && ((BasePoint1.Y + 50) > n)))
                //    //    {
                //    //        ho1.Visibility = Visibility.Visible;
                //    //        ho.Visibility = Visibility.Hidden;
                //    //    }
                //    //    else
                //    //    {
                //    //        ho1.Visibility = Visibility.Hidden;
                //    //        ho.Visibility = Visibility.Visible;
                //    //    }

                //}


            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
