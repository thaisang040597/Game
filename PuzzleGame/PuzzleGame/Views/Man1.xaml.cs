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

namespace PuzzleGame.Views
{
    /// <summary>
    /// Interaction logic for Man1.xaml
    /// </summary>
    public partial class Man1 : UserControl, INotifyPropertyChanged
    {
        private Point BasePoint = new Point(200.0, 0.0);
        private double DeltaX = 0.0;
        private double DeltaY = 0.0;
        private bool moving = false;
        private Point PositionInLabel;
        private static bool gaucho = false;
        private int temp = 0;
        MediaPlayer playMedia = new MediaPlayer();

        public Man1()
        {
            InitializeComponent();
            this.DataContext = this;
      
           

        }

       

        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            gaucho = false;
        }
        

        public double XPosition
        {
            get { return BasePoint.X + DeltaX; }
        }

        public double YPosition
        {
            get { return BasePoint.Y + DeltaY; }
        }
       
        private void Feast_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image l = e.Source as Image;
            if (l != null)
            {
                if (gaucho == true)
                {
                    return;
                }
                else if (l.Name == "gau2")
                {
                    gau2.CaptureMouse();
                    moving = true;
                    PositionInLabel = e.GetPosition(l);
                    
                }
                //if (l.Name == "hinh2")
                //{
                //    hinh2.CaptureMouse();
                //    moving = true;
                //    PositionInLabel = e.GetPosition(l);
                //}
            }
        }

        private void Feast_MouseMove(object sender, MouseEventArgs e)
        {
            double x = Canvas.GetLeft(gau1);
            double y = Canvas.GetTop(gau1);
            Image l = e.Source as Image;
            if (moving)
            {
                if (l.Name == "gau2")
                {
                    Point p = e.GetPosition(null);
                    DeltaX = p.X - BasePoint.X - PositionInLabel.X;
                    DeltaY = p.Y - BasePoint.Y - PositionInLabel.Y;
                    BasePoint.X += DeltaX;
                    BasePoint.Y += DeltaY;
                    RaisePropertyChanged("XPosition");
                    RaisePropertyChanged("YPosition");
                    if ((((BasePoint.X - 50) < x) && (BasePoint.X + 50) > x) && (((BasePoint.Y - 50) < y) && ((BasePoint.Y + 50) > y)))
                    {
                        gau.Visibility = Visibility.Visible;
                        gau1.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        gau.Visibility = Visibility.Hidden;
                        gau1.Visibility = Visibility.Visible;
                    }
                    
                }
                
                //if (l.Name == "hinh2")
                //{
                //    Point p = e.GetPosition(null);
                //    DeltaX = p.X - BasePoint1.X - PositionInLabel.X;
                //    DeltaY = p.Y - BasePoint1.Y - PositionInLabel.Y;
                //    RaisePropertyChanged("XPosition1");
                //    RaisePropertyChanged("YPosition1");
                //}
            }
        }

       
        private void Feast_MouseUp(object sender, MouseButtonEventArgs e)
        {
            //DispatcherTimer playlistTimer = new DispatcherTimer();

            //playlistTimer.Interval = new TimeSpan(0, 0, 5);

           
            double x = Canvas.GetLeft(gau1);
            double y = Canvas.GetTop(gau1);
            Image l = e.Source as Image;
            if (l != null)
            {
                if (l.Name == "gau2")
                {
                    gau2.ReleaseMouseCapture();
                    BasePoint.X += DeltaX;
                    BasePoint.Y += DeltaY;
                    DeltaX = 0.0;
                    DeltaY = 0.0;
                    moving = false;
                    if ((((BasePoint.X - 50) < x) && (BasePoint.X + 50) > x) && (((BasePoint.Y - 50) < y) && ((BasePoint.Y + 50) > y)))
                    {
                        BasePoint.X = x;
                        BasePoint.Y = y;
                        RaisePropertyChanged("XPosition");
                        RaisePropertyChanged("YPosition");
                        gau.Visibility = Visibility.Hidden;
                        hoa.Visibility = Visibility.Visible;
                        
                        gaucho = true;
                        temp++;
                    }
                }
                //if (l.Name == "hinh2")
                //{
                //    hinh2.ReleaseMouseCapture();
                //    double a = BasePoint1.X;
                //    double b = BasePoint1.Y;
                //    BasePoint1.X += DeltaX;
                //    BasePoint1.Y += DeltaY;
                //    DeltaX = 0.0;
                //    DeltaY = 0.0;
                //    moving = false;
                //    if ((((BasePoint1.X - 100) < x) && (BasePoint1.X + 100) > x) && (((BasePoint1.Y - 100) < y) && ((BasePoint1.Y + 100) > y)))
                //    {
                //        BasePoint1.X = a;
                //        BasePoint1.Y = b;
                //        RaisePropertyChanged("XPosition1");
                //        RaisePropertyChanged("YPosition1");
                //    }



                //}


            }
            if(temp ==1)
            {
                
                report.Visibility = Visibility.Visible;
                Uri uri = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/Ilikeme.wav"); // "/PuzzleGame;component/Sound/Ilikeme.wav", UriKind.Relative, browsing to the sound folder and then the WAV file location
                playMedia.Open(uri); // inserting the URI to the media player
                playMedia.Play();

            }
           

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
             
           
        }







        //private void myGif_MediaEnded(object sender, RoutedEventArgs e)
        //{
        //    myGif.Position = new TimeSpan(0, 0, 1);
        //    myGif.Play();
        //}
    }

}
