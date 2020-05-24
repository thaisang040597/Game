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

namespace PuzzleGame.Views.Game3
{
    /// <summary>
    /// Interaction logic for ItemUC5.xaml
    /// </summary>
    public partial class ItemUC5 : UserControl
    {
        public int I { get; set; }
        public int J { get; set; }
        public ItemUC5(int i)
        {
            this.DataContext = this;
            InitializeComponent();
            if (i == 1)
            {
                img1.Visibility = Visibility.Visible;
            }
            else if (i == 2)
            {
                img2.Visibility = Visibility.Visible;
            }
            else if (i == 3)
            {
                img3.Visibility = Visibility.Visible;
            }
            else if (i == 4)
            {
                img4.Visibility = Visibility.Visible;
            }
            else if (i == 5)
            {
                img5.Visibility = Visibility.Visible;
            }
            else if (i == 6)
            {
                img6.Visibility = Visibility.Visible;
            }
            else if (i == 7)
            {
                img7.Visibility = Visibility.Visible;
            }
            else if (i == 8)
            {
                img8.Visibility = Visibility.Visible;
            }
            else if (i == 9)
            {
                img9.Visibility = Visibility.Visible;
            }
            else if (i == 10)
            {
                img10.Visibility = Visibility.Visible;
            }
            else if (i == 11)
            {
                img11.Visibility = Visibility.Visible;
            }
            else if (i == 12)
            {
                img12.Visibility = Visibility.Visible;
            }
            else if (i == 13)
            {
                img13.Visibility = Visibility.Visible;
            }
            else if (i == 14)
            {
                img14.Visibility = Visibility.Visible;
            }
            else if (i == 15)
            {
                img15.Visibility = Visibility.Visible;
            }
            else if (i == 16)
            {
                img16.Visibility = Visibility.Visible;
            }
        }
    }
}
