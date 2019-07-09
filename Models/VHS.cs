using blockbuster.Interfaces;

namespace blockbuster.Models
{
    class VHS : Movie, IPurchasable
    {
        public bool IsRewound { get; set; }
        public float Price { get; set; }

        public VHS(string title, string plot, int year) : base(title, plot, year)
        {
            IsRewound = true;
        }
    }
}