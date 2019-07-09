using System.Collections.Generic;
using blockbuster.Interfaces;

namespace blockbuster.Models
{
    class DvD : Movie, IRentable
    {
        public int Discs { get; set; }
        public List<Languages> Languages { get; set; }
        public int RentCount { get; set; }
        public bool Available { get; set; }
        public float Price { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void ChangeAvailable()
        {
            Available = !Available;
        }
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