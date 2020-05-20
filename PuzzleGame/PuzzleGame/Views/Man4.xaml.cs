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
    /// Interaction logic for Man4.xaml
    /// </summary>
    public partial class Man4 : UserControl, INotifyPropertyChanged
    {
        private Point BasePointChanh = new Point(850, 480);
        private Point BasePointDau = new Point(350, 480);
        private Point BasePointThanhLong = new Point(290, 450.0);
        private Point BasePointNho = new Point(440, 480);
        private Point BasePointDuDu = new Point(400, 330);
        private double DeltaXChanh = 0.0;
        private double DeltaYChanh = 0.0;
        private double DeltaXDau = 0.0;
        private double DeltaYDau = 0.0;
        private double DeltaXThanhLong = 0.0;
        private double DeltaYThanhLong = 0.0;
        private double DeltaXNho = 0.0;
        private double DeltaYNho = 0.0;
        private double DeltaXDuDu = 0.0;
        private double DeltaYDuDu = 0.0;
        private bool moving = false;
        private Point PositionImage;
        private static bool chanhxanh = false;
        private static bool daudo = false;//không cho chọn khi đúng hình;
        private static bool thanhlongtrang = false;
        private static bool nhotim = false;
        private static bool duduvang = false;
        private bool checkpoint = false;
        private bool replay = false;
        //private int temp = 0;
        MediaPlayer playMedia = new MediaPlayer();



        public double XPositionChanh
        {
            get { return BasePointChanh.X + DeltaXChanh; }
        }

        public double YPositionChanh
        {
            get { return BasePointChanh.Y + DeltaYChanh; }
        }
        public double XPositionDau
        {
            get { return BasePointDau.X + DeltaXDau; }
        }

        public double YPositionDau
        {
            get { return BasePointDau.Y + DeltaYDau; }
        }
        public double XPositionThanhLong
        {
            get { return BasePointThanhLong.X + DeltaXThanhLong; }
        }

        public double YPositionThanhLong
        {
            get { return BasePointThanhLong.Y + DeltaYThanhLong; }
        }
        public double XPositionNho
        {
            get { return BasePointNho.X + DeltaXNho; }
        }

        public double YPositionNho
        {
            get { return BasePointNho.Y + DeltaYNho; }
        }
        public double XPositionDuDu
        {
            get { return BasePointDuDu.X + DeltaXDuDu; }
        }

        public double YPositionDuDu
        {
            get { return BasePointDuDu.Y + DeltaYDuDu; }
        }
        public Man4()
        {
            InitializeComponent();
            this.DataContext = this;
            //Countdown.Completed += new EventHandler(Story_completed);
        }

        //private void Story_completed(object sender, EventArgs e)
        //{
        //    if (chanhxanh == false || daudo == false || thanhlongtrang == false || nhotim == false || duduvang == false)
        //    {
        //        timeout.Visibility = Visibility.Visible;

        //        Uri uri = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/timeout.mp3"); // "/PuzzleGame;component/Sound/Ilikeme.wav", UriKind.Relative, browsing to the sound folder and then the WAV file location
        //        playMedia.Open(uri); // inserting the URI to the media player
        //        playMedia.Play();
        //        if (checkpoint == true)
        //        {
        //            playMedia.Stop();
        //        }
        //        Canvas1.IsEnabled = false;
        //    }
        //    Countdown.Remove(this);
        //}

        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            nhotim = false;
            duduvang = false;
            chanhxanh = false;
            daudo = false;
            thanhlongtrang = false;
            checkpoint = true;
            //Countdown.Stop(this);
            //Countdown.Remove(this);
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

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            //Pause1.IsEnabled = true;
            playMedia.Stop();

            Global.dem = 4;
            //Man2 man2 = new Man2();
            //Global.menutest.oc.Children.Add(man2);
            //Global.menutest.round2.Width = 300;

            Global.menutest.imground5.ImageSource = new BitmapImage(new Uri(@"D:\ĐỒ ÁN TN\GitHub\Game\PuzzleGame\PuzzleGame\Images\Game1\Round5\barber.png"));
            this.Visibility = Visibility.Collapsed;

            nhotim = false;
            duduvang = false;
            chanhxanh = false;
            daudo = false;
            thanhlongtrang = false;
            Man5 man5 = new Man5();
            Global.menutest.oc.Children.Add(man5);

        }

        private void Replay_Click(object sender, RoutedEventArgs e)

        {
            Canvas1.IsEnabled = true;
            //Countdown.Begin(this, true);
            //Pause1.IsEnabled = true;
            report.Visibility = Visibility.Hidden;
            //timeout.Visibility = Visibility.Collapsed;
            
            playMedia.Stop();
            replay = true;
            if (replay == true)
            {
                moving = false;
                nhotim = false;
                duduvang = false;
                chanhxanh = false;
                daudo = false;
                thanhlongtrang = false;
                BasePointChanh.X = 850;
                BasePointChanh.Y = 480;
                chanhgoc.Visibility = Visibility.Collapsed;
                chanh.Visibility = Visibility.Visible;
                quachanh.Visibility = Visibility.Visible;
                RaisePropertyChanged("XPositionChanh");
                RaisePropertyChanged("YPositionChanh");
                BasePointDau.X = 350;
                BasePointDau.Y = 480;
                daugoc.Visibility = Visibility.Collapsed;
                dau.Visibility = Visibility.Visible;
                quadau.Visibility = Visibility.Visible;
                RaisePropertyChanged("XPositionDau");
                RaisePropertyChanged("YPositionDau");
                BasePointDuDu.X = 400;
                BasePointDuDu.Y = 330;
                dudugoc.Visibility = Visibility.Collapsed;
                dudu.Visibility = Visibility.Visible;
                quadudu.Visibility = Visibility.Visible;
                RaisePropertyChanged("XPositionDuDu");
                RaisePropertyChanged("YPositionDuDu");

                BasePointNho.X = 440;
                BasePointNho.Y = 480;
                nhogoc.Visibility = Visibility.Collapsed;
                nho.Visibility = Visibility.Visible;
                quanho.Visibility = Visibility.Visible;
                RaisePropertyChanged("XPositionNho");
                RaisePropertyChanged("YPositionNho");

                BasePointThanhLong.X = 290;
                BasePointThanhLong.Y = 450;
                thanhlonggoc.Visibility = Visibility.Collapsed;
                thanhlong.Visibility = Visibility.Visible;
                quathanhlong.Visibility = Visibility.Visible;
                RaisePropertyChanged("XPositionThanhLong");
                RaisePropertyChanged("YPositionThanhLong");
               





            }
        }

        private void Feast_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image l = e.Source as Image;
            if (l != null)
            {

                if (l.Name == "chanh" && chanhxanh == false)
                {
                    chanh.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(chanh);

                    Panel.SetZIndex(chanh, 6);
                    Panel.SetZIndex(nho, 3);
                    Panel.SetZIndex(dudu, 1);
                    Panel.SetZIndex(dau, 3);
                    Panel.SetZIndex(thanhlong, 1);
                }
                if (l.Name == "dau" && daudo == false)
                {
                    dau.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(dau);

                    Panel.SetZIndex(chanh, 1);
                    Panel.SetZIndex(nho, 3);
                    Panel.SetZIndex(dudu, 1);
                    Panel.SetZIndex(dau, 6);
                    Panel.SetZIndex(thanhlong, 1);

                }
                if (l.Name == "nho" && nhotim == false)
                {
                    nho.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(nho);
                    Panel.SetZIndex(chanh, 1);
                    Panel.SetZIndex(nho, 6);
                    Panel.SetZIndex(dudu, 1);
                    Panel.SetZIndex(dau, 3);
                    Panel.SetZIndex(thanhlong, 1);


                }
                if (l.Name == "thanhlong" && thanhlongtrang == false)
                {
                    thanhlong.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(thanhlong);
                    Panel.SetZIndex(chanh, 1);
                    Panel.SetZIndex(nho, 3);
                    Panel.SetZIndex(dudu, 1);
                    Panel.SetZIndex(dau, 3);
                    Panel.SetZIndex(thanhlong, 6);

                }
                if (l.Name == "dudu" && duduvang == false)
                {
                    dudu.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(dudu);
                    Panel.SetZIndex(chanh, 1);
                    Panel.SetZIndex(nho, 3);
                    Panel.SetZIndex(dudu, 6);
                    Panel.SetZIndex(dau, 3);
                    Panel.SetZIndex(thanhlong, 1);

                }
                playMedia.Stop();



            }
        }

        private void Feast_MouseUp(object sender, MouseButtonEventArgs e)
        {
            double xchanh = Canvas.GetLeft(quachanh);
            double ychanh = Canvas.GetTop(quachanh);
            double xdau = Canvas.GetLeft(quadau);
            double ydau = Canvas.GetTop(quadau);
            double xdudu = Canvas.GetLeft(quadudu);
            double ydudu = Canvas.GetTop(quadudu);
            double xnho = Canvas.GetLeft(quanho);
            double ynho = Canvas.GetTop(quanho);
            double xthanhlong = Canvas.GetLeft(quathanhlong);
            double ythanhlong = Canvas.GetTop(quathanhlong);

            Image l = e.Source as Image;
            if (l != null)
            {
                if (l.Name == "chanh")
                {
                    chanh.ReleaseMouseCapture();
                    BasePointChanh.X += DeltaXChanh;
                    BasePointChanh.Y += DeltaYChanh;
                    DeltaXChanh = 0.0;
                    DeltaYChanh = 0.0;
                    moving = false;
                    if ((((BasePointChanh.X - 50) < xchanh) && (BasePointChanh.X + 50) > xchanh) && (((BasePointChanh.Y - 50) < ychanh) && ((BasePointChanh.Y + 50) > ychanh)))
                    {
                        chanhgoc.Visibility = Visibility.Visible;
                        chanh.Visibility = Visibility.Collapsed;
                        quachanh.Visibility = Visibility.Collapsed;
                        chanhxanh = true;
                        Uri ting = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/Ting.mp3");
                        playMedia.Open(ting);
                        playMedia.Play();
                        

                    }
                }
                if (l.Name == "dau")
                {
                    dau.ReleaseMouseCapture();
                    BasePointDau.X += DeltaXDau;
                    BasePointDau.Y += DeltaYDau;
                    DeltaXDau = 0.0;
                    DeltaYDau = 0.0;
                    moving = false;
                    if ((((BasePointDau.X - 100) < xdau) && (BasePointDau.X + 50) > xdau) && (((BasePointDau.Y - 60) < ydau) && ((BasePointDau.Y + 40) > ydau)))
                    {
                        daugoc.Visibility = Visibility.Visible;
                        dau.Visibility = Visibility.Collapsed;
                        quadau.Visibility = Visibility.Collapsed;
                        daudo = true;
                        Uri ting = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/Ting.mp3");
                        playMedia.Open(ting);
                        playMedia.Play();


                    }
                }
                if (l.Name == "nho")
                {
                    nho.ReleaseMouseCapture();
                    BasePointNho.X += DeltaXNho;
                    BasePointNho.Y += DeltaYNho;
                    DeltaXNho = 0.0;
                    DeltaYNho = 0.0;
                    moving = false;
                    if ((((BasePointNho.X - 30) < xnho) && (BasePointNho.X + 30) > xnho) && (((BasePointNho.Y - 120) < ynho) && ((BasePointNho.Y + 20) > ynho)))
                    {
                        nhogoc.Visibility = Visibility.Visible;
                        nho.Visibility = Visibility.Collapsed;
                        quanho.Visibility = Visibility.Collapsed;
                        nhotim = true;
                        Uri ting = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/Ting.mp3");
                        playMedia.Open(ting);
                        playMedia.Play();


                    }
                }
                if (l.Name == "thanhlong")
                {
                    thanhlong.ReleaseMouseCapture();
                    BasePointThanhLong.X += DeltaXThanhLong;
                    BasePointThanhLong.Y += DeltaYThanhLong;
                    DeltaXThanhLong = 0.0;
                    DeltaYThanhLong = 0.0;
                    moving = false;
                    if ((((BasePointThanhLong.X - 50) < xthanhlong) && (BasePointThanhLong.X + 50) > xthanhlong) && (((BasePointThanhLong.Y - 80) < ythanhlong) && ((BasePointThanhLong.Y + 50) > ythanhlong)))
                    {
                        thanhlonggoc.Visibility = Visibility.Visible;
                        thanhlong.Visibility = Visibility.Collapsed;
                        quathanhlong.Visibility = Visibility.Collapsed;
                        thanhlongtrang = true;
                        Uri ting = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/Ting.mp3");
                        playMedia.Open(ting);
                        playMedia.Play();


                    }
                }
                if (l.Name == "dudu")
                {
                    dudu.ReleaseMouseCapture();
                    BasePointDuDu.X += DeltaXDuDu;
                    BasePointDuDu.Y += DeltaYDuDu;
                    DeltaXDuDu= 0.0;
                    DeltaYDuDu = 0.0;
                    moving = false;
                    if ((((BasePointDuDu.X - 50) < xdudu) && (BasePointDuDu.X + 50) > xdudu) && (((BasePointDuDu.Y - 50) < ydudu) && ((BasePointDuDu.Y + 50) > ydudu)))
                    {
                        dudugoc.Visibility = Visibility.Visible;
                        dudu.Visibility = Visibility.Collapsed;
                        quadudu.Visibility = Visibility.Collapsed;
                        duduvang = true;
                        Uri ting = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/Ting.mp3");
                        playMedia.Open(ting);
                        playMedia.Play();


                    }
                }

            }
            if (chanhxanh == true && daudo == true && nhotim == true && thanhlongtrang == true && duduvang == true )
            {
                report.Visibility = Visibility.Visible;
                //Pause1.IsEnabled = false;
                Uri uri = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/chucmung.mp3"); // "/PuzzleGame;component/Sound/Ilikeme.wav", UriKind.Relative, browsing to the sound folder and then the WAV file location
                playMedia.Open(uri); // inserting the URI to the media player
                playMedia.Play();
                //Countdown.Stop(this);
                //Countdown.Remove(this);
            }
        }

        private void Feast_MouseMove(object sender, MouseEventArgs e)
        {
            


            if (moving)
            {
                Image l = e.Source as Image;
                if (l.Name == "chanh")
                {
                    Point p = e.GetPosition(null);
                    DeltaXChanh = p.X - BasePointChanh.X - PositionImage.X;
                    DeltaYChanh = p.Y - BasePointChanh.Y - PositionImage.Y;
                    BasePointChanh.X += DeltaXChanh;
                    BasePointChanh.Y += DeltaYChanh;
                    RaisePropertyChanged("XPositionChanh");
                    RaisePropertyChanged("YPositionChanh");
                    

                }
                if (l.Name == "dau")
                {
                    Point p = e.GetPosition(null);
                    DeltaXDau = p.X - BasePointDau.X - PositionImage.X;
                    DeltaYDau = p.Y - BasePointDau.Y - PositionImage.Y;
                    BasePointDau.X += DeltaXDau;
                    BasePointDau.Y += DeltaYDau;
                    RaisePropertyChanged("XPositionDau");
                    RaisePropertyChanged("YPositionDau");
                   

                }
                if (l.Name == "nho")
                {
                    Point p = e.GetPosition(null);
                    DeltaXNho = p.X - BasePointNho.X - PositionImage.X;
                    DeltaYNho = p.Y - BasePointNho.Y - PositionImage.Y;
                    BasePointNho.X += DeltaXNho;
                    BasePointNho.Y += DeltaYNho;
                    RaisePropertyChanged("XPositionNho");
                    RaisePropertyChanged("YPositionNho");
                   

                }
                if (l.Name == "dudu")
                {
                    Point p = e.GetPosition(null);
                    DeltaXDuDu = p.X - BasePointDuDu.X - PositionImage.X;
                    DeltaYDuDu = p.Y - BasePointDuDu.Y - PositionImage.Y;
                    BasePointDuDu.X += DeltaXDuDu;
                    BasePointDuDu.Y += DeltaYDuDu;
                    RaisePropertyChanged("XPositionDuDu");
                    RaisePropertyChanged("YPositionDuDu");
                   

                }
                if (l.Name == "thanhlong")
                {
                    Point p = e.GetPosition(null);
                    DeltaXThanhLong = p.X - BasePointThanhLong.X - PositionImage.X;
                    DeltaYThanhLong = p.Y - BasePointThanhLong.Y - PositionImage.Y;
                    BasePointThanhLong.X += DeltaXThanhLong;
                    BasePointThanhLong.Y += DeltaYThanhLong;
                    RaisePropertyChanged("XPositionThanhLong");
                    RaisePropertyChanged("YPositionThanhLong");
                    

                }
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

      
   
