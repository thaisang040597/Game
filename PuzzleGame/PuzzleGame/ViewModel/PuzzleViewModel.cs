using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleGame.Viewmodel
{
    public class PuzzleViewModel
    {
        [Key]
        public int Id { get; set; }
        public int GameCate { get; set; }
        public int RoundWin { get; set; }
        public int RoundTotal { get; set; }

        public IEnumerable<ImageGameViewModel> imageGames { get; set; }
        public IEnumerable<MediaGameViewModel> mediaGames { get; set; }

    }
}
