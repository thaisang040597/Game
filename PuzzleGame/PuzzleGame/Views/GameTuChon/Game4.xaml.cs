using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
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
using System.Drawing;

namespace PuzzleGame.Views.GameTuChon
{
    /// <summary>
    /// Interaction logic for Game4.xaml
    /// </summary>
    public partial class Game4 : UserControl
    {
        public Game4()
        {
            this.DataContext = this;
            InitializeComponent();


        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }
        private void BtnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                abc.Source = new BitmapImage(fileUri);
            }
        }
        //private void BtnLoadFromResource_Click(object sender, RoutedEventArgs e)
        //{
        //    Uri resourceUri = new Uri("/Images/Game2/Round2.1/img.jpg", UriKind.Relative);
        //    imgDynamic.Source = new BitmapImage(resourceUri);
        //}
    }
}
