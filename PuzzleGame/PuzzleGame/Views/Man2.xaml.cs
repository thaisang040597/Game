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
        private double DeltaX = 0.0;
        private double DeltaY = 0.0;
        private double DeltaX1 = 0.0;
        private double DeltaY1 = 0.0;
        private bool moving = false;
        private Point PositionImage;
        private static bool matong = false;
        private static bool carot = false;//không cho chọn khi đúng hình;
        private bool replay = false;
        private int temp = 0;
        MediaPlayer playMedia = new MediaPlayer();
        public Man2()
        {
            InitializeComponent();
            this.DataContext = this;
        }
     
        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            carot = false;
            matong = false;
            playMedia.Stop();
          
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

                }
                if (l.Name == "carrot" && carot == false)
                {
                    carrot.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(carrot);
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
                    if ((((BasePoint1.X - 100) < m) && (BasePoint1.X + 100) > m) && (((BasePoint1.Y - 80) < n) && ((BasePoint1.Y + 100) > n)))
                    {
                        BasePoint1.X = m+65;
                        BasePoint1.Y = n+45;
                        RaisePropertyChanged("XPosition1");
                        RaisePropertyChanged("YPosition1");
                      
                        carot = true;
                        Uri ting = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/thokeu.mp3");
                        playMedia.Open(ting);
                        playMedia.Play();

                    }
                }



            }
            if (matong == true && carot == true)
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

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            playMedia.Stop();
            Global.BandoTest.imgstep2.ImageSource = new BitmapImage(new Uri(@"D:\ĐỒ ÁN TN\PuzzleGame\PuzzleGame\Images\Background\khobau1.png"));
            this.Visibility = Visibility.Hidden;
            carot = false;
            matong = false;
        }

        private void Replay_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
