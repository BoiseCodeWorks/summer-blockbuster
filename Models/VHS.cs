namespace blockbuster.Models
{
    class VHS : Movie
    {
        public bool IsRewound { get; set; }

        public VHS(string title, string plot, int year) : base(title, plot, year)
        {
            IsRewound = true;
        }
    }
}