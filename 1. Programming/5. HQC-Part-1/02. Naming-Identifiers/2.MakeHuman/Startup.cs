namespace MakeHuman
{
    public class Startup
    {
        private static void Main()
        {
            var human = new Human();
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
