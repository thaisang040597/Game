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

        }
       
      
        private void Game1_Click(object sender, RoutedEventArgs e)
        {
            stproundgame1.Visibility = Visibility.Visible;
            stproundgame2.Visibility = Visibility.Collapsed;
            stproundgame3.Visibility = Visibility.Collapsed;
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            Man1 man1 = new Man1();
            oc.Children.Add(man1);
        }

        private void round2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
                Man2 man2 = new Man2();
                oc.Children.Add(man2);
            
           
            
        }

        private void round3_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
                Man3 man3 = new Man3();
                oc.Children.Add(man3);
            
           
        }

        private void round4_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
                Man4 man4 = new Man4();
                oc.Children.Add(man4);
            
        }

        private void round6_MouseDown(object sender, MouseButtonEventArgs e)
        {
                Man6 man6 = new Man6();
                oc.Children.Add(man6);
     
        }

        private void round5_MouseDown(object sender, MouseButtonEventArgs e)
        {

            Man5 man5 = new Man5();
            oc.Children.Add(man5);
        }

       

        private void back_Click(object sender, RoutedEventArgs e)
        {
            stproundgame1.Visibility = Visibility.Hidden;
            stproundgame2.Visibility = Visibility.Hidden;
        }

        private void g2round1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Round1 round1 = new Round1();
            oc.Children.Add(round1);
        }

        private void g2round2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Round2 round2 = new Round2();
            oc.Children.Add(round2);
        }

        private void g2round3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Round3 round3 = new Round3();
            oc.Children.Add(round3);
        }

        private void g2round4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Round4 round4 = new Round4();
            oc.Children.Add(round4);
        }

        private void g2round5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Round5 round5 = new Round5();
            oc.Children.Add(round5);
        }

        private void g2round6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Round6 round6 = new Round6();
            oc.Children.Add(round6);
        }

        private void Game2_Click(object sender, RoutedEventArgs e)
        {
            stproundgame2.Visibility = Visibility.Visible;
            stproundgame1.Visibility = Visibility.Collapsed;
            stproundgame3.Visibility = Visibility.Collapsed;
        }

        private void Border_MouseEnter(object sender, MouseButtonEventArgs e)
        {
            Man1 man1 = new Man1();
            oc.Children.Add(man1);
        }

        private void Game3_Click(object sender, RoutedEventArgs e)
        {
            stproundgame2.Visibility = Visibility.Collapsed;
            stproundgame1.Visibility = Visibility.Collapsed;
            stproundgame3.Visibility = Visibility.Visible;
        }

        private void round3_1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Round1Game3 round1Game3 = new Round1Game3();
            oc.Children.Add(round1Game3);
        }

        private void round3_2_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void round3_3_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void round3_4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Round4Game3 round4Game3 = new Round4Game3();
            oc.Children.Add(round4Game3);
        }

        private void round3_5_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void round3_6_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
