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
    /// Interaction logic for BanDo.xaml
    /// </summary>
    public partial class BanDo : UserControl
    {
        public BanDo()
        {
            InitializeComponent();
        }
        private void step1_Click(object sender, RoutedEventArgs e)
        {
            Man1 man1 = new Man1();
            oc.Children.Add(man1);
            
        }

        private void step2_Click(object sender, RoutedEventArgs e)
        {
            Man2 man2 = new Man2();
            oc.Children.Add(man2);
        }

        private void step3_Click(object sender, RoutedEventArgs e)
        {
            Man3 man3 = new Man3();
            oc.Children.Add(man3);
        }

        private void step4_Click(object sender, RoutedEventArgs e)
        {
            Man4 man4 = new Man4();
            oc.Children.Add(man4);
        }

        private void step5_Click(object sender, RoutedEventArgs e)
        {
            Man5 man5 = new Man5();
            oc.Children.Add(man5);
        }

        private void step6_Click(object sender, RoutedEventArgs e)
        {
            Man6 man6 = new Man6();
            oc.Children.Add(man6);
        }

        private void step7_Click(object sender, RoutedEventArgs e)
        {
            Man7 man7 = new Man7();
            oc.Children.Add(man7);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}
