using PuzzleGame.Views.Game2;
using PuzzleGame.Views.Game3;
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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PuzzleGame.Views
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {
        
        public Menu()
        {
            InitializeComponent();
            Global.menutest= this;
            stb1.Completed += new EventHandler(r1_Completed);
            stb3.Completed += new EventHandler(r3_Completed);
            stb5.Completed += new EventHandler(r5_Completed);
            stb7.Completed += new EventHandler(r7_Completed);
            stb9.Completed += new EventHandler(r9_Completed);
            stb11.Completed += new EventHandler(r11_Completed);
            stb2_1.Completed += new EventHandler(r21_Completed);
            stb2_3.Completed += new EventHandler(r23_Completed);
            stb2_5.Completed += new EventHandler(r25_Completed);
            stb2_7.Completed += new EventHandler(r27_Completed);
            stb2_9.Completed += new EventHandler(r29_Completed);
            stb2_11.Completed += new EventHandler(r211_Completed);
            stb3_1.Completed += new EventHandler(r31_Completed);
            stb3_3.Completed += new EventHandler(r33_Completed);
            stb3_5.Completed += new EventHandler(r35_Completed);
            stb3_7.Completed += new EventHandler(r37_Completed);
            stb3_9.Completed += new EventHandler(r39_Completed);
            stb3_11.Completed += new EventHandler(r311_Completed);
        }

        private void r311_Completed(object sender, EventArgs e)
        {
            stb3_12.Begin();
            Round6Game3 round6Game3 = new Round6Game3();
            oc.Children.Add(round6Game3);
        }

        private void r39_Completed(object sender, EventArgs e)
        {
            stb3_10.Begin();
            Round5Game3 round5Game3 = new Round5Game3();
            oc.Children.Add(round5Game3);
        }

        private void r37_Completed(object sender, EventArgs e)
        {
            stb3_8.Begin();
            Round4Game3 round4Game3 = new Round4Game3();
            oc.Children.Add(round4Game3);
        }

        private void r35_Completed(object sender, EventArgs e)
        {
            stb3_6.Begin();
            Round3Game3 round3Game3 = new Round3Game3();
            oc.Children.Add(round3Game3);
        }

        private void r33_Completed(object sender, EventArgs e)
        {
            stb3_4.Begin();
            Round2Game3 round2Game3 = new Round2Game3();
            oc.Children.Add(round2Game3);
        }

        private void r31_Completed(object sender, EventArgs e)
        {
            stb3_2.Begin();
            Round1Game3 round1Game3 = new Round1Game3();
            oc.Children.Add(round1Game3);
        }

        private void r211_Completed(object sender, EventArgs e)
        {
            stb2_12.Begin();
            Round6 round6 = new Round6();
            oc.Children.Add(round6);
        }

        private void r29_Completed(object sender, EventArgs e)
        {
            stb2_10.Begin();
            Round5 round5 = new Round5();
            oc.Children.Add(round5);
        }

        private void r27_Completed(object sender, EventArgs e)
        {
            stb2_8.Begin();
            Round4 round4 = new Round4();
            oc.Children.Add(round4);
        }

        private void r25_Completed(object sender, EventArgs e)
        {
            stb2_6.Begin();
            Round3 round3 = new Round3();
            oc.Children.Add(round3);
        }

        private void r23_Completed(object sender, EventArgs e)
        {
            stb2_4.Begin();
            Round2 round2 = new Round2();
            oc.Children.Add(round2);
        }

        private void r21_Completed(object sender, EventArgs e)
        {
            stb2_2.Begin();
            Round1 round1 = new Round1();
            oc.Children.Add(round1);
        }

        private void r11_Completed(object sender, EventArgs e)
        {
            stb12.Begin();
            Man6 man6 = new Man6();
            oc.Children.Add(man6);
        }

        private void r9_Completed(object sender, EventArgs e)
        {
            stb10.Begin();
            Man5 man5 = new Man5();
            oc.Children.Add(man5);
        }

        private void r7_Completed(object sender, EventArgs e)
        {
            stb8.Begin();
            Man4 man4 = new Man4();
            oc.Children.Add(man4);
        }

        private void r5_Completed(object sender, EventArgs e)
        {
            stb6.Begin();
            Man3 man3 = new Man3();
            oc.Children.Add(man3);
        }

        private void r3_Completed(object sender, EventArgs e)
        {
            stb4.Begin();
            Man2 man2 = new Man2();
            oc.Children.Add(man2);
        }

        private void r1_Completed(object sender, EventArgs e)
        {
            stb2.Begin();
            Man1 man1 = new Man1();
            oc.Children.Add(man1);
        }

        private void Game1_Click(object sender, RoutedEventArgs e)
        {
            stproundgame1.Visibility = Visibility.Visible;
            stproundgame2.Visibility = Visibility.Collapsed;
            stproundgame3.Visibility = Visibility.Collapsed;
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            stproundgame1.Visibility = Visibility.Hidden;
            stproundgame2.Visibility = Visibility.Hidden;
            stproundgame3.Visibility = Visibility.Hidden;
        }
        private void Game2_Click(object sender, RoutedEventArgs e)
        {
            stproundgame2.Visibility = Visibility.Visible;
            stproundgame1.Visibility = Visibility.Collapsed;
            stproundgame3.Visibility = Visibility.Collapsed;
        }
        private void Game3_Click(object sender, RoutedEventArgs e)
        {
            stproundgame2.Visibility = Visibility.Collapsed;
            stproundgame1.Visibility = Visibility.Collapsed;
            stproundgame3.Visibility = Visibility.Visible;
        }

      
       

        
    }
}
