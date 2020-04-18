using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleGame.Viewmodel
{
    public class ImageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged =(sender,e)=> { };
        private double BasepointX;
        private double BasepointY;
        private double DeltaX;
        private double DeltaY;
        public double XPosition
        {
            get
            {
                return BasepointX + DeltaX; 
            }
            set
            {
                
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(XPosition)));
            }
        }
        public double YPosition
        {
            get
            {
                return BasepointY + DeltaY;
            }
            set
            {
                
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(YPosition)));
            }
        }


    }
}
