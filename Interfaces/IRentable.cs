namespace blockbuster.Interfaces
{
    interface IRentable : IPurchasable
    {
        //everything must be public
        int RentCount { get; set; }
        bool Available { get; set; }
        string Title { get; set; }
        void ChangeAvailable();
    }
}