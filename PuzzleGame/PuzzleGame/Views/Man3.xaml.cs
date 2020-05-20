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

        private Point BasePointC = new Point(1100, 700);
        private Point BasePointB = new Point(1220, 700);
        private Point BasePointO = new Point(1160, 700);
        private Point BasePointG = new Point(1280, 700);
        private Point BasePointE = new Point(1100, 770);
        private Point BasePointI = new Point(1220, 770);
        private Point BasePointK = new Point(1160, 770);
        private Point BasePointF = new Point(1280, 770);
        private Point BasePointV = new Point(1280, 840);
        private Point BasePointS = new Point(1220, 840);
        private Point BasePointQ = new Point(1100, 840);
        private Point BasePointT = new Point(1160, 840);
        private double DeltaXC = 0.0;
        private double DeltaYC= 0.0;
        private double DeltaXB = 0.0;
        private double DeltaYB = 0.0;
        private double DeltaXO = 0.0;
        private double DeltaYO = 0.0;
        private double DeltaXG = 0.0;
        private double DeltaYG = 0.0;
        private double DeltaXE = 0.0;
        private double DeltaYE = 0.0;
        private double DeltaXI = 0.0;
        private double DeltaYI = 0.0;
        private double DeltaXK = 0.0;
        private double DeltaYK = 0.0;
        private double DeltaXF = 0.0;
        private double DeltaYF = 0.0;
        private double DeltaXV = 0.0;
        private double DeltaYV = 0.0;
        private double DeltaXS = 0.0;
        private double DeltaYS = 0.0;
        private double DeltaXQ = 0.0;
        private double DeltaYQ = 0.0;
        private double DeltaXT = 0.0;
        private double DeltaYT = 0.0;
        private bool moving = false;
        private Point PositionImage;
        private static bool chuc = false;
        private static bool chub = false;//không cho chọn khi đúng hình;
        private static bool chuo = false;
        private static bool chug = false;
        private static bool chue = false;
        private static bool chui = false;
        private static bool chuk = false;
        private static bool chuf = false;
        private static bool chuv = false;
        private static bool chus = false;
       
        private static bool chut = false;
        private bool checkpoint = false;
        private bool replay = false;
        private int temp = 0;
        MediaPlayer playMedia = new MediaPlayer();
        public Man3()
        {
            InitializeComponent();
            this.DataContext = this;
            RanDomAlp();
            //Countdown.Completed += new EventHandler(Story_completed);
        }
        public double XPositionC
        {
            get { return BasePointC.X + DeltaXC; }
        }

        public double YPositionC
        {
            get { return BasePointC.Y + DeltaYC; }
        }
        public double XPositionB
        {
            get { return BasePointB.X + DeltaXB; }
        }

        public double YPositionB
        {
            get { return BasePointB.Y + DeltaYB; }
        }
        public double XPositionO
        {
            get { return BasePointO.X + DeltaXO; }
        }

        public double YPositionO
        {
            get { return BasePointO.Y + DeltaYO; }
        }
        public double XPositionG
        {
            get { return BasePointG.X + DeltaXG; }
        }

        public double YPositionG
        {
            get { return BasePointG.Y + DeltaYG; }
        }
        public double XPositionE
        {
            get { return BasePointE.X + DeltaXE; }
        }

        public double YPositionE
        {
            get { return BasePointE.Y + DeltaYE; }
        }
        public double XPositionI
        {
            get { return BasePointI.X + DeltaXI; }
        }

        public double YPositionI
        {
            get { return BasePointI.Y + DeltaYI; }
        }
        public double XPositionK
        {
            get { return BasePointK.X + DeltaXK; }
        }

        public double YPositionK
        {
            get { return BasePointK.Y + DeltaYK; }
        }
        public double XPositionF
        {
            get { return BasePointF.X + DeltaXF; }
        }

        public double YPositionF
        {
            get { return BasePointF.Y + DeltaYF; }
        }
        public double XPositionV
        {
            get { return BasePointV.X + DeltaXV; }
        }

        public double YPositionV
        {
            get { return BasePointV.Y + DeltaYV; }
        }
        public double XPositionS
        {
            get { return BasePointS.X + DeltaXS; }
        }

        public double YPositionS
        {
            get { return BasePointS.Y + DeltaYS; }
        }
      
        
        public double XPositionT
        {
            get { return BasePointT.X + DeltaXT; }
        }

        public double YPositionT
        {
            get { return BasePointT.Y + DeltaYT; }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            chuc = false;
            chub = false;
            chuo = false;
            chug = false;
            chue = false;
            chui = false;
            chuk = false;
            chuf = false;
            chus = false;
           
            chut = false;
            chuv = false;
            checkpoint = true;
            //Countdown.Stop(this);
            //Countdown.Remove(this);
        }
        //private void Story_completed(object sender, EventArgs e)
        //{
        //    if (chuc == false || chub == false || chuo == false || chug == false || chue == false || chui == false || chuk == false || chuf == false || chut == false || chus == false || chuv == false)
        //    {
        //        timeout.Visibility = Visibility.Visible;

        //        Uri uri = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/timeout.mp3"); // "/PuzzleGame;component/Sound/Ilikeme.wav", UriKind.Relative, browsing to the sound folder and then the WAV file location
        //        playMedia.Open(uri); // inserting the URI to the media player
        //        playMedia.Play();
        //        if (checkpoint == true)
        //        {
        //            playMedia.Stop();

        //        }
        //        Grid1.IsEnabled = false;
        //    }
        //    Countdown.Remove(this);
        //}
        private void RanDomAlp()
        {
            List<string> Images = new List<string>()
            {
                "/Images/Game1/Round3/b.png","/Images/Game1/Round3/c.png" ,"/Images/Game1/Round3/o.png" ,"/Images/Game1/Round3/g.png",
                "/Images/Game1/Round3/e.png"  ,"/Images/Game1/Round3/i.png"  ,"/Images/Game1/Round3/k.png" , "/Images/Game1/Round3/f.png" ,
                "/Images/Game1/Round3/v.png","/Images/Game1/Round3/s.png","/Images/Game1/Round3/t.png"
            };
            List<Image> ImagesBong = new List<Image>()
            {
                num_b,num_c,num_o,num_g,num_e,num_i,num_k,num_f,num_v,num_s,num_t
            };
            List<Image> ImagesGoc = new List<Image>()
            {
                b,c,o,g,e1,i,k,f,v,s,t
            };
            List<int> lstIndex = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int index = 0;
                do
                {
                    index = rnd.Next(0, 10);
                } while (lstIndex.Exists(x => x == index) == true);
                lstIndex.Add(index);
            }
            ImagesBong[lstIndex[0]].Visibility = Visibility.Collapsed;
            ImagesBong[lstIndex[1]].Visibility = Visibility.Collapsed;
            ImagesBong[lstIndex[2]].Visibility = Visibility.Collapsed;
            ImagesBong[lstIndex[3]].Visibility = Visibility.Collapsed;
            ImagesBong[lstIndex[4]].Visibility = Visibility.Collapsed;
            ImagesGoc[lstIndex[0]].Source = new BitmapImage(new Uri(Images[lstIndex[0]], UriKind.RelativeOrAbsolute));
            ImagesGoc[lstIndex[1]].Source = new BitmapImage(new Uri(Images[lstIndex[1]], UriKind.RelativeOrAbsolute));
            ImagesGoc[lstIndex[2]].Source = new BitmapImage(new Uri(Images[lstIndex[2]], UriKind.RelativeOrAbsolute));
            ImagesGoc[lstIndex[3]].Source = new BitmapImage(new Uri(Images[lstIndex[3]], UriKind.RelativeOrAbsolute));
            ImagesGoc[lstIndex[4]].Source = new BitmapImage(new Uri(Images[lstIndex[4]], UriKind.RelativeOrAbsolute));
            //c.Source = new BitmapImage(new Uri(Images[lstIndex[0]], UriKind.RelativeOrAbsolute));
            //ho2.Source = new BitmapImage(new Uri(Images[lstIndex[1]], UriKind.RelativeOrAbsolute));
            //voi2.Source = new BitmapImage(new Uri(Images[lstIndex[2]], UriKind.RelativeOrAbsolute));
            //khi2.Source = new BitmapImage(new Uri(Images[lstIndex[3]], UriKind.RelativeOrAbsolute));
            //tho2.Source = new BitmapImage(new Uri(Images[lstIndex[4]], UriKind.RelativeOrAbsolute));
            //gau1.Source = new BitmapImage(new Uri(ImagesBong[lstIndex[0]], UriKind.RelativeOrAbsolute));
            //ho.Source = new BitmapImage(new Uri(ImagesBong[lstIndex[1]], UriKind.RelativeOrAbsolute));
            //voi.Source = new BitmapImage(new Uri(ImagesBong[lstIndex[2]], UriKind.RelativeOrAbsolute));
            //khi.Source = new BitmapImage(new Uri(ImagesBong[lstIndex[3]], UriKind.RelativeOrAbsolute));
            //tho.Source = new BitmapImage(new Uri(ImagesBong[lstIndex[4]], UriKind.RelativeOrAbsolute));


        }
        private Image GetImageByIndex(int index)
        {
            switch(index)
            {
                case 1:
                    {
                        return b;
                    }
                case 2:
                    {
                        return c;
                    }
                case 3:
                    {
                        return o;
                    }
                case 4:
                    {
                        return g;
                    }
                case 5:
                    {
                        return e1;
                    }
                case 6:
                    {
                        return i;
                    }
                case 7:
                    {
                        return k;
                    }
                case 8:
                    {
                        return f;
                    }
                case 9:
                    {
                        return s;
                    }
                case 10:
                    {
                        return t;
                    }
                case 11:
                    {
                        return v;
                    }
                   
            }
            return null;
        }
        private void Feast_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image l = e.Source as Image;
            if (l != null)
            {
                
                if (l.Name == "c" && chuc == false)
                {
                    c.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(c);
                    Panel.SetZIndex(c,12);
                    Panel.SetZIndex(b, 1);
                    Panel.SetZIndex(o, 1);
                    Panel.SetZIndex(g, 1);
                    Panel.SetZIndex(e1, 1);
                    Panel.SetZIndex(i, 1);
                    Panel.SetZIndex(k, 1);
                    Panel.SetZIndex(f, 1);
                    Panel.SetZIndex(s, 1);
                    Panel.SetZIndex(v, 1);
                   
                    Panel.SetZIndex(t, 1);


                }
                if (l.Name == "b" && chub == false)
                {
                    b.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(b);
                    Panel.SetZIndex(c, 1);
                    Panel.SetZIndex(b, 12);
                    Panel.SetZIndex(o, 1);
                    Panel.SetZIndex(g, 1);
                    Panel.SetZIndex(e1, 1);
                    Panel.SetZIndex(i, 1);
                    Panel.SetZIndex(k, 1);
                    Panel.SetZIndex(f, 1);
                    Panel.SetZIndex(s, 1);
                    Panel.SetZIndex(v, 1);
                   
                    Panel.SetZIndex(t, 1);
                }
                if (l.Name == "o" && chuo == false)
                {
                    o.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(o);
                    Panel.SetZIndex(c, 1);
                    Panel.SetZIndex(b, 1);
                    Panel.SetZIndex(o, 12);
                    Panel.SetZIndex(g, 1);
                    Panel.SetZIndex(e1, 1);
                    Panel.SetZIndex(i, 1);
                    Panel.SetZIndex(k, 1);
                    Panel.SetZIndex(f, 1);
                    Panel.SetZIndex(s, 1);
                    Panel.SetZIndex(v, 1);
                  
                    Panel.SetZIndex(t, 1);
                }
                if (l.Name == "g" && chug == false)
                {
                    g.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(g);
                    Panel.SetZIndex(c, 1);
                    Panel.SetZIndex(b, 1);
                    Panel.SetZIndex(o, 1);
                    Panel.SetZIndex(g, 12);
                    Panel.SetZIndex(e1, 1);
                    Panel.SetZIndex(i, 1);
                    Panel.SetZIndex(k, 1);
                    Panel.SetZIndex(f, 1);
                    Panel.SetZIndex(s, 1);
                    Panel.SetZIndex(v, 1);
                  
                    Panel.SetZIndex(t, 1);
                }
                if (l.Name == "e1" && chue == false)
                {
                    e1.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(e1);
                    Panel.SetZIndex(c, 1);
                    Panel.SetZIndex(b, 1);
                    Panel.SetZIndex(o, 1);
                    Panel.SetZIndex(g, 1);
                    Panel.SetZIndex(e1, 12);
                    Panel.SetZIndex(i, 1);
                    Panel.SetZIndex(k, 1);
                    Panel.SetZIndex(f, 1);
                    Panel.SetZIndex(s, 1);
                    Panel.SetZIndex(v, 1);
                   
                    Panel.SetZIndex(t, 1);
                }
                if (l.Name == "i" && chui == false)
                {
                    i.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(i);
                    Panel.SetZIndex(c, 1);
                    Panel.SetZIndex(b, 1);
                    Panel.SetZIndex(o, 1);
                    Panel.SetZIndex(g, 1);
                    Panel.SetZIndex(e1, 1);
                    Panel.SetZIndex(i, 12);
                    Panel.SetZIndex(k, 1);
                    Panel.SetZIndex(f, 1);
                    Panel.SetZIndex(s, 1);
                    Panel.SetZIndex(v, 1);
                   
                    Panel.SetZIndex(t, 1);
                }
                if (l.Name == "k" && chuk == false)
                {
                    k.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(k);
                    Panel.SetZIndex(c, 1);
                    Panel.SetZIndex(b, 1);
                    Panel.SetZIndex(o, 1);
                    Panel.SetZIndex(g, 1);
                    Panel.SetZIndex(e1, 1);
                    Panel.SetZIndex(i, 1);
                    Panel.SetZIndex(k, 12);
                    Panel.SetZIndex(f, 1);
                    Panel.SetZIndex(s, 1);
                    Panel.SetZIndex(v, 1);
                  
                    Panel.SetZIndex(t, 1);
                }
                if (l.Name == "f" && chuf == false)
                {
                    f.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(f);
                    Panel.SetZIndex(c, 1);
                    Panel.SetZIndex(b, 1);
                    Panel.SetZIndex(o, 1);
                    Panel.SetZIndex(g, 1);
                    Panel.SetZIndex(e1, 1);
                    Panel.SetZIndex(i, 1);
                    Panel.SetZIndex(k, 1);
                    Panel.SetZIndex(f, 12);
                    Panel.SetZIndex(s, 1);
                    Panel.SetZIndex(v, 1);
                 
                    Panel.SetZIndex(t, 1);
                }
                if (l.Name == "v" && chuv == false)
                {
                   v.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(v);
                    Panel.SetZIndex(c, 1);
                    Panel.SetZIndex(b, 1);
                    Panel.SetZIndex(o, 1);
                    Panel.SetZIndex(g, 1);
                    Panel.SetZIndex(e1, 1);
                    Panel.SetZIndex(i, 1);
                    Panel.SetZIndex(k, 1);
                    Panel.SetZIndex(f, 1);
                    Panel.SetZIndex(s, 1);
                    Panel.SetZIndex(v, 12);
                  
                    Panel.SetZIndex(t, 1);
                }
                if (l.Name == "s" && chus == false)
                {
                    s.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(s);
                    Panel.SetZIndex(c, 1);
                    Panel.SetZIndex(b, 1);
                    Panel.SetZIndex(o, 1);
                    Panel.SetZIndex(g, 1);
                    Panel.SetZIndex(e1, 1);
                    Panel.SetZIndex(i, 1);
                    Panel.SetZIndex(k, 1);
                    Panel.SetZIndex(f, 1);
                    Panel.SetZIndex(s, 12);
                    Panel.SetZIndex(v, 1);
                  
                    Panel.SetZIndex(t, 1);
                }
             
                if (l.Name == "t" && chut == false)
                {
                   t.CaptureMouse();
                    moving = true;
                    PositionImage = e.GetPosition(t);
                    Panel.SetZIndex(c, 1);
                    Panel.SetZIndex(b, 1);
                    Panel.SetZIndex(o, 1);
                    Panel.SetZIndex(g, 1);
                    Panel.SetZIndex(e1, 1);
                    Panel.SetZIndex(i, 1);
                    Panel.SetZIndex(k, 1);
                    Panel.SetZIndex(f, 1);
                    Panel.SetZIndex(s, 1);
                    Panel.SetZIndex(v, 1);
                  
                    Panel.SetZIndex(t, 12);
                }
                playMedia.Stop();



            }
        }
        
        private void Feast_MouseUp(object sender, MouseButtonEventArgs e)
        {
            double xc = Canvas.GetLeft(chuC);
            double yc= Canvas.GetTop(chuC);
            double xb = Canvas.GetLeft(chuB);
            double yb = Canvas.GetTop(chuB);
            double xo = Canvas.GetLeft(chuO);
            double yo = Canvas.GetTop(chuO);
            double xg = Canvas.GetLeft(chuG);
            double yg = Canvas.GetTop(chuG);
            double xe = Canvas.GetLeft(chuE);
            double ye = Canvas.GetTop(chuE);
            double xi = Canvas.GetLeft(chuI);
            double yi = Canvas.GetTop(chuI);
            double xk = Canvas.GetLeft(chuK);
            double yk = Canvas.GetTop(chuK);
            double xf = Canvas.GetLeft(chuF);
            double yf = Canvas.GetTop(chuF);
            double xv = Canvas.GetLeft(chuV);
            double yv = Canvas.GetTop(chuV);
            double xs = Canvas.GetLeft(chuS);
            double ys = Canvas.GetTop(chuS);
           
            double xt = Canvas.GetLeft(chuT);
            double yt = Canvas.GetTop(chuT);

            Image l = e.Source as Image;
            if (l != null)
            {
                if (l.Name == "c")
                {
                    CheckImage(BasePointC, DeltaXC, DeltaYC, xc, yc, c);
                }
                if (l.Name == "b")
                {
                    CheckImage(BasePointB, DeltaXB, DeltaYB, xb, yb, b);
                }
                if (l.Name == "o")
                {
                    CheckImage(BasePointO, DeltaXO, DeltaYO, xo, yo, o);
                }
                if (l.Name == "g")
                {
                    CheckImage(BasePointG, DeltaXG, DeltaYG, xg, yg, g);
                }
                if (l.Name == "e1")
                {
                    CheckImage(BasePointE, DeltaXE, DeltaYE, xe, ye, e1);
                }
                if (l.Name == "i")
                {
                    CheckImage(BasePointI, DeltaXI, DeltaYI, xi, yi, i);
                }
                if (l.Name == "k")
                {
                    CheckImage(BasePointK, DeltaXK, DeltaYK, xk, yk, k);
                }
                if (l.Name == "f")
                {
                    CheckImage(BasePointF, DeltaXF, DeltaYF, xf, yf, f);
                }
                if (l.Name == "v")
                {
                    CheckImage(BasePointV, DeltaXV, DeltaYV, xv, yv, v);
                }
                if (l.Name == "s")
                {
                    CheckImage(BasePointS, DeltaXS, DeltaYS, xs, ys, s);
                }
               
                if (l.Name == "t")
                {
                    CheckImage(BasePointT, DeltaXT, DeltaYT, xt, yt, t);
                }
            }
            if(chuc == true && chub == true && chuo == true && chug == true && chue == true && chui == true && chuk == true && chuf == true && chus == true &&   chut == true && chuv == true)
            {
                report.Visibility = Visibility.Visible;
                //Pause1.IsEnabled = false;
                Uri uri = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/chucmung.mp3"); // "/PuzzleGame;component/Sound/Ilikeme.wav", UriKind.Relative, browsing to the sound folder and then the WAV file location
                playMedia.Open(uri); // inserting the URI to the media player
                playMedia.Play();
            //    Countdown.Stop(this);
            //    Countdown.Remove(this);
            }
            
        }
        private void CheckImage(Point point, double deltaX, double deltaY, double toadoX, double toadoY,Image hinh )
        {
            hinh.ReleaseMouseCapture();
            point.X += deltaX;
            point.Y += deltaY;
            deltaX = 0;
            deltaY = 0;
            moving = false;

            if ((((point.X - 50) < toadoX) && ((point.X + 50) > toadoX)) && (((point.Y - 700) < toadoY) && ((point.Y + 700) > toadoY)))
            {
                
                if(hinh.Name == "c")
                {
                    chuc = true;
                }
                if (hinh.Name == "b")
                {
                    chub = true;
                }
                if (hinh.Name == "o")
                {
                    chuo = true;
                }
                if (hinh.Name == "g")
                {
                    chug = true;
                }
                if (hinh.Name == "e1")
                {
                    chue = true;
                }
                if (hinh.Name == "i")
                {
                    chui = true;
                }
                if (hinh.Name == "k")
                {
                    chuk = true;
                }
                if (hinh.Name == "f")
                {
                    chuf = true;
                }
                if (hinh.Name == "v")
                {
                    chuv = true;
                }
                if (hinh.Name == "s")
                {
                    chus = true;
                }
              
                if (hinh.Name == "t")
                {
                    chut = true;
                }
                Uri ting = new Uri("D:/ĐỒ ÁN TN/PuzzleGame/PuzzleGame/Sound/Ting.mp3");
                playMedia.Open(ting);
                playMedia.Play();

               
            }

        }

        //private void RamdomImg()
        //{
        //    List<string> pics = new List<string>()
        //    {
        //        "Images/Game1/Round3/a.png",
        //        "image/dau1.png",
        //        "image/duahau.png",
        //        "image/dudu.png",
        //        "image/nho.png",
        //        "image/lemon.png"
        //    };
        //}

        private void Feast_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                Image l = e.Source as Image;
                if (l.Name == "c")
                {
                   
                    Point p = e.GetPosition(null);
                    DeltaXC = p.X - BasePointC.X - PositionImage.X;
                    DeltaYC = p.Y - (BasePointC.Y - 650) - PositionImage.Y;
                    BasePointC.X += DeltaXC;
                    BasePointC.Y += DeltaYC;
                    RaisePropertyChanged("XPositionC");
                    RaisePropertyChanged("YPositionC");
                }
                if(l.Name =="b")
                {
                    Point p = e.GetPosition(null);
                    DeltaXB = p.X - BasePointB.X - PositionImage.X;
                    DeltaYB = p.Y - (BasePointB.Y - 650) - PositionImage.Y;
                    BasePointB.X += DeltaXB;
                    BasePointB.Y += DeltaYB;
                    RaisePropertyChanged("XPositionB");
                    RaisePropertyChanged("YPositionB");
                }
                if (l.Name == "o")
                {
                    Point p = e.GetPosition(null);
                    DeltaXO = p.X - BasePointO.X - PositionImage.X;
                    DeltaYO = p.Y - (BasePointO.Y - 650) - PositionImage.Y;
                    BasePointO.X += DeltaXO;
                    BasePointO.Y += DeltaYO;
                    RaisePropertyChanged("XPositionO");
                    RaisePropertyChanged("YPositionO");
                }
                if (l.Name == "g")
                {
                    Point p = e.GetPosition(null);
                    DeltaXG = p.X - BasePointG.X - PositionImage.X;
                    DeltaYG = p.Y - (BasePointG.Y - 650) - PositionImage.Y;
                    BasePointG.X += DeltaXG;
                    BasePointG.Y += DeltaYG;
                    RaisePropertyChanged("XPositionG");
                    RaisePropertyChanged("YPositionG");
                }
                if (l.Name == "e1")
                {
                    Point p = e.GetPosition(null);
                    DeltaXE = p.X - BasePointE.X - PositionImage.X;
                    DeltaYE = p.Y - (BasePointE.Y - 650) - PositionImage.Y;
                    BasePointE.X += DeltaXE;
                    BasePointE.Y += DeltaYE;
                    RaisePropertyChanged("XPositionE");
                    RaisePropertyChanged("YPositionE");
                }
                if (l.Name == "i")
                {
                    Point p = e.GetPosition(null);
                    DeltaXI = p.X - BasePointI.X - PositionImage.X;
                    DeltaYI = p.Y - (BasePointI.Y - 650) - PositionImage.Y;
                    BasePointI.X += DeltaXI;
                    BasePointI.Y += DeltaYI;
                    RaisePropertyChanged("XPositionI");
                    RaisePropertyChanged("YPositionI");
                }
                if (l.Name == "k")
                {
                    Point p = e.GetPosition(null);
                    DeltaXK = p.X - BasePointK.X - PositionImage.X;
                    DeltaYK = p.Y - (BasePointK.Y - 650) - PositionImage.Y;
                    BasePointK.X += DeltaXK;
                    BasePointK.Y += DeltaYK;
                    RaisePropertyChanged("XPositionK");
                    RaisePropertyChanged("YPositionK");
                }
                if (l.Name == "f")
                {
                    Point p = e.GetPosition(null);
                    DeltaXF = p.X - BasePointF.X - PositionImage.X;
                    DeltaYF = p.Y - (BasePointF.Y - 650) - PositionImage.Y;
                    BasePointF.X += DeltaXF;
                    BasePointF.Y += DeltaYF;
                    RaisePropertyChanged("XPositionF");
                    RaisePropertyChanged("YPositionF");
                }
                if (l.Name == "v")
                {
                    Point p = e.GetPosition(null);
                    DeltaXV = p.X - BasePointV.X - PositionImage.X;
                    DeltaYV = p.Y - (BasePointV.Y - 650) - PositionImage.Y;
                    BasePointV.X += DeltaXV;
                    BasePointV.Y += DeltaYV;
                    RaisePropertyChanged("XPositionV");
                    RaisePropertyChanged("YPositionV");
                }
                if (l.Name == "s")
                {
                    Point p = e.GetPosition(null);
                    DeltaXS = p.X - BasePointS.X - PositionImage.X;
                    DeltaYS = p.Y - (BasePointS.Y - 650) - PositionImage.Y;
                    BasePointS.X += DeltaXS;
                    BasePointS.Y += DeltaYS;
                    RaisePropertyChanged("XPositionS");
                    RaisePropertyChanged("YPositionS");
                }
                if (l.Name == "q")
                {
                    Point p = e.GetPosition(null);
                    DeltaXQ = p.X - BasePointQ.X - PositionImage.X;
                    DeltaYQ = p.Y - (BasePointQ.Y - 650) - PositionImage.Y;
                    BasePointQ.X += DeltaXQ;
                    BasePointQ.Y += DeltaYQ;
                    RaisePropertyChanged("XPositionQ");
                    RaisePropertyChanged("YPositionQ");
                }
                if (l.Name == "t")
                {
                    Point p = e.GetPosition(null);
                    DeltaXT = p.X - BasePointT.X - PositionImage.X;
                    DeltaYT = p.Y - (BasePointT.Y - 650) - PositionImage.Y;
                    BasePointT.X += DeltaXT;
                    BasePointT.Y += DeltaYT;
                    RaisePropertyChanged("XPositionT");
                    RaisePropertyChanged("YPositionT");
                }

            }
        }
       
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
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

            Global.dem = 3;
            //Man2 man2 = new Man2();
            //Global.menutest.oc.Children.Add(man2);
            //Global.menutest.round2.Width = 300;

            Global.menutest.imground4.ImageSource = new BitmapImage(new Uri(@"D:\ĐỒ ÁN TN\GitHub\Game\PuzzleGame\PuzzleGame\Images\Game1\Round4\thanhlong.png"));
            this.Visibility = Visibility.Collapsed;

            chuc = false;
            chub = false;
            chue = false;
            chuo = false;
            chug = false;
            chuf = false;
            chui = false;
            chuk = false;
            chus = false;
            chut = false;
           
            chuv = false;
            Man4 man4 = new Man4();
            Global.menutest.oc.Children.Add(man4);

        }

        private void Replay_Click(object sender, RoutedEventArgs e)
        {
            Grid1.IsEnabled = true;
            //Countdown.Begin(this, true);
            //Pause1.IsEnabled = true;
            report.Visibility = Visibility.Hidden;
            //timeout.Visibility = Visibility.Collapsed;
            playMedia.Stop();
            replay = true;
            if (replay == true)
            {
                moving = false;
                chuc = false;
                chub = false;
                chuo = false;
                chug = false;
                chue = false;
                chui = false;
                chuk = false;
                chuf = false;
                chus = false;
              
                chut = false;
                chuv = false;
                BasePointC.X = 1100;
                BasePointC.Y = 700;
                RaisePropertyChanged("XPositionC");
                RaisePropertyChanged("YPositionC");
                BasePointB.X = 1220;
                BasePointB.Y = 700;
                RaisePropertyChanged("XPositionB");
                RaisePropertyChanged("YPositionB");
                BasePointO.X = 1160;
                BasePointO.Y = 700;
               
                RaisePropertyChanged("XPositionO");
                RaisePropertyChanged("YPositionO");
             
                BasePointG.X = 1280;
                BasePointG.Y = 700;
               
                RaisePropertyChanged("XPositionG");
                RaisePropertyChanged("YPositionG");
              
                BasePointE.X = 1100;
                BasePointE.Y = 770;
                
                RaisePropertyChanged("XPositionE");
                RaisePropertyChanged("YPositionE");
                BasePointI.X = 1160;
                BasePointI.Y = 770;

                RaisePropertyChanged("XPositionI");
                RaisePropertyChanged("YPositionI");
                BasePointK.X = 1220;
                BasePointK.Y = 770;

                RaisePropertyChanged("XPositionK");
                RaisePropertyChanged("YPositionK");
                BasePointF.X = 1280;
                BasePointF.Y = 770;

                RaisePropertyChanged("XPositionF");
                RaisePropertyChanged("YPositionF");
                BasePointS.X = 1280;
                BasePointS.Y = 840;

                RaisePropertyChanged("XPositionS");
                RaisePropertyChanged("YPositionS");
                BasePointT.X = 1220;
                BasePointT.Y = 840;

                RaisePropertyChanged("XPositionT");
                RaisePropertyChanged("YPositionT");
                BasePointQ.X = 1100;
                BasePointQ.Y = 840;

                RaisePropertyChanged("XPositionQ");
                RaisePropertyChanged("YPositionQ");
                BasePointV.X = 1160;
                BasePointV.Y = 840;

                RaisePropertyChanged("XPositionV");
                RaisePropertyChanged("YPositionV");





            }
        }
    }
}
