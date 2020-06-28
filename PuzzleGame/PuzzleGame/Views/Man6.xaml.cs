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
    /// Interaction logic for Man6.xaml
    /// </summary>
    public partial class Man6 : UserControl   , INotifyPropertyChanged
    {
        private Point BasePointPoliceCar = new Point(1100, 100);
        private Point BasePointFerarri = new Point(350, 480);
        private Point BasePointToyota = new Point(850, 50.0);
        private Point BasePointBus = new Point(100, 120);
        private Point BasePointKem = new Point(600, 330);
        private double DeltaXPoliceCar = 0.0;
        private double DeltaYPoliceCar = 0.0;
        private double DeltaXFerarri = 0.0;
        private double DeltaYFerarri = 0.0;
        private double DeltaXToyota = 0.0;
        private double DeltaYToyota = 0.0;
        private double DeltaXBus = 0.0;
        private double DeltaYBus = 0.0;
        private double DeltaXKem = 0.0;
        private double DeltaYKem = 0.0;
        private bool moving = false;
        private Point PositionImage;
        private static bool xecs = false;
        private static bool xek = false;//không cho chọn khi đúng hình;
        private static bool xef = false;
        private static bool xet = false;
        private static bool xeb = false;
        private bool checkpoint = false;
        private bool replay = false;
        //private int temp = 0;
        MediaPlayer playMedia = new MediaPlayer();
        public double XPositionPoliceCar
        {
            get { return BasePointPoliceCar.X + DeltaXPoliceCar; }
        }

        public double YPositionPoliceCar
        {
            get { return BasePointPoliceCar.Y + DeltaYPoliceCar; }
        }
        public double XPositionFerarri
        {
            get { return BasePointFerarri.X + DeltaXFerarri; }
        }

        public double YPositionFerarri
        {
            get { return BasePointFerarri.Y + DeltaYFerarri; }
        }
        public double XPositionToyota
        {
            get { return BasePointToyota.X + DeltaXToyota; }
        }

        public double YPositionToyota
        {
            get { return BasePointToyota.Y + DeltaYToyota; }
        }
        public double XPositionBus
        {
            get { return BasePointBus.X + DeltaXBus; }
        }

        public double YPositionBus
        {
            get { return BasePointBus.Y + DeltaYBus; }
        }
        public double XPositionKem
        {
            get { return BasePointKem.X + DeltaXKem; }
        }

        public double YPositionKem
        {
            get { return BasePointKem.Y + DeltaYKem; }
        }
        public Man6()
        {
            InitializeComponent();
            this.DataContext = this;
           
        }

       
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            xet = false;
            xef = false;
            xef = false;
            xecs = false;
            xeb = false;
            checkpoint = true;
           
        }

        private void Replay_Click(object sender, RoutedEventArgs e)
        {
            Canvas1.IsEnabled = true;
          
            report.Visibility = Visibility.Hidden;
            timeout.Visibility = Visibility.Collapsed;

            playMedia.Stop();
            replay = true;
            if (replay == true)
            {
                moving = false;
                xet = false;
                xek = false;
                xecs = false;
                xeb = false;
                xef = false;
                BasePointPoliceCar.X = 1100;
                BasePointPoliceCar.Y = 100;
               
                RaisePropertyChanged("XPositionPoliceCar");
                RaisePropertyChanged("YPositionPoliceCar");
                BasePointKem.X = 600;
                BasePointKem.Y = 330;
               
                RaisePropertyChanged("XPositionKem");
                RaisePropertyChanged("YPositionKem");
                BasePointFerarri.X = 350;
                BasePointFerarri.Y = 480;
                
                RaisePropertyChanged("XPositionFerarri");
                RaisePropertyChanged("YPositionFerarri");

                BasePointBus.X = 100;
                BasePointBus.Y = 120;
                
                RaisePropertyChanged("XPositionBus");
                RaisePropertyChanged("YPositionBus");

                BasePointToyota.X = 850;
                BasePointToyota.Y = 50;
                
                RaisePropertyChanged("XPositionToyota");
                RaisePropertyChanged("YPositionToyota");






            }
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
           
            playMedia.Stop();

            this.Visibility = Visibility.Collapsed;

            xeb = false;
            xecs = false;
            xef = false;
            xek = false;
            xet = false;
        }

        //private void Pause1_Click(object sender, RoutedEventArgs e)
        //{
            
        //    Canvas1.IsEnabled = false;
        //    Canvas1.Focusable = false;
        //}

        //private void Resume1_Click(object sender, RoutedEventArgs e)
        //{
           
        //    Canvas1.IsEnabled = true;
        //    Canvas1.Focusable = true;
        //}

        private void Feast_MouseUp(object sender, MouseButtonEventArgs e)
        {
            double xkem = Canvas.GetLeft(xekem);
            double ykem = Canvas.GetTop(xekem);
            double xferarri = Canvas.GetLeft(xeferarri);
            double yferarri = Canvas.GetTop(xeferarri);
            double xpolice = Canvas.GetLeft(xepolice);
            double ypolice = Canvas.GetTop(xepolice);
            double xbuyt = Canvas.GetLeft(xebuyt);
            double ybuyt = Canvas.GetTop(xebuyt);
            double xtoyota = Canvas.GetLeft(xetoyota);
            double ytoyota = Canvas.GetTop(xetoyota);

            Image l = e.Source as Image;
            if (l != null)
            {
                if (l.Name == "xebus")
                {
                    xebus.ReleaseMouseCapture();
                    BasePointBus.X += DeltaXBus;
                    BasePointBus.Y += DeltaYBus;
                    DeltaXBus = 0.0;
                    DeltaYBus = 0.0;
                    moving = false;
                    if ((((BasePointBus.X - 50) < xbuyt) && (BasePointBus.X + 50) > xbuyt) && (((BasePointBus.Y - 50) < ybuyt) && ((BasePointBus.Y + 50) > ybuyt)))
                    {
                        BasePointBus.X = xbuyt;
                        BasePointBus.Y = ybuyt;
                        RaisePropertyChanged("XPositionBus");
                        RaisePropertyChanged("YPositionBus");
                        xeb = true;
                        Uri ting = new Uri(@"..\..\Sound\Ting.mp3", UriKind.Relative);
                        playMedia.Open(ting);
                        playMedia.Play();


                    }
                }
                if (l.Name == "xecanhsat")
                {
                    xecanhsat.ReleaseMouseCapture();
                    BasePointPoliceCar.X += DeltaXPoliceCar;
                    BasePointPoliceCar.Y += DeltaYPoliceCar;
                    DeltaXPoliceCar = 0.0;
                    DeltaYPoliceCar = 0.0;
                    moving = false;
                    if ((((BasePointPoliceCar.X - 100) < xpolice) && (BasePointPoliceCar.X + 50) > xpolice) && (((BasePointPoliceCar.Y - 60) < ypolice) && ((BasePointPoliceCar.Y + 40) > ypolice)))
                    {
                        BasePointPoliceCar.X = xpolice;
                        BasePointPoliceCar.Y = ypolice;
                        RaisePropertyChanged("XPositionPoliceCar");
                        RaisePropertyChanged("YPositionPoliceCar");
                        xecs = true;
                        Uri ting = new Uri(@"..\..\Sound\Ting.mp3", UriKind.Relative);
                        playMedia.Open(ting);
                        playMedia.Play();


                    }
                }
                if (l.Name == "xe4cho")
                {
                    xe4cho.ReleaseMouseCapture();
                    BasePointToyota.X += DeltaXToyota;
                    BasePointToyota.Y += DeltaYToyota;
                    DeltaXToyota = 0.0;
                    DeltaYToyota = 0.0;
                    moving = false;
                    if ((((BasePointToyota.X - 30) < xtoyota) && (BasePointToyota.X + 30) > xtoyota) && (((BasePointToyota.Y - 120) < ytoyota) && ((BasePointToyota.Y + 20) > ytoyota)))
                    {
                        BasePointToyota.X = xtoyota;
                        BasePointToyota.Y = ytoyota;
                        RaisePropertyChanged("XPositionToyota");
                        RaisePropertyChanged("YPositionToyota");
                        xet = true;
                        Uri ting = new Uri(@"..\..\Sound\Ting.mp3", UriKind.Relative);
                        playMedia.Open(ting);
                        playMedia.Play();


                    }
                }
                if (l.Name == "sieuxe")
                {
                    sieuxe.ReleaseMouseCapture();
                    BasePointFerarri.X += DeltaXFerarri;
                    BasePointFerarri.Y += DeltaYFerarri;
                    DeltaXFerarri = 0.0;
                    DeltaYFerarri = 0.0;
                    moving = false;
                    if ((((BasePointFerarri.X - 50) < xferarri) && (BasePointFerarri.X + 50) > xferarri) && (((BasePointFerarri.Y - 80) < yferarri) && ((BasePointFerarri.Y + 50) > yferarri)))
                    {
                        BasePointFerarri.X = xferarri;
                        BasePointFerarri.Y = yferarri;
                        RaisePropertyChanged("XPositionFerarri");
                        RaisePropertyChanged("YPositionFerarri");
                        xef = true;
                        Uri ting = new Uri(@"..\..\Sound\Ting.mp3", UriKind.Relative);
                        playMedia.Open(ting);
                        playMedia.Play();


                    }
                }
                if (l.Name == "xekemlanh")
                {
                   xekemlanh.ReleaseMouseCapture();
                    BasePointKem.X += DeltaXKem;
                    BasePointKem.Y += DeltaYKem;
                    DeltaXKem = 0.0;
                    DeltaYKem = 0.0;
                    moving = false;
                    if ((((BasePointKem.X - 50) < xkem) && (BasePointKem.X + 50) > xkem) && (((BasePointKem.Y - 50) < ykem) && ((BasePointKem.Y + 50) > ykem)))
                    {
                        BasePointKem.X = xkem;
                        BasePointKem.Y = ykem;
                        RaisePropertyChanged("XPositionKem");
                        RaisePropertyChanged("YPositionKem");
                        xek = true;
                        Uri ting = new Uri(@"..\..\Sound\Ting.mp3", UriKind.Relative);
                        playMedia.Open(ting);
                        playMedia.Play();


                    }
                }

            }
            if (xet == true && xecs == true && xef == true && xek == true && xeb == true)
            {
                report.Visibility = Visibility.Visible;

                Uri ting = new Uri(@"..\..\Sound\chucmung.mp3", UriKind.Relative); // "/PuzzleGame;component/Sound/Ilikeme.wav", UriKind.Relative, browsing to the sound folder and then the WAV file location
                playMedia.Open(ting); // inserting the URI to the media player
                playMedia.Play();
              
            }
        }

        private void Feast_MouseMove(object sender, MouseEventArgs e)
        {

            if (moving)
            {
                Image l = e.Source as Image;
                if (l.Name == "xebus")
                {
                    Point p = e.GetPosition(null);
                    DeltaXBus = p.X - BasePointBus.X - PositionImage.X;
                    DeltaYBus = p.Y - BasePointBus.Y - PositionImage.Y;
                    BasePointBus.X += DeltaXBus;
                    BasePointBus.Y += DeltaYBus;
                    RaisePropertyChanged("XPositionBus");
                    RaisePropertyChanged("YPositionBus");


                }
                if (l.Name == "xecanhsat")
                {
                    Point p = e.GetPosition(null);
                    DeltaXPoliceCar = p.X - BasePointPoliceCar.X - PositionImage.X;
                    DeltaYPoliceCar = p.Y - BasePointPoliceCar.Y - PositionImage.Y;
                    BasePointPoliceCar.X += DeltaXPoliceCar;
                    BasePointPoliceCar.Y += DeltaYPoliceCar;
                    RaisePropertyChanged("XPositionPoliceCar");
                    RaisePropertyChanged("YPositionPoliceCar");


                }
                if (l.Name == "xe4cho")
                {
                    Point p = e.GetPosition(null);
                    DeltaXToyota = p.X - BasePointToyota.X - PositionImage.X;
                    DeltaYToyota = p.Y - BasePointToyota.Y - PositionImage.Y;
                    BasePointToyota.X += DeltaXToyota;
                    BasePointToyota.Y += DeltaYToyota;
                    RaisePropertyChanged("XPositionToyota");
                    RaisePropertyChanged("YPositionToyota");


                }
                if (l.Name == "sieuxe")
                {
                    Point p = e.GetPosition(null);
                    DeltaXFerarri= p.X - BasePointFerarri.X - PositionImage.X;
                    DeltaYFerarri = p.Y - BasePointFerarri.Y - PositionImage.Y;
                    BasePointFerarri.X += DeltaXFerarri;
                    BasePointFerarri.Y += DeltaYFerarri;
                    RaisePropertyChanged("XPositionFerarri");
                    RaisePropertyChanged("YPositionFerarri");


                }
                if (l.Name == "xekemlanh")
                {
                    Point p = e.GetPosition(null);
                    DeltaXKem = p.X - BasePointKem.X - PositionImage.X;
                    DeltaYKem = p.Y - BasePointKem.Y - PositionImage.Y;
                    BasePointKem.X += DeltaXKem;
                    BasePointKem.Y += DeltaYKem;
                    RaisePropertyChanged("XPositionKem");
                    RaisePropertyChanged("YPositionKem");


                }
            }
        }

        private void Feast_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image l = e.Source as Image;
            if (l != null)
            {

                if (l.Name == "xebus" && xeb == false)
                {
                    xebus.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(xebus);

                    Panel.SetZIndex(xebus, 6);
                    Panel.SetZIndex(xecanhsat, 3);
                    Panel.SetZIndex(sieuxe, 1);
                    Panel.SetZIndex(xe4cho, 3);
                    Panel.SetZIndex(xekemlanh, 1);
                }
                if (l.Name == "xecanhsat" && xecs == false)
                {
                    xecanhsat.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(xecanhsat);

                    Panel.SetZIndex(xebus, 2);
                    Panel.SetZIndex(xecanhsat, 6);
                    Panel.SetZIndex(sieuxe, 1);
                    Panel.SetZIndex(xe4cho, 3);
                    Panel.SetZIndex(xekemlanh, 1);

                }
                if (l.Name == "sieuxe" && xef == false)
                {
                    sieuxe.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(sieuxe);
                    Panel.SetZIndex(xebus, 2);
                    Panel.SetZIndex(xecanhsat, 3);
                    Panel.SetZIndex(sieuxe, 6);
                    Panel.SetZIndex(xe4cho, 3);
                    Panel.SetZIndex(xekemlanh, 1);


                }
                if (l.Name == "xe4cho" && xet == false)
                {
                    xe4cho.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(xe4cho);
                    Panel.SetZIndex(xebus, 2);
                    Panel.SetZIndex(xecanhsat, 3);
                    Panel.SetZIndex(sieuxe, 1);
                    Panel.SetZIndex(xe4cho, 6);
                    Panel.SetZIndex(xekemlanh, 1);

                }
                if (l.Name == "xekemlanh" && xek == false)
                {
                    xekemlanh.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(xekemlanh);
                    Panel.SetZIndex(xebus, 2);
                    Panel.SetZIndex(xecanhsat, 3);
                    Panel.SetZIndex(sieuxe, 1);
                    Panel.SetZIndex(xe4cho, 3);
                    Panel.SetZIndex(xekemlanh, 6);

                }
                playMedia.Stop();



            }
        }
    }
}
