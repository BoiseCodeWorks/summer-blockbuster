using System.ComponentModel.DataAnnotations;
using blockbuster.Interfaces;

namespace blockbuster.Models
{
    class GameConsole : IRentable, IPurchasable
    {
        public string Type
        {
            get
            {
                return Type;
            }
            set
            {
                Title = value;
                Type = value;
            }
        }

        public int RentCount { get; set; }
        public bool Available { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }

        public GameConsole(string type)
        {
            Type = type;
        }

        public void ChangeAvailable()
        {
            Available = !Available;
        }
    }
}