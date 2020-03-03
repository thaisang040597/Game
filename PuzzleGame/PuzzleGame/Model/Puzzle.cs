using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleGame.Model
{
    public class Puzzle
    {
        [Key]
        public int Id { get; set; }
        public int GameCate { get; set; }
        public int RoundWin { get; set; }
        public int RoundTotal { get; set; }

        public IEnumerable<ImageGame> imageGames { get; set; }
        public IEnumerable<MediaGame> mediaGames { get; set; }

    }
}
