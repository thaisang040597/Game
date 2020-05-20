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
            //Countdown.Completed += new EventHandler(Story_completed);
            RanDomImg();




        }
        //private void Story_completed(object sender, EventArgs e)
        //{
        //    if (gaucho == false || hovan == false || thoxam == false || khinau == false || voixam == false )
        //    {
        //        timeout.Visibility = Visibility.Visible;
               
        //        Uri uri = new Uri(@"pack://application:,,,/Sound/timeout.mp3"); // "/PuzzleGame;component/Sound/Ilikeme.wav", UriKind.Relative, browsing to the sound folder and then the WAV file location
        //        playMedia.Open(uri); // inserting the URI to the media player
        //        playMedia.Play();
        //        if(checkpoint == true)
        //        {
        //            playMedia.Stop();
        //        }
        //    }
        //    Countdown.Remove(this);
        //}


        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            gaucho = false;
            hovan = false;//không cho chọn khi đúng hình;
            voixam = false;
            khinau = false;
            thoxam = false;
            checkpoint = true;
            //Countdown.Stop(this);
            //Countdown.Remove(this);
           
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
            get { return BasePoint1.X + DeltaX; }
        }

        public double YPosition1
        {
            get { return BasePoint1.Y + DeltaY; }
        }
        public double XPosition2
        {
            get { return BasePoint2.X + DeltaX; }
        }

        public double YPosition2
        {
            get { return BasePoint2.Y + DeltaY; }
        }
        public double XPosition3
        {
            get { return BasePoint3.X + DeltaX; }
        }

        public double YPosition3
        {
            get { return BasePoint3.Y + DeltaY; }
        }
        public double XPosition4
        {
            get { return BasePoint4.X + DeltaX; }
        }

        public double YPosition4
        {
            get { return BasePoint4.Y + DeltaY; }
        }

        private void RanDomImg()
        {
            List<string> Images = new List<string>()
            {
                "/Images/Game1/Round1/gau2.png","/Images/Game1/Round1/tho2.png" ,"/Images/Game1/Round1/khi2.png" ,"/Images/Game1/Round1/voi2.png",
                "/Images/Game1/Round1/ho2.png"  ,"/Images/Game1/Round1/sutu2.png"  ,"/Images/Game1/Round1/cho2.png"
            };
            List<string> ImagesBong = new List<string>()
            {
                "/Images/Game1/Round1/gau1.png","/Images/Game1/Round1/tho.png" ,"/Images/Game1/Round1/khi.png" ,"/Images/Game1/Round1/voi.png",
                "/Images/Game1/Round1/ho.png"  ,"/Images/Game1/Round1/sutu.png"  ,"/Images/Game1/Round1/cho.png"
            };

            List<int> lstIndex = new List<int>();
            Random rnd = new Random();
            for(int i = 0; i < 5; i++)
            {
                int index = 0;
                do
                {
                    index = rnd.Next(0, 6);
                } while (lstIndex.Exists(x => x == index) == true);
                lstIndex.Add(index);
            }
            gau2.Source = new BitmapImage(new Uri(Images[lstIndex[0]], UriKind.RelativeOrAbsolute));
            ho2.Source = new BitmapImage(new Uri(Images[lstIndex[1]], UriKind.RelativeOrAbsolute));
            voi2.Source = new BitmapImage(new Uri(Images[lstIndex[2]], UriKind.RelativeOrAbsolute));
            khi2.Source = new BitmapImage(new Uri(Images[lstIndex[3]], UriKind.RelativeOrAbsolute));
            tho2.Source = new BitmapImage(new Uri(Images[lstIndex[4]], UriKind.RelativeOrAbsolute));
            gau1.Source = new BitmapImage(new Uri(ImagesBong[lstIndex[0]], UriKind.RelativeOrAbsolute));
            ho.Source = new BitmapImage(new Uri(ImagesBong[lstIndex[1]], UriKind.RelativeOrAbsolute));
            voi.Source = new BitmapImage(new Uri(ImagesBong[lstIndex[2]], UriKind.RelativeOrAbsolute));
            khi.Source = new BitmapImage(new Uri(ImagesBong[lstIndex[3]], UriKind.RelativeOrAbsolute));
            tho.Source = new BitmapImage(new Uri(ImagesBong[lstIndex[4]], UriKind.RelativeOrAbsolute));

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
                    //if ((((BasePoint.X - 50) < x) && (BasePoint.X + 50) > x) && (((BasePoint.Y - 50) < y) && ((BasePoint.Y + 50) > y)))
                    //{
                    //    gau.Visibility = Visibility.Visible;
                    //    gau1.Visibility = Visibility.Hidden;
                    //}
                    //else
                    //{
                    //    gau.Visibility = Visibility.Hidden;
                    //    gau1.Visibility = Visibility.Visible;
                    //}
                    
                }
                if (l.Name == "ho2" )
                {
                    Point p = e.GetPosition(null);
                    DeltaX = p.X - BasePoint1.X - PositionImage.X;
                    DeltaY = p.Y - BasePoint1.Y - PositionImage.Y;
                    BasePoint1.X += DeltaX;
                    BasePoint1.Y += DeltaY;
                    RaisePropertyChanged("XPosition1");
                    RaisePropertyChanged("YPosition1");
                    //if ((((BasePoint1.X - 50) < m) && (BasePoint1.X + 50) > m) && (((BasePoint1.Y - 50) < n) && ((BasePoint1.Y + 50) > n)))
                    //{
                    //    ho1.Visibility = Visibility.Visible;
                    //    ho.Visibility = Visibility.Hidden;
                    //}
                    //else
                    //{
                    //    ho1.Visibility = Visibility.Hidden;
                    //    ho.Visibility = Visibility.Visible;
                    //}

                }
                if (l.Name == "voi2")
                {
                    Point p = e.GetPosition(null);
                    DeltaX = p.X - BasePoint2.X - PositionImage.X;
                    DeltaY = p.Y - BasePoint2.Y - PositionImage.Y;
                    BasePoint2.X += DeltaX;
                    BasePoint2.Y += DeltaY;
                    RaisePropertyChanged("XPosition2");
                    RaisePropertyChanged("YPosition2");
                    //if ((((BasePoint2.X - 50) < v) && (BasePoint2.X + 50) > v) && (((BasePoint2.Y - 50) < o) && ((BasePoint2.Y + 50) > o)))
                    //{
                    //    voi1.Visibility = Visibility.Visible;
                    //    voi.Visibility = Visibility.Hidden;
                    //}
                    //else
                    //{
                    //    voi1.Visibility = Visibility.Hidden;
                    //    voi.Visibility = Visibility.Visible;
                    //}

                }
                if (l.Name == "khi2")
                {
                    Point p = e.GetPosition(null);
                    DeltaX = p.X - BasePoint3.X - PositionImage.X;
                    DeltaY = p.Y - BasePoint3.Y - PositionImage.Y;
                    BasePoint3.X += DeltaX;
                    BasePoint3.Y += DeltaY;
                    RaisePropertyChanged("XPosition3");
                    RaisePropertyChanged("YPosition3");
                    //if ((((BasePoint3.X - 50) < k) && (BasePoint3.X + 50) > k) && (((BasePoint3.Y - 50) < h) && ((BasePoint3.Y + 50) > h)))
                    //{
                    //    khi1.Visibility = Visibility.Visible;
                    //    khi.Visibility = Visibility.Hidden;
                    //}
                    //else
                    //{
                    //    khi1.Visibility = Visibility.Hidden;
                    //    khi.Visibility = Visibility.Visible;
                    //}

                }
                if (l.Name == "tho2")
                {
                    Point p = e.GetPosition(null);
                    DeltaX = p.X - BasePoint4.X - PositionImage.X;
                    DeltaY = p.Y - BasePoint4.Y - PositionImage.Y;
                    BasePoint4.X += DeltaX;
                    BasePoint4.Y += DeltaY;
                    RaisePropertyChanged("XPosition4");
                    RaisePropertyChanged("YPosition4");
                    //if ((((BasePoint4.X - 50) < t) && (BasePoint4.X + 50) > t) && (((BasePoint4.Y - 50) < u) && ((BasePoint4.Y + 50) > u)))
                    //{
                    //    tho1.Visibility = Visibility.Visible;
                    //    tho.Visibility = Visibility.Hidden;
                    //}
                    //else
                    //{
                    //    tho1.Visibility = Visibility.Hidden;
                    //    tho.Visibility = Visibility.Visible;
                    //}

                }


            }
        }

       
        private void Feast_MouseUp(object sender, MouseButtonEventArgs e)
        {
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
                        Uri uri = new Uri(@"..\..\Sound\chucmung.mp3", UriKind.Relative);
                        playMedia.Open(uri);

                        playMedia.Play();
                        
                        bantay1.Visibility = Visibility.Hidden;
                    }
                    
                }
                if(l.Name == "ho2")
                {
                    ho2.ReleaseMouseCapture();
                    BasePoint1.X += DeltaX;
                    BasePoint1.Y += DeltaY;
                    DeltaX = 0.0;
                    DeltaY = 0.0;
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
                        playMedia.Open(new Uri(@"..\..\Sound\Ting.mp3", UriKind.Relative));

                    }
                }
                if (l.Name == "voi2")
                {
                    voi2.ReleaseMouseCapture();
                    BasePoint2.X += DeltaX;
                    BasePoint2.Y += DeltaY;
                    DeltaX = 0.0;
                    DeltaY = 0.0;
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
                        playMedia.Open(new Uri(@"..\..\Sound\Ting.mp3", UriKind.Relative));

                    }
                   
                }
                if (l.Name == "khi2")
                {
                    khi2.ReleaseMouseCapture();
                    BasePoint3.X += DeltaX;
                    BasePoint3.Y += DeltaY;
                    DeltaX = 0.0;
                    DeltaY = 0.0;
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
                        playMedia.Open(new Uri(@"..\..\Sound\Ting.mp3", UriKind.Relative));

                    }
                }
                if (l.Name == "tho2")
                {
                    tho2.ReleaseMouseCapture();
                    BasePoint4.X += DeltaX;
                    BasePoint4.Y += DeltaY;
                    DeltaX = 0.0;
                    DeltaY = 0.0;
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
                        playMedia.Open(new Uri(@"\Sound\Ting.mp3", UriKind.Relative));

                    }
                }



            }
            if(gaucho ==  true && hovan == true && voixam == true && khinau == true && thoxam == true )
            {
                
                report.Visibility = Visibility.Visible;
                //Pause1.IsEnabled = false;
                Uri uri = new Uri(@"..\..\Sound\chucmung.mp3", UriKind.Relative); // "/PuzzleGame;component/Sound/Ilikeme.wav", UriKind.Relative, browsing to the sound folder and then the WAV file location
                playMedia.Open(uri); // inserting the URI to the media player
                playMedia.Play();
                //Countdown.Stop(this);
                //Countdown.Remove(this);
             

                /*new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/PuzzleGame;/Images/Round2/carrot.png")));*/


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
            RanDomImg();
            //Countdown.Begin(this, true);
            //Pause1.IsEnabled = true;
            report.Visibility = Visibility.Hidden;
            //timeout.Visibility = Visibility.Collapsed;
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
           // var filename = @"D:\ĐỒ ÁN TN\PuzzleGame\PuzzleGame\Images\Background\board.png";
           //Global.menutest.imground2.ImageSource = new BitmapImage(new Uri(filename, UriKind.Relative));
            //Pause1.IsEnabled = true;
            playMedia.Stop();
            Global.dem = 1;
            //Man2 man2 = new Man2();
            //Global.menutest.oc.Children.Add(man2);
            //Global.menutest.round2.Width = 300;

            Global.menutest.imground2.ImageSource = new BitmapImage(new Uri(@"D:\ĐỒ ÁN TN\GitHub\Game\PuzzleGame\PuzzleGame\Images\Game1\Round2\carrot.png"));
            this.Visibility = Visibility.Collapsed;
            
            gaucho = false;
            hovan = false;
            voixam = false;
            khinau = false;
            thoxam = false;
            Man2 man2 = new Man2();
            Global.menutest.oc.Children.Add(man2);
           

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
        //    Resume1.Visibility = Visibility.Collapsed;
        //    Pause1.Visibility = Visibility.Visible;
        //    Canvas1.IsEnabled = true;
        //    Canvas1.Focusable = true;
        //}













        //private void myGif_MediaEnded(object sender, RoutedEventArgs e)
        //{
        //    myGif.Position = new TimeSpan(0, 0, 1);
        //    myGif.Play();
        //}
    }

}
