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

namespace PuzzleGame.Views.Game3
{
    /// <summary>
    /// Interaction logic for Round4Game3.xaml
    /// </summary>
    public partial class Round4Game3 : UserControl
    {
        int[,] Board;
        public Round4Game3()
        {
            InitializeComponent();
            InitBoard();
            AutoSlideImage();
        }
        private void InitBoard()
        {
            Board = new int[4, 4];
            int count = 0;
            var numbers = new List<int>(15) { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15 };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    if (count > 14)
                    {
                        Board[i, j] = 0;
                        break;
                    }
                    Board[i, j] = numbers[count];
                    count++;

                }
            }
        }
        private void AutoSlideImage()
        {
            Random rnd = new Random();
            ItemUC4 it = new ItemUC4(1);
            int temp;
            int count;
            bool flag = true;
            while (flag)
            {
                temp = 0;
                count = 1;
                for (int k = 0; k < 300; k++)
                {
                    int i = rnd.Next(0, 4);
                    int j = rnd.Next(0, 4);
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

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (Board[i, j] == count)
                        {
                            temp++;
                        }
                        count++;
                    }
                }
                if (temp < 8)
                {
                    flag = false;
                    break;
                }
                flag = true;
            }
        }
        private void DrawBord()
        {
            cnBoard.Children.Clear();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Board[i, j] > 0)
                    {
                        ItemUC4 cnv = new ItemUC4(Board[i, j])
                        {
                            Width = cnBoard.Width / 4,
                            Height = cnBoard.Height / 4,
                            I = i,
                            J = j
                        };
                        Canvas.SetTop(cnv, i * cnBoard.Height / 4);
                        Canvas.SetLeft(cnv, j * cnBoard.Width / 4);
                        cnBoard.Children.Add(cnv);
                        cnv.MouseLeftButtonUp += new MouseButtonEventHandler(cnv_MouseLeftButtonUp);

                    }
                }
            }

        }
        void cnv_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ItemUC4 it = (ItemUC4)sender;
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
                Board[3, 3] = 16;
                ItemUC4 cnv = new ItemUC4(16);
                Canvas.SetTop(cnv, 330);
                Canvas.SetLeft(cnv, 330);
                cnBoard.Children.Add(cnv);
                MessageBox.Show("Win");
            }
        }

        private void MoveItem(ItemUC4 it, int i, int j)
        {
            ItemUC4 a = new ItemUC4(1);
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
            for (int m = 0; m < 4; m++)
            {
                for (int n = 0; n < 4; n++)
                {
                    count++;
                    if (count == 16)
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
            if (i < 0 || j < 0 || i > 3 || j > 3) return false;
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

        }
    }
}
