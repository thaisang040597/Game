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
    /// Interaction logic for Man5.xaml
    /// </summary>
    public partial class Man5 : UserControl , INotifyPropertyChanged
    {
        private Point BasePointPolice = new Point(750, 450);
        private Point BasePointBarber = new Point(450, 450);
        private Point BasePointTeacher = new Point(350, 420.0);
        private Point BasePointChef = new Point(150, 450);
        private double DeltaXPolice = 0.0;
        private double DeltaYPolice = 0.0;
        private double DeltaXBarber = 0.0;
        private double DeltaYBarber = 0.0;
        private double DeltaXChef = 0.0;
        private double DeltaYChef = 0.0;
        private double DeltaXTeacher = 0.0;
        private double DeltaYTeacher = 0.0;
        private bool moving = false;
        private Point PositionImage;
        private static bool canhsat = false;
        private static bool cattoc = false;//không cho chọn khi đúng hình;
        private static bool giaovien = false;
        private static bool daubep = false;
       
        private bool checkpoint = false;
        private bool replay = false;
        //private int temp = 0;
        MediaPlayer playMedia = new MediaPlayer();
        public double XPositionPolice
        {
            get { return BasePointPolice.X + DeltaXPolice; }
        }

        public double YPositionPolice
        {
            get { return BasePointPolice.Y + DeltaYPolice; }
        }
        public double XPositionBarber
        {
            get { return BasePointBarber.X + DeltaXBarber; }
        }

        public double YPositionBarber
        {
            get { return BasePointBarber.Y + DeltaYBarber; }
        }
        public double XPositionTeacher
        {
            get { return BasePointTeacher.X + DeltaXTeacher; }
        }

        public double YPositionTeacher
        {
            get { return BasePointTeacher.Y + DeltaYTeacher; }
        }
        public double XPositionChef
        {
            get { return BasePointChef.X + DeltaXChef; }
        }

        public double YPositionChef
        {
            get { return BasePointChef.Y + DeltaYChef; }
        }
        public Man5()
        {
            InitializeComponent();
            this.DataContext = this;
            //Countdown.Completed += new EventHandler(Story_completed);

        }

        //private void Story_completed(object sender, EventArgs e)
        //{
        //    if (canhsat == false || giaovien == false || cattoc == false || daubep == false )
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

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            cattoc = false;
            canhsat = false;
            giaovien = false;
            daubep = false;
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

            Global.dem = 5;
            //Man2 man2 = new Man2();
            //Global.menutest.oc.Children.Add(man2);
            //Global.menutest.round2.Width = 300;

            //Global.menutest.imground6.ImageSource = new BitmapImage(new Uri(@"D:\ĐỒ ÁN TN\GitHub\Game\PuzzleGame\PuzzleGame\Images\Game1\Round6\xedap.png"));
            this.Visibility = Visibility.Collapsed;

            canhsat = false;
            cattoc = false;
            daubep = false;
            giaovien = false;
            Man6 man6 = new Man6();
            Global.menutest.oc.Children.Add(man6);


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
                daubep = false;
                giaovien = false;
                cattoc = false;
                canhsat = false;
                
                BasePointPolice.X = 750;
                BasePointPolice.Y = 450;
              
                RaisePropertyChanged("XPositionPolice");
                RaisePropertyChanged("YPositionPolice");
                BasePointBarber.X = 450;
                BasePointBarber.Y = 450;
              
                RaisePropertyChanged("XPositionBarber");
                RaisePropertyChanged("YPositionBarber");
                BasePointChef.X = 150;
                BasePointChef.Y = 450;
               
                RaisePropertyChanged("XPositionChef");
                RaisePropertyChanged("YPositionChef");

                BasePointTeacher.X = 350;
                BasePointTeacher.Y = 420;
               
                RaisePropertyChanged("XPositionTeacher");
                RaisePropertyChanged("YPositionTeacher");

            }
        }
        private void Feast_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image l = e.Source as Image;
            if (l != null)
            {

                if (l.Name == "police" && canhsat == false)
                {
                    police.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(police);

                    Panel.SetZIndex(police, 6);
                    Panel.SetZIndex(teacher, 3);
                    Panel.SetZIndex(barber, 1);
                    Panel.SetZIndex(chef, 3);

                }
                if (l.Name == "teacher" && giaovien == false)
                {
                    teacher.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(teacher);

                    Panel.SetZIndex(police, 3);
                    Panel.SetZIndex(teacher, 6);
                    Panel.SetZIndex(barber, 1);
                    Panel.SetZIndex(chef, 3);

                }
                if (l.Name == "barber" && cattoc == false)
                {
                    barber.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(barber);

                    Panel.SetZIndex(police, 2);
                    Panel.SetZIndex(teacher, 3);
                    Panel.SetZIndex(barber, 6);
                    Panel.SetZIndex(chef, 3);

                }
                if (l.Name == "chef" && daubep == false)
                {
                    chef.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(chef);

                    Panel.SetZIndex(police, 1);
                    Panel.SetZIndex(teacher, 3);
                    Panel.SetZIndex(barber, 1);
                    Panel.SetZIndex(chef, 6);

                }
                playMedia.Stop();
            }
        }
        private void Feast_MouseUp(object sender, MouseButtonEventArgs e)
        {
            double xpolice = Canvas.GetLeft(policeoffice);
            double ypolice = Canvas.GetTop(policeoffice);
            double xschool = Canvas.GetLeft(school);
            double yschool = Canvas.GetTop(school);
            double xbarber = Canvas.GetLeft(shopbarber);
            double ybarber = Canvas.GetTop(shopbarber);
            double xchef = Canvas.GetLeft(restaurant);
            double ychef = Canvas.GetTop(restaurant);
            Image l = e.Source as Image;
            if (l != null)
            {
                if (l.Name == "police")
                {
                    police.ReleaseMouseCapture();
                    BasePointPolice.X += DeltaXPolice;
                    BasePointPolice.Y += DeltaYPolice;
                    DeltaXPolice = 0.0;
                    DeltaYPolice = 0.0;
                    moving = false;
                    if ((((BasePointPolice.X - 200) < XPositionBarber) && (BasePointPolice.X +50) > xpolice) && (((BasePointPolice.Y - 150) < ypolice) && ((BasePointPolice.Y + 50) > ypolice)))
                    {
                        BasePointPolice.X = 435;
                        BasePointPolice.Y = 400;
                        RaisePropertyChanged("XPositionPolice");
                        RaisePropertyChanged("YPositionPolice");
                        canhsat = true;
                        Uri ting = new Uri(@"..\..\Sound\Ting.mp3", UriKind.Relative);
                        playMedia.Open(ting);
                        playMedia.Play();


                    }
                }
                if (l.Name == "barber")
                {
                    barber.ReleaseMouseCapture();
                    BasePointBarber.X += DeltaXBarber;
                    BasePointBarber.Y += DeltaYBarber;
                    DeltaXBarber = 0.0;
                    DeltaYBarber = 0.0;
                    moving = false;
                    if ((((BasePointBarber.X - 200) < xbarber) && (BasePointBarber.X + 100) > xbarber) && (((BasePointBarber.Y - 150) < ybarber) && ((BasePointBarber.Y + 100) > ybarber)))
                    {
                        BasePointBarber.X = 215;
                        BasePointBarber.Y = 400;
                        RaisePropertyChanged("XPositionBarber");
                        RaisePropertyChanged("YPositionBarber");
                        cattoc = true;
                        Uri ting = new Uri(@"..\..\Sound\Ting.mp3", UriKind.Relative);
                        playMedia.Open(ting);
                        playMedia.Play();


                    }
                }
                if (l.Name == "teacher")
                {
                    teacher.ReleaseMouseCapture();
                    BasePointTeacher.X += DeltaXTeacher;
                    BasePointTeacher.Y += DeltaYTeacher;
                    DeltaXTeacher = 0.0;
                    DeltaYTeacher = 0.0;
                    moving = false;
                    if ((((BasePointTeacher.X - 200) < xschool) && (BasePointTeacher.X + 50) > xschool) && (((BasePointTeacher.Y - 120) < yschool) && ((BasePointTeacher.Y + 50) > yschool)))
                    {
                        BasePointTeacher.X = 1180;
                        BasePointTeacher.Y =400;
                        RaisePropertyChanged("XPositionTeacher");
                        RaisePropertyChanged("YPositionTeacher");
                        giaovien = true;
                        Uri ting = new Uri(@"..\..\Sound\Ting.mp3", UriKind.Relative);
                        playMedia.Open(ting);
                        playMedia.Play();


                    }
                }
                if (l.Name == "chef")
                {
                    chef.ReleaseMouseCapture();
                    BasePointChef.X += DeltaXChef;
                    BasePointChef.Y += DeltaYChef;
                    DeltaXChef = 0.0;
                    DeltaYChef = 0.0;
                    moving = false;
                    if ((((BasePointChef.X - 200) < xchef) && (BasePointChef.X + 50) > xchef) && (((BasePointChef.Y - 150) < ychef) && ((BasePointChef.Y + 50) > ychef)))
                    {
                        BasePointChef.X = 750;
                        BasePointChef.Y =400;
                        RaisePropertyChanged("XPositionChef");
                        RaisePropertyChanged("YPositionChef");
                        daubep = true;
                        Uri ting = new Uri(@"..\..\Sound\Ting.mp3", UriKind.Relative);
                        playMedia.Open(ting);
                        playMedia.Play();


                    }
                }
            }
            if (canhsat == true && giaovien == true && cattoc == true && daubep == true )
            {
                report.Visibility = Visibility.Visible;
                //Pause1.IsEnabled = false;
                Uri ting = new Uri(@"..\..\Sound\chucmung.mp3", UriKind.Relative); // "/PuzzleGame;component/Sound/Ilikeme.wav", UriKind.Relative, browsing to the sound folder and then the WAV file location
                playMedia.Open(ting); // inserting the URI to the media player
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
                if (l.Name == "police")
                {
                    Point p = e.GetPosition(null);
                    DeltaXPolice = p.X - BasePointPolice.X - PositionImage.X;
                    DeltaYPolice = p.Y - BasePointPolice.Y - PositionImage.Y;
                    BasePointPolice.X += DeltaXPolice;
                    BasePointPolice.Y += DeltaYPolice;
                    RaisePropertyChanged("XPositionPolice");
                    RaisePropertyChanged("YPositionPolice");


                }
                if (l.Name == "teacher")
                {
                    Point p = e.GetPosition(null);
                    DeltaXTeacher = p.X - BasePointTeacher.X - PositionImage.X;
                    DeltaYTeacher = p.Y - BasePointTeacher.Y - PositionImage.Y;
                    BasePointTeacher.X += DeltaXTeacher;
                    BasePointTeacher.Y += DeltaYTeacher;
                    RaisePropertyChanged("XPositionTeacher");
                    RaisePropertyChanged("YPositionTeacher");


                }
                if (l.Name == "barber")
                {
                    Point p = e.GetPosition(null);
                    DeltaXBarber = p.X - BasePointBarber.X - PositionImage.X;
                    DeltaYBarber = p.Y - BasePointBarber.Y - PositionImage.Y;
                    BasePointBarber.X += DeltaXBarber;
                    BasePointBarber.Y += DeltaYBarber;
                    RaisePropertyChanged("XPositionBarber");
                    RaisePropertyChanged("YPositionBarber");


                }
                if (l.Name == "chef")
                {
                    Point p = e.GetPosition(null);
                    DeltaXChef = p.X - BasePointChef.X - PositionImage.X;
                    DeltaYChef = p.Y - BasePointChef.Y - PositionImage.Y;
                    BasePointChef.X += DeltaXChef;
                    BasePointChef.Y += DeltaYChef;
                    RaisePropertyChanged("XPositionChef");
                    RaisePropertyChanged("YPositionChef");


                }
            }
        }
    }
}
