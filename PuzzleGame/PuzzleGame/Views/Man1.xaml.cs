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
using System.Windows.Media.Animation;
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
        private Point BasePoint2 = new Point(600, 250.0);
        private Point BasePoint3 = new Point(200, 450);
        private Point BasePoint4 = new Point(450, 650);
        private double DeltaX = 0.0;
        private double DeltaY = 0.0;
        private double DeltaX1 = 0.0;
        private double DeltaY1 = 0.0;
        private double DeltaX2 = 0.0;
        private double DeltaY2 = 0.0;
        private double DeltaX3 = 0.0;
        private double DeltaY3 = 0.0;
        private double DeltaX4 = 0.0;
        private double DeltaY4 = 0.0;
        private bool moving = false;
        private Point PositionImage;
        private static bool gaucho = false;
        private static bool hovan = false;//không cho chọn khi đúng hình;
        private static bool voixam = false;
        private static bool khinau = false;
        private static bool thoxam = false;
        private bool checkpoint = false;
        private bool replay = false;
        //private int temp = 0;
        MediaPlayer playMedia = new MediaPlayer();
       



        public Man1()
        {
            InitializeComponent();
            this.DataContext = this;
            Countdown.Completed += new EventHandler(Story_completed);





        }
        private void Story_completed(object sender, EventArgs e)
        {
            if (gaucho == false || hovan == false || thoxam == false || khinau == false || voixam == false )
            {
                timeout.Visibility = Visibility.Visible;
               
                Uri uri = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/timeout.mp3"); // "/PuzzleGame;component/Sound/Ilikeme.wav", UriKind.Relative, browsing to the sound folder and then the WAV file location
                playMedia.Open(uri); // inserting the URI to the media player
                playMedia.Play();
                if(checkpoint == true)
                {
                    playMedia.Stop();
                }
            }
            Countdown.Remove(this);
        }


        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            gaucho = false;
            hovan = false;//không cho chọn khi đúng hình;
            voixam = false;
            khinau = false;
            thoxam = false;
            checkpoint = true;
            Countdown.Stop(this);
            Countdown.Remove(this);
           
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
        public double XPosition2
        {
            get { return BasePoint2.X + DeltaX2; }
        }

        public double YPosition2
        {
            get { return BasePoint2.Y + DeltaY2; }
        }
        public double XPosition3
        {
            get { return BasePoint3.X + DeltaX3; }
        }

        public double YPosition3
        {
            get { return BasePoint3.Y + DeltaY3; }
        }
        public double XPosition4
        {
            get { return BasePoint4.X + DeltaX4; }
        }

        public double YPosition4
        {
            get { return BasePoint4.Y + DeltaY4; }
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
                    Panel.SetZIndex(gau2, 6);
                    Panel.SetZIndex(ho2, 1);
                    Panel.SetZIndex(voi2, 1);
                    Panel.SetZIndex(khi2, 1);
                    Panel.SetZIndex(tho2, 1);
                }
                if (l.Name == "ho2" && hovan == false)
                {
                    ho2.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(ho2);
                    
                    Panel.SetZIndex(ho2, 6);
                    Panel.SetZIndex(gau2, 1);
                    Panel.SetZIndex(voi2, 1);
                    Panel.SetZIndex(khi2, 1);
                    Panel.SetZIndex(tho2, 1);

                }
                if (l.Name == "voi2" && voixam == false)
                {
                    voi2.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(voi2);
                    Panel.SetZIndex(voi2, 6);
                    Panel.SetZIndex(ho2, 1);
                    Panel.SetZIndex(gau2, 1);
                    Panel.SetZIndex(khi2, 1);
                    Panel.SetZIndex(tho2, 1);


                }
                if (l.Name == "khi2" && khinau == false)
                {
                    khi2.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(khi2);
                    Panel.SetZIndex(khi2, 6);
                    Panel.SetZIndex(ho2, 1);
                    Panel.SetZIndex(voi2, 1);
                    Panel.SetZIndex(gau2, 1);
                    Panel.SetZIndex(tho2, 1);

                }
                if (l.Name == "tho2" && thoxam == false)
                {
                    tho2.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(tho2);
                    Panel.SetZIndex(tho2, 6);
                    Panel.SetZIndex(ho2, 1);
                    Panel.SetZIndex(voi2, 1);
                    Panel.SetZIndex(khi2, 1);
                    Panel.SetZIndex(gau2, 1);

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
            double v = Canvas.GetLeft(voi);
            double o = Canvas.GetTop(voi);
            double k = Canvas.GetLeft(khi);
            double h = Canvas.GetTop(khi);
            double t = Canvas.GetLeft(tho);
            double u = Canvas.GetTop(tho);



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
                if (l.Name == "ho2" )
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
                if (l.Name == "voi2")
                {
                    Point p = e.GetPosition(null);
                    DeltaX2 = p.X - BasePoint2.X - PositionImage.X;
                    DeltaY2 = p.Y - BasePoint2.Y - PositionImage.Y;
                    BasePoint2.X += DeltaX2;
                    BasePoint2.Y += DeltaY2;
                    RaisePropertyChanged("XPosition2");
                    RaisePropertyChanged("YPosition2");
                    if ((((BasePoint2.X - 50) < v) && (BasePoint2.X + 50) > v) && (((BasePoint2.Y - 50) < o) && ((BasePoint2.Y + 50) > o)))
                    {
                        voi1.Visibility = Visibility.Visible;
                        voi.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        voi1.Visibility = Visibility.Hidden;
                        voi.Visibility = Visibility.Visible;
                    }

                }
                if (l.Name == "khi2")
                {
                    Point p = e.GetPosition(null);
                    DeltaX3 = p.X - BasePoint3.X - PositionImage.X;
                    DeltaY3 = p.Y - BasePoint3.Y - PositionImage.Y;
                    BasePoint3.X += DeltaX3;
                    BasePoint3.Y += DeltaY3;
                    RaisePropertyChanged("XPosition3");
                    RaisePropertyChanged("YPosition3");
                    if ((((BasePoint3.X - 50) < k) && (BasePoint3.X + 50) > k) && (((BasePoint3.Y - 50) < h) && ((BasePoint3.Y + 50) > h)))
                    {
                        khi1.Visibility = Visibility.Visible;
                        khi.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        khi1.Visibility = Visibility.Hidden;
                        khi.Visibility = Visibility.Visible;
                    }

                }
                if (l.Name == "tho2")
                {
                    Point p = e.GetPosition(null);
                    DeltaX4 = p.X - BasePoint4.X - PositionImage.X;
                    DeltaY4 = p.Y - BasePoint4.Y - PositionImage.Y;
                    BasePoint4.X += DeltaX4;
                    BasePoint4.Y += DeltaY4;
                    RaisePropertyChanged("XPosition4");
                    RaisePropertyChanged("YPosition4");
                    if ((((BasePoint4.X - 50) < t) && (BasePoint4.X + 50) > t) && (((BasePoint4.Y - 50) < u) && ((BasePoint4.Y + 50) > u)))
                    {
                        tho1.Visibility = Visibility.Visible;
                        tho.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        tho1.Visibility = Visibility.Hidden;
                        tho.Visibility = Visibility.Visible;
                    }

                }


            }
        }

       
        private void Feast_MouseUp(object sender, MouseButtonEventArgs e)
        {
           
            Uri ting = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/Ting.mp3"); 
          
         
            double m = Canvas.GetLeft(ho);
            double n = Canvas.GetTop(ho);
            double x = Canvas.GetLeft(gau1);
            double y = Canvas.GetTop(gau1);
            double v = Canvas.GetLeft(voi);
            double o = Canvas.GetTop(voi);
            double k = Canvas.GetLeft(khi);
            double h = Canvas.GetTop(khi);
            double t = Canvas.GetLeft(tho);
            double u = Canvas.GetTop(tho);
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
                if (l.Name == "voi2")
                {
                    voi2.ReleaseMouseCapture();
                    BasePoint2.X += DeltaX2;
                    BasePoint2.Y += DeltaY2;
                    DeltaX2 = 0.0;
                    DeltaY2 = 0.0;
                    moving = false;
                    if ((((BasePoint2.X - 50) < v) && (BasePoint2.X + 50) > v) && (((BasePoint2.Y - 50) < o) && ((BasePoint2.Y + 50) > o)))
                    {
                        BasePoint2.X = v;
                        BasePoint2.Y = o;
                        RaisePropertyChanged("XPosition2");
                        RaisePropertyChanged("YPosition2");
                        voi1.Visibility = Visibility.Hidden;
                        voi2.Visibility = Visibility.Visible;
                        voixam = true;
                        playMedia.Open(ting);
                        playMedia.Play();

                    }
                   
                }
                if (l.Name == "khi2")
                {
                    khi2.ReleaseMouseCapture();
                    BasePoint3.X += DeltaX3;
                    BasePoint3.Y += DeltaY3;
                    DeltaX3 = 0.0;
                    DeltaY3 = 0.0;
                    moving = false;
                    if ((((BasePoint3.X - 50) < k) && (BasePoint3.X + 50) > k) && (((BasePoint3.Y - 50) < h) && ((BasePoint3.Y + 50) > h)))
                    {
                        BasePoint3.X = k;
                        BasePoint3.Y = h;
                        RaisePropertyChanged("XPosition3");
                        RaisePropertyChanged("YPosition3");
                        khi1.Visibility = Visibility.Hidden;
                        khi2.Visibility = Visibility.Visible;
                        khinau = true;
                        playMedia.Open(ting);
                        playMedia.Play();

                    }
                }
                if (l.Name == "tho2")
                {
                    tho2.ReleaseMouseCapture();
                    BasePoint4.X += DeltaX4;
                    BasePoint4.Y += DeltaY4;
                    DeltaX4 = 0.0;
                    DeltaY4 = 0.0;
                    moving = false;
                    if ((((BasePoint4.X - 50) < t) && (BasePoint4.X + 50) > t) && (((BasePoint4.Y - 50) < u) && ((BasePoint4.Y + 50) > u)))
                    {
                        BasePoint4.X = t;
                        BasePoint4.Y = u;
                        RaisePropertyChanged("XPosition4");
                        RaisePropertyChanged("YPosition4");
                        tho1.Visibility = Visibility.Hidden;
                        tho.Visibility = Visibility.Visible;
                        thoxam = true;
                        playMedia.Open(ting);
                        playMedia.Play();

                    }
                }



            }
            if(gaucho ==  true && hovan == true && voixam == true && khinau == true && thoxam == true )
            {
                
                report.Visibility = Visibility.Visible;
                Pause1.IsEnabled = false;
                Uri uri = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/chucmung.mp3"); // "/PuzzleGame;component/Sound/Ilikeme.wav", UriKind.Relative, browsing to the sound folder and then the WAV file location
                playMedia.Open(uri); // inserting the URI to the media player
                playMedia.Play();
                Countdown.Stop(this);
                Countdown.Remove(this);

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
            Countdown.Begin(this, true);
            Pause1.IsEnabled = true;
            report.Visibility = Visibility.Hidden;
            timeout.Visibility = Visibility.Collapsed;
            playMedia.Stop();
            replay = true;
            if (replay == true)
            {
                moving = false;
                
                BasePoint.X = 200;
                BasePoint.Y = 20;
                gaucho = false;
                RaisePropertyChanged("XPosition");
                RaisePropertyChanged("YPosition");

                gau1.Visibility = Visibility.Visible;
                BasePoint1.X = 400;
                BasePoint1.Y = 0;
                hovan = false;
                RaisePropertyChanged("XPosition1");
                RaisePropertyChanged("YPosition1");
                bantay.Visibility = Visibility.Visible;
                ho.Visibility = Visibility.Visible;

                BasePoint2.X = 600;
                BasePoint2.Y = 250;
                voixam = false;
                RaisePropertyChanged("XPosition2");
                RaisePropertyChanged("YPosition2");
                voi.Visibility = Visibility.Visible;
                BasePoint3.X = 200;
                BasePoint3.Y = 450;
                khinau = false;
                RaisePropertyChanged("XPosition3");
                RaisePropertyChanged("YPosition3");
                khi.Visibility = Visibility.Visible;
                BasePoint4.X = 450;
                BasePoint4.Y = 650;
                thoxam = false;
                RaisePropertyChanged("XPosition4");
                RaisePropertyChanged("YPosition4");
                tho.Visibility = Visibility.Visible;




            }
        }
       
        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            Pause1.IsEnabled = true;
            playMedia.Stop();
            
            this.Visibility = Visibility.Collapsed;
            
            gaucho = false;
            hovan = false;
            voixam = false;
            khinau = false;
            thoxam = false;
            

        }

        private void Pause1_Click(object sender, RoutedEventArgs e)
        {
            Pause1.Visibility = Visibility.Collapsed;
            Resume1.Visibility = Visibility.Visible;
            Canvas1.IsEnabled = false;
            Canvas1.Focusable = false;
        }

        private void Resume1_Click(object sender, RoutedEventArgs e)
        {
            Resume1.Visibility = Visibility.Collapsed;
            Pause1.Visibility = Visibility.Visible;
            Canvas1.IsEnabled = true;
            Canvas1.Focusable = true;
        }













        //private void myGif_MediaEnded(object sender, RoutedEventArgs e)
        //{
        //    myGif.Position = new TimeSpan(0, 0, 1);
        //    myGif.Play();
        //}
    }

}
