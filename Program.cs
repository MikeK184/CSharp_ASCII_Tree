using System;

namespace ASCII_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get's current console window size
            int origWidth = Console.WindowWidth;
            int spaces = origWidth/2;
            int widthOfTree = 1;

            Console.WriteLine("Enter the height of the desired razor tree");
            int treeHeightUserInput = 0;
            while (!int.TryParse(Console.ReadLine(), out treeHeightUserInput))
            {
                Console.WriteLine("Enter a valid number!");               
            }

            // draws tree
            for (int i = 0; i < treeHeightUserInput; i++)
            {
                // indentation
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < widthOfTree; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                widthOfTree++;
                // reduces width of next line
                spaces--;
            }

            // draws trunk
            int trunk = origWidth / 2;
            for (int i = 0; i < treeHeightUserInput / 3; i++)
            {
                // complicated math shit, try + error in order to get it working
                for (int j = 0; j < trunk - ((widthOfTree + 1) / 3); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < widthOfTree / 3; j++)
                {
                    Console.Write("| ");
                }
                Console.WriteLine();
            }
        }
    }
}
