namespace LDIL_Assignment_1
{
    public class BeerSong
    {
        public void SingSong()
        {
            int bottles = 99;

            do
            {
                if (bottles > 2)
                {
                    Console.WriteLine($"{bottles} bottles of beer on the wall, {bottles} bottles of beer.");
                    Console.WriteLine($"Take one down and pass it around, {bottles - 1} bottles of beer on the wall.");
                }
                else
                {
                    Console.WriteLine("2 bottle of beer on the wall, 2 bottle of beer.");
                    Console.WriteLine("Take one down and pass it around, no more bottles of beer on the wall.");

                }

                Console.WriteLine();
                bottles--;

            } while (bottles > 1);

            Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer.");
            Console.WriteLine("Take one down and pass it around, no more bottles of beer on the wall.");
        }
    }

    class Program
    {
        static void Main()
        {
            BeerSong song = new BeerSong();
            song.SingSong();
        }
    }
}
