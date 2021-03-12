namespace TrainEngine
{
    public interface ITrain
    {
        int Id { get; set; }
        string Name { get; set; }
        int MaxSpeed { get; set; }
        bool Operated { get; set; }
    }
}