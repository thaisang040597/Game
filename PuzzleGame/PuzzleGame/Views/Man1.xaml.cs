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
        private Point BasePoint = new Point(200.0, 20);
        private Point BasePoint1 = new Point(400, 0.0);
        private double DeltaX = 0.0;
        private double DeltaY = 0.0;
        private double DeltaX1 = 0.0;
        private double DeltaY1 = 0.0;
        private bool moving = false;
        private Point PositionImage;
        private static bool gaucho = false;
        private static bool hovan = false;//không cho chọn khi đúng hình;
        private bool replay = false;
        //private int temp = 0;
        MediaPlayer playMedia = new MediaPlayer();
       

        public Man1()
        {
            InitializeComponent();
            this.DataContext = this;
           
           



        }



        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            
        }
        

        public double XPosition
        {
            get { return BasePoint.X + DeltaX; }
        }

        public double YPosition
        {
            get { return BasePoint.Y + DeltaY; }
        }
        public double XPosition1
        {
            get { return BasePoint1.X + DeltaX1; }
        }

        public double YPosition1
        {
            get { return BasePoint1.Y + DeltaY1; }
        }

        private void Feast_MouseDown(object sender, MouseButtonEventArgs e)
        {
          
            Image l = e.Source as Image;
            if (l != null)
            {
                bantay.Visibility = Visibility.Hidden;
                if (l.Name == "gau2" && gaucho == false)
                {
                    gau2.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(gau2);
                    bantay1.Visibility = Visibility.Visible;

                }
                if (l.Name == "ho2" && hovan == false)
                {
                    ho2.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(ho2);
                    
                }
                playMedia.Stop();
                


            }
            if(l==null)
            {
                bantay.Visibility = Visibility.Visible;
            }
        }

        private void Feast_MouseMove(object sender, MouseEventArgs e)
        {
            double x = Canvas.GetLeft(gau1);
            double y = Canvas.GetTop(gau1);
            double m = Canvas.GetLeft(ho);
            double n = Canvas.GetTop(ho);


            if (moving)
            {
                Image l = e.Source as Image;
                if (l.Name == "gau2")
                {
                    Point p = e.GetPosition(null);
                    DeltaX = p.X - BasePoint.X - PositionImage.X;
                    DeltaY = p.Y - BasePoint.Y - PositionImage.Y;
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
                if (l.Name == "ho2")
                {
                    Point p = e.GetPosition(null);
                    DeltaX1 = p.X - BasePoint1.X - PositionImage.X;
                    DeltaY1 = p.Y - BasePoint1.Y - PositionImage.Y;
                    BasePoint1.X += DeltaX1;
                    BasePoint1.Y += DeltaY1;
                    RaisePropertyChanged("XPosition1");
                    RaisePropertyChanged("YPosition1");
                    if ((((BasePoint1.X - 50) < m) && (BasePoint1.X + 50) > m) && (((BasePoint1.Y - 50) < n) && ((BasePoint1.Y + 50) > n)))
                    {
                        ho1.Visibility = Visibility.Visible;
                        ho.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        ho1.Visibility = Visibility.Hidden;
                        ho.Visibility = Visibility.Visible;
                    }

                }


            }
        }

       
        private void Feast_MouseUp(object sender, MouseButtonEventArgs e)
        {
            //DispatcherTimer playlistTimer = new DispatcherTimer();

            //playlistTimer.Interval = new TimeSpan(0, 0, 5);
            Uri ting = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/Ting.mp3"); // "/PuzzleGame;component/Sound/Ilikeme.wav", UriKind.Relative, browsing to the sound folder and then the WAV file location
            // inserting the URI to the media player
         
            double m = Canvas.GetLeft(ho);
            double n = Canvas.GetTop(ho);
            double x = Canvas.GetLeft(gau1);
            double y = Canvas.GetTop(gau1);
            Image l = e.Source as Image;
            if (l != null)
            {
                if (l.Name == "gau2")
                {
                    bantay1.Visibility = Visibility.Collapsed;
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
                        
                        playMedia.Open(ting);
                        playMedia.Play();

                        bantay1.Visibility = Visibility.Hidden;
                        
                    
                    }
                }
                if(l.Name == "ho2")
                {
                    ho2.ReleaseMouseCapture();
                    BasePoint1.X += DeltaX1;
                    BasePoint1.Y += DeltaY1;
                    DeltaX1 = 0.0;
                    DeltaY1 = 0.0;
                    moving = false;
                    if ((((BasePoint1.X - 50) < m) && (BasePoint1.X + 50) > m) && (((BasePoint1.Y - 50) < n) && ((BasePoint1.Y + 50) > n)))
                    {
                        BasePoint1.X = m;
                        BasePoint1.Y = n;
                        RaisePropertyChanged("XPosition1");
                        RaisePropertyChanged("YPosition1");
                        ho1.Visibility = Visibility.Hidden;
                        ho2.Visibility = Visibility.Visible;
                        hovan = true;
                        playMedia.Open(ting);
                        playMedia.Play();

                    }
                }
                


            }
            if(gaucho ==  true && hovan == true )
            {
                
                report.Visibility = Visibility.Visible;
                Uri uri = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/chucmung.mp3"); // "/PuzzleGame;component/Sound/Ilikeme.wav", UriKind.Relative, browsing to the sound folder and then the WAV file location
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

        private void Replay_Click(object sender, RoutedEventArgs e)
        {
            report.Visibility = Visibility.Hidden;
            playMedia.Stop();
            replay = true;
            if (replay == true)
            {
                moving = false;
                
                BasePoint.X = 200;
                BasePoint.Y = 0;
                gaucho = false;
                RaisePropertyChanged("XPosition");
                RaisePropertyChanged("YPosition");
                hoa.Visibility = Visibility.Hidden;
                gau1.Visibility = Visibility.Visible;

                BasePoint1.X = 400;
                BasePoint1.Y = 0;
                hovan = false;
                RaisePropertyChanged("XPosition1");
                RaisePropertyChanged("YPosition1");
                bantay.Visibility = Visibility.Visible;
                ho.Visibility = Visibility.Visible;





            }
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            
            playMedia.Stop();
            Global.BandoTest.imgstep1.ImageSource = new BitmapImage(new Uri(@"D:\ĐỒ ÁN TN\PuzzleGame\PuzzleGame\Images\Background\khobau1.png"));
            this.Visibility = Visibility.Hidden;
            
            gaucho = false;
            hovan = false;
            

        }
       












        //private void myGif_MediaEnded(object sender, RoutedEventArgs e)
        //{
        //    myGif.Position = new TimeSpan(0, 0, 1);
        //    myGif.Play();
        //}
    }

}
