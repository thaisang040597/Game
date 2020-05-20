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
    /// Interaction logic for Man2.xaml
    /// </summary>
    public partial class Man2 : UserControl  , INotifyPropertyChanged
    {
        private Point BasePoint = new Point(200.0, 20);
        private Point BasePoint1 = new Point(400, 0.0);
        private Point BasePoint2 = new Point(600, 90.0);
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
        private static bool matong = false;
        private static bool carot = false;
        private static bool miatim = false;
        private static bool coxanh = false;
        private static bool chuoivang = false;//không cho chọn khi đúng hình;
        private bool checkpoint = false;
        private bool replay = false;
        //private int temp = 0;
        MediaPlayer playMedia = new MediaPlayer();
        public Man2()
        {
            InitializeComponent();
            this.DataContext = this;
            //Countdown.Completed += new EventHandler(Story_completed);
        }

        //private void Story_completed(object sender, EventArgs e)
        //{
        //   if(matong == false || carot == false || coxanh == false || chuoivang == false || miatim == false)
        //    {
        //        timeout.Visibility = Visibility.Visible;
                
        //        Uri uri = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/timeout.mp3"); // "/PuzzleGame;component/Sound/Ilikeme.wav", UriKind.Relative, browsing to the sound folder and then the WAV file location
        //        playMedia.Open(uri); // inserting the URI to the media player
        //        playMedia.Play();
        //        if (checkpoint == true)
        //        {
        //            playMedia.Stop();
        //        }
        //    }
        //    Countdown.Remove(this);
        //}

        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            
            //Countdown.Stop(this);
            //Countdown.Remove(this);
            matong = false;
            carot = false;//không cho chọn khi đúng hình;
            miatim = false;
            coxanh = false;
            chuoivang = false;
            checkpoint = true;


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

        private void Feast_MouseDown1(object sender, MouseButtonEventArgs e)
        {
            Image l = e.Source as Image;
            if (l != null)
            {
                //bantay.Visibility = Visibility.Hidden;
                if (l.Name == "honey" && matong == false)
                {
                    honey.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(honey);
                    //bantay1.Visibility = Visibility.Visible;
                    Panel.SetZIndex(honey, 6);
                    Panel.SetZIndex(carrot, 1);
                    Panel.SetZIndex(co, 1);
                    Panel.SetZIndex(cane, 1);
                    Panel.SetZIndex(banana, 1);

                }
                if (l.Name == "carrot" && carot == false)
                {
                    carrot.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(carrot);
                    Panel.SetZIndex(honey, 1);
                    Panel.SetZIndex(carrot, 6);
                    Panel.SetZIndex(co, 1);
                    Panel.SetZIndex(cane, 1);
                    Panel.SetZIndex(banana, 1);
                }
                if (l.Name == "co" && coxanh == false)
                {
                    co.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(co);
                    Panel.SetZIndex(honey, 1);
                    Panel.SetZIndex(carrot, 1);
                    Panel.SetZIndex(co, 6);
                    Panel.SetZIndex(cane, 1);
                    Panel.SetZIndex(banana, 1);
                }
                if (l.Name == "cane" && miatim == false)
                {
                    cane.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(cane);
                    Panel.SetZIndex(honey, 1);
                    Panel.SetZIndex(carrot, 1);
                    Panel.SetZIndex(co, 1);
                    Panel.SetZIndex(cane, 6);
                    Panel.SetZIndex(banana, 1);
                }
                if (l.Name == "banana" && chuoivang == false)
                {
                    banana.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(banana);
                    Panel.SetZIndex(honey, 1);
                    Panel.SetZIndex(carrot, 1);
                    Panel.SetZIndex(co, 1);
                    Panel.SetZIndex(cane, 1);
                    Panel.SetZIndex(banana, 6);
                }
                playMedia.Stop();



            }
            //if (l == null)
            //{
            //    bantay.Visibility = Visibility.Visible;
            //}
        }

       

        private void Feast_MouseMove1(object sender, MouseEventArgs e)
        {
            //double x = Canvas.GetLeft(gau);
            //double y = Canvas.GetTop(gau);
            //double m = Canvas.GetLeft(tho);
            //double n = Canvas.GetTop(tho);


            if (moving)
            {
                Image l = e.Source as Image;
                if (l.Name == "honey")
                {
                    Point p = e.GetPosition(null);
                    DeltaX = p.X - BasePoint.X - PositionImage.X;
                    DeltaY = p.Y - BasePoint.Y - PositionImage.Y;
                    BasePoint.X += DeltaX;
                    BasePoint.Y += DeltaY;
                    RaisePropertyChanged("XPosition");
                    RaisePropertyChanged("YPosition");
                   

                }
                if (l.Name == "carrot")
                {
                    Point p = e.GetPosition(null);
                    DeltaX1 = p.X - BasePoint1.X - PositionImage.X;
                    DeltaY1 = p.Y - BasePoint1.Y - PositionImage.Y;
                    BasePoint1.X += DeltaX1;
                    BasePoint1.Y += DeltaY1;
                    RaisePropertyChanged("XPosition1");
                    RaisePropertyChanged("YPosition1");
                    //    if ((((BasePoint1.X - 50) < m) && (BasePoint1.X + 50) > m) && (((BasePoint1.Y - 50) < n) && ((BasePoint1.Y + 50) > n)))
                    //    {
                    //        ho1.Visibility = Visibility.Visible;
                    //        ho.Visibility = Visibility.Hidden;
                    //    }
                    //    else
                    //    {
                    //        ho1.Visibility = Visibility.Hidden;
                    //        ho.Visibility = Visibility.Visible;
                    //    }

                }
                if (l.Name == "co")
                {
                    Point p = e.GetPosition(null);
                    DeltaX2 = p.X - BasePoint2.X - PositionImage.X;
                    DeltaY2 = p.Y - BasePoint2.Y - PositionImage.Y;
                    BasePoint2.X += DeltaX2;
                    BasePoint2.Y += DeltaY2;
                    RaisePropertyChanged("XPosition2");
                    RaisePropertyChanged("YPosition2");


                }
                if (l.Name == "cane")
                {
                    Point p = e.GetPosition(null);
                    DeltaX3 = p.X - BasePoint3.X - PositionImage.X;
                    DeltaY3 = p.Y - BasePoint3.Y - PositionImage.Y;
                    BasePoint3.X += DeltaX3;
                    BasePoint3.Y += DeltaY3;
                    RaisePropertyChanged("XPosition3");
                    RaisePropertyChanged("YPosition3");


                }
                if (l.Name == "banana")
                {
                    Point p = e.GetPosition(null);
                    DeltaX4 = p.X - BasePoint4.X - PositionImage.X;
                    DeltaY4 = p.Y - BasePoint4.Y - PositionImage.Y;
                    BasePoint4.X += DeltaX4;
                    BasePoint4.Y += DeltaY4;
                    RaisePropertyChanged("XPosition4");
                    RaisePropertyChanged("YPosition4");


                }


            }
        }
        private void Feast_MouseUp1(object sender, MouseButtonEventArgs e)
        {
            //playlistTimer.Interval = new TimeSpan(0, 0, 5);
             // "/PuzzleGame;component/Sound/Ilikeme.wav", UriKind.Relative, browsing to the sound folder and then the WAV file location
                                                                                    // inserting the URI to the media player

            double m = Canvas.GetLeft(tho);
            double n = Canvas.GetTop(tho);
            double x = Canvas.GetLeft(gau);
            double y = Canvas.GetTop(gau);
            double v = Canvas.GetLeft(voi);
            double o = Canvas.GetTop(voi);
            double k = Canvas.GetLeft(khi);
            double h = Canvas.GetTop(khi);
            double t = Canvas.GetLeft(hama);
            double u = Canvas.GetTop(hama);
            Image l = e.Source as Image;
            if (l != null)
            {
                if (l.Name == "honey")
                {
                    honey.ReleaseMouseCapture();
                    BasePoint.X += DeltaX;
                    BasePoint.Y += DeltaY;
                    DeltaX = 0.0;
                    DeltaY = 0.0;
                    moving = false;
                    if ((((BasePoint.X - 50) < x) && (BasePoint.X + 100) > x) && (((BasePoint.Y - 50) < y) && ((BasePoint.Y + 100) > y)))
                    {
                        BasePoint.X = x+25;
                        BasePoint.Y = y+50;
                        RaisePropertyChanged("XPosition");
                        RaisePropertyChanged("YPosition");
                        //gau.Visibility = Visibility.Hidden;
                        //hoa.Visibility = Visibility.Visible;
                        matong = true;
                        Uri ting = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/Gaukeu.mp3");
                        playMedia.Open(ting);
                        playMedia.Play();
                        //bantay1.Visibility = Visibility.Hidden;

                    }
                }
                if (l.Name == "carrot")
                {
                    carrot.ReleaseMouseCapture();
                    BasePoint1.X += DeltaX1;
                    BasePoint1.Y += DeltaY1;
                    DeltaX1 = 0.0;
                    DeltaY1 = 0.0;
                    moving = false;
                    if ((((BasePoint1.X - 50) < m) && (BasePoint1.X + 50) > m) && (((BasePoint1.Y - 50) < n) && ((BasePoint1.Y + 50) > n)))
                    {
                        BasePoint1.X = m+40;
                        BasePoint1.Y = n+20;
                        RaisePropertyChanged("XPosition1");
                        RaisePropertyChanged("YPosition1");
                      
                        carot = true;
                        Uri ting = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/thokeu.mp3");
                        playMedia.Open(ting);
                        playMedia.Play();

                    }
                }
                if (l.Name == "co")
                {
                    co.ReleaseMouseCapture();
                    BasePoint2.X += DeltaX2;
                    BasePoint2.Y += DeltaY2;
                    DeltaX2 = 0.0;
                    DeltaY2 = 0.0;
                    moving = false;
                    if ((((BasePoint2.X - 50) < t) && (BasePoint2.X + 50) > t) && (((BasePoint2.Y - 50) < u) && ((BasePoint2.Y + 50) > u)))
                    {
                        BasePoint2.X = t ;
                        BasePoint2.Y = u + 70;
                        RaisePropertyChanged("XPosition2");
                        RaisePropertyChanged("YPosition2");

                        coxanh = true;
                        Uri ting = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/thokeu.mp3");
                        playMedia.Open(ting);
                        playMedia.Play();

                    }
                }
                if (l.Name == "cane")
                {
                    cane.ReleaseMouseCapture();
                    BasePoint3.X += DeltaX3;
                    BasePoint3.Y += DeltaY3;
                    DeltaX3 = 0.0;
                    DeltaY3 = 0.0;
                    moving = false;
                    if ((((BasePoint3.X - 100) < v) && (BasePoint3.X + 100) > v) && (((BasePoint3.Y - 100) < o) && ((BasePoint3.Y + 100) > o)))
                    {
                        BasePoint3.X = v+30 ;
                        BasePoint3.Y = o-70 ;
                        RaisePropertyChanged("XPosition3");
                        RaisePropertyChanged("YPosition3");

                        miatim = true;
                        Uri ting = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/voikeu.mp3");
                        playMedia.Open(ting);
                        playMedia.Play();

                    }
                }
                if (l.Name == "banana")
                {
                    banana.ReleaseMouseCapture();
                    BasePoint4.X += DeltaX4;
                    BasePoint4.Y += DeltaY4;
                    DeltaX4 = 0.0;
                    DeltaY4 = 0.0;
                    moving = false;
                    if ((((BasePoint4.X - 80) < k) && (BasePoint4.X + 80) > k) && (((BasePoint4.Y - 80) < h) && ((BasePoint4.Y + 80) > h)))
                    {
                        BasePoint4.X = k +30;
                        BasePoint4.Y = h +80;
                        RaisePropertyChanged("XPosition4");
                        RaisePropertyChanged("YPosition4");

                        chuoivang = true;
                        Uri ting = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/khikeu.mp3");
                        playMedia.Open(ting);
                        playMedia.Play();

                    }
                }



            }
            if (matong == true && carot == true && coxanh == true && chuoivang == true && miatim == true)
            {

                report.Visibility = Visibility.Visible;
                Uri uri = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/chucmung.mp3"); // "/PuzzleGame;component/Sound/Ilikeme.wav", UriKind.Relative, browsing to the sound folder and then the WAV file location
                playMedia.Open(uri); // inserting the URI to the media player
                playMedia.Play();
                //Countdown.Stop(this);
                //Countdown.Remove(this);

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            playMedia.Stop();
            //Pause1.IsEnabled = true;
            Global.dem = 2;
            //Man2 man2 = new Man2();
            //Global.menutest.oc.Children.Add(man2);
            //Global.menutest.round2.Width = 300;

            Global.menutest.imground3.ImageSource = new BitmapImage(new Uri(@"D:\ĐỒ ÁN TN\GitHub\Game\PuzzleGame\PuzzleGame\Images\Game1\Round3\AH.png"));
            this.Visibility = Visibility.Collapsed;
            carot = false;
            matong = false;
            coxanh = false;
            miatim = false;
            chuoivang = false;
            Man3 man3 = new Man3();
            Global.menutest.oc.Children.Add(man3);

        }

        private void Replay_Click(object sender, RoutedEventArgs e)
        {
            
            //Countdown.Begin(this, true);
            //Pause1.IsEnabled = true;
            report.Visibility = Visibility.Collapsed;
            //timeout.Visibility = Visibility.Collapsed;
            playMedia.Stop();
            replay = true;
            if (replay == true)
            {
                moving = false;

                BasePoint.X = 200;
                BasePoint.Y = 20;
                matong = false;
                RaisePropertyChanged("XPosition");
                RaisePropertyChanged("YPosition");

               
                BasePoint1.X = 400;
                BasePoint1.Y = 0;
                carot = false;
                RaisePropertyChanged("XPosition1");
                RaisePropertyChanged("YPosition1");
              

                BasePoint2.X = 600;
                BasePoint2.Y = 90;
                coxanh = false;
                RaisePropertyChanged("XPosition2");
                RaisePropertyChanged("YPosition2");
               
                BasePoint3.X = 200;
                BasePoint3.Y = 450;
                miatim = false;
                RaisePropertyChanged("XPosition3");
                RaisePropertyChanged("YPosition3");
               
                BasePoint4.X = 450;
                BasePoint4.Y = 650;
                chuoivang = false;
                RaisePropertyChanged("XPosition4");
                RaisePropertyChanged("YPosition4");
               




            }
        }

        //private void Pause1_Click(object sender, RoutedEventArgs e)
        //{
        //    //Pause1.Visibility = Visibility.Collapsed;
        //    //Resume1.Visibility = Visibility.Visible;
        //    Canvas1.IsEnabled = false;
        //    Canvas1.Focusable = false;
        //}

        //private void Resume1_Click(object sender, RoutedEventArgs e)
        //{
        //    //Resume1.Visibility = Visibility.Collapsed;
        //    //Pause1.Visibility = Visibility.Visible;
        //    Canvas1.IsEnabled = true;
        //    Canvas1.Focusable = true;
        //}
    }
}
