using System.Collections.Generic;

namespace blockbuster.Models
{
    class DvD : Movie
    {
        public int Discs { get; set; }
        public List<Languages> Languages { get; set; }

        public DvD(string title, string plot, int year, int discs, List<Languages> lang) : base(title, plot, year)
        {
            Languages = lang;
            Discs = discs;
        }
    }

    enum Languages
    {
        en,
        sp,
        jp,
        it,
        fr
    }




}