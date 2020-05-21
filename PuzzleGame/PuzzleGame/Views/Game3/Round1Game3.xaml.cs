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
    /// Interaction logic for Round1Game3.xaml
    /// </summary>
    public partial class Round1Game3 : UserControl
    {
        int[,] Board;
        public Round1Game3()
        {
            InitializeComponent();
            InitBoard();
        }
        private void InitBoard()
        {
            Board = new int[3, 3];
            Random random = new Random();
            int count = 0;
            var numbers = new List<int>(4) { 5, 6, 7, 8 };
            int n = numbers.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                int value = numbers[k];
                numbers[k] = numbers[n];
                numbers[n] = value;
            }
            var numbers1 = new List<int>(4) { 1, 2, 3, 4 };
            int m = numbers1.Count;
            while (m > 1)
            {
                m--;
                int k = random.Next(m + 1);
                int value = numbers1[k];
                numbers1[k] = numbers1[m];
                numbers1[m] = value;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    count++;
                    Board[i, j] = count;
                    if (count < 5)
                    {
                        Board[i, j] = numbers[count - 1];
                    }
                    if (count >= 5 && count < 9)
                    {
                        Board[i, j] = numbers1[count - 5];
                    }
                    if (count > 8) Board[i, j] = 0;
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
                    if (Board[i, j] > 0 && Board[i, j]<9)
                    {
                        ItemUC cnv = new ItemUC(Board[i, j])
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
            ItemUC it = (ItemUC)sender;
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

        private void MoveItem(ItemUC it, int i, int j)
        {
            ItemUC a = new ItemUC(1);
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
            if (CheckWin())
            {
                Board[2, 2] = 9;
                ItemUC cnv = new ItemUC(9);
                Canvas.SetTop(cnv, 300);
                Canvas.SetLeft(cnv, 300);
                cnBoard.Children.Add(cnv);
                MessageBox.Show("Win");
            }
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
    }
}
