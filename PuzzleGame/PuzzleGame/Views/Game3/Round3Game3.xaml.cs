using System;
using System.Collections.Generic;
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

namespace PuzzleGame.Views.Game3
{
    /// <summary>
    /// Interaction logic for Round3Game3.xaml
    /// </summary>
    public partial class Round3Game3 : UserControl
    {
        int[,] Board;
        MediaPlayer mediaPlayer = new MediaPlayer();
        public Round3Game3()
        {
            InitializeComponent();
            InitBoard();
            AutoSlideImage();
        }
        private void InitBoard()
        {
            Board = new int[3, 3];
            int count = 0;
            var numbers = new List<int>(8) { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (count > 7)
                    {
                        Board[i, j] = 0;
                        break;
                    }
                    Board[i, j] = numbers[count];

                    count++;
                }
            }
        }

        private void DrawBord()
        {
            cnBoard.Children.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Board[i, j] > 0 && Board[i, j] < 9)
                    {
                        ItemUC3 cnv = new ItemUC3(Board[i, j])
                        {
                            Width = cnBoard.Width / 3,
                            Height = cnBoard.Height / 3,
                            I = i,
                            J = j
                        };
                        Canvas.SetTop(cnv, i * cnBoard.Height / 3);
                        Canvas.SetLeft(cnv, j * cnBoard.Width / 3);
                        cnBoard.Children.Add(cnv);
                        cnv.MouseLeftButtonUp += new MouseButtonEventHandler(cnv_MouseLeftButtonUp);

                    }
                }
            }

        }
        void cnv_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ItemUC3 it = (ItemUC3)sender;
            if (CheckMove(it.I - 1, it.J))
            {
                MoveItem(it, it.I - 1, it.J);
            }
            else if (CheckMove(it.I, it.J + 1))
            {
                MoveItem(it, it.I, it.J + 1);
            }
            else if (CheckMove(it.I + 1, it.J))
            {
                MoveItem(it, it.I + 1, it.J);
            }
            else if (CheckMove(it.I, it.J - 1))
            {
                MoveItem(it, it.I, it.J - 1);
            }
            if (CheckWin())
            {
                Board[2, 2] = 9;
                ItemUC3 cnv = new ItemUC3(9);
                Canvas.SetTop(cnv, 300);
                Canvas.SetLeft(cnv, 300);
                cnBoard.Children.Add(cnv);
                UCWin uCWin = new UCWin();
                uc.Children.Add(uCWin);
                Uri uri = new Uri("../../Sound/chucmung.mp3", UriKind.Relative);
                mediaPlayer.Open(uri);
                mediaPlayer.Play();
                bantay.Visibility = Visibility.Visible;
                next.Visibility = Visibility.Visible;
            }
        }
        private void AutoSlideImage()
        {
            Random rnd = new Random();
            ItemUC3 it = new ItemUC3(1);
            int temp;
            int count;
            bool flag = true;
            while (flag)
            {
                temp = 0;
                count = 1;
                for (int k = 0; k < 200; k++)
                {
                    int i = rnd.Next(0, 3);
                    int j = rnd.Next(0, 3);
                    it.I = i;
                    it.J = j;
                    it.Width = 0;
                    it.Height = 0;
                    if (CheckMove(it.I - 1, it.J))
                    {
                        MoveItem(it, it.I - 1, it.J);
                    }
                    else if (CheckMove(it.I, it.J + 1))
                    {
                        MoveItem(it, it.I, it.J + 1);
                    }
                    else if (CheckMove(it.I + 1, it.J))
                    {
                        MoveItem(it, it.I + 1, it.J);
                    }
                    else if (CheckMove(it.I, it.J - 1))
                    {
                        MoveItem(it, it.I, it.J - 1);
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (Board[i, j] == count)
                        {
                            temp++;
                        }
                        count++;
                    }
                }
                if (temp < Global.level)
                {
                    flag = false;
                    break;
                }
                flag = true;
            }
        }
        private void MoveItem(ItemUC3 it, int i, int j)
        {
            ItemUC3 a = new ItemUC3(1);
            a.I = 1;
            Board[i, j] = Board[it.I, it.J];
            Board[it.I, it.J] = 0;
            Storyboard sb = new Storyboard();
            DoubleAnimation da = new DoubleAnimation();
            if (i == it.I)
            {
                da.From = it.J * it.Width;
                da.By = j * it.Width - da.From;
            }
            else
            {
                da.From = it.I * it.Height;
                da.By = i * it.Height - da.From;
            }
            da.Duration = new Duration(TimeSpan.FromSeconds(.2));
            sb.Children.Add(da);
            object prop = it.I == i ? Canvas.LeftProperty : Canvas.TopProperty;
            Storyboard.SetTargetProperty(da, new PropertyPath(prop));
            sb.Begin(it, true);
            sb.Completed += new EventHandler(sb_Completed);
            it.I = i;
            it.J = j;
            
        }

        private bool CheckWin()
        {
            bool t = true;
            int count = 0;
            for (int m = 0; m < 3; m++)
            {
                for (int n = 0; n < 3; n++)
                {
                    count++;
                    if (count == 9)
                    {
                        break;
                    }
                    if (Board[m, n] != count)
                    {
                        t = false;
                    }
                }
            }
            return t;
        }
        void sb_Completed(object sender, EventArgs e)
        {
            DrawBord();
        }

        private bool CheckMove(int i, int j)
        {
            if (i < 0 || j < 0 || i > 2 || j > 2) return false;
            return (Board[i, j] == 0);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DrawBord();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            Round4Game3 man4= new Round4Game3();
            Global.menutest.oc.Children.Add(man4);
            this.Visibility = Visibility.Collapsed;

        }

        private void bantay_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Uri uri = new Uri("../../Sound/conga.mp3", UriKind.Relative);
            mediaPlayer.Open(uri);
            mediaPlayer.Play();
        }

        private DispatcherTimer timer;
        private int time;
        private void getHint(object sender, RoutedEventArgs e)
        {
            time = 2;
            gethint.Visibility = Visibility.Visible;
            cnBoard.Opacity = 0.2;
            cnBoard.IsEnabled = false;
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_tick;
            timer.Start();
        }
        void Timer_tick(object sender, EventArgs e)
        {

            if (time > 0)
            {
                time--;
            }
            else
            {
                timer.Stop();
                gethint.Visibility = Visibility.Collapsed;
                cnBoard.Opacity = 1;
                cnBoard.IsEnabled = true;
            }

        }

        private void rePlay(object sender, RoutedEventArgs e)
        {

        }
    }
}
