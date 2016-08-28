namespace MakeHuman
{
    class Program
    {
        static void Main()
        {
            Human human = new Human();
            if (human.Age % 2 == 0)
            {
                human.Name = "Батката";
                human.GenderType = GenderType.UltraBatka;
            }
            else
            {
                human.Name = "Мацето";
                human.GenderType = GenderType.Maceto;
            }
        }
    }
}
