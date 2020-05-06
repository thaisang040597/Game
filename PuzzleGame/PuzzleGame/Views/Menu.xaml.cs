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
        }

        private void Game1_Click(object sender, RoutedEventArgs e)
        {
            stpround.Visibility = Visibility.Visible;
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

        private void round7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Man7 man7 = new Man7();
            oc.Children.Add(man7);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            stpround.Visibility = Visibility.Hidden;
        }
    }
}
