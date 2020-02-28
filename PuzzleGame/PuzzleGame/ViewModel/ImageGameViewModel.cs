using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleGame.Viewmodel
{
    public class ImageGameViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public int Round { get; set; }
    }
}
