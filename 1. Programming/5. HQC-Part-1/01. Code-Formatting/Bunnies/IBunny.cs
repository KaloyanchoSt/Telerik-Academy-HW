namespace Bunnies
{
    public interface IBunny
    {
        int Age { get; }

        string Name { get; }

        FurType FurType { get; }

        void Introduce(IWriter writer);
    }
}
