namespace Jurnal10_103022400043.Models
{
    public class Game
    {
        public int id {  get; set; }

        public string nama { get; set; }

        public string developer { get; set; }

        public int tahunRilis { get; set; }

        public string genre { get; set; }

        public double rating { get; set; }

        public string[] platform { get; set; }

        public string[] Mode { get; set; }

        public bool isOnline { get; set; }

        public int Harga { get; set; }
        public Game() 
        { 
        }
    }
}
