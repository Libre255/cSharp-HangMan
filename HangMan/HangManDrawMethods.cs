using static System.Console;

namespace HangManGame
{
    public partial class HangMan
    {
        private void DrawHangMan()
        {
            switch (AmountOfGuesses)
            {
                case 1:
                    Part1();
                    break;
                case 2:
                    Part1();
                    Part2();
                    break;
                case 3:
                    Part1();
                    Part2();
                    Part3();
                    break;
                case 4:
                    Part1();
                    Part2();
                    Part3();
                    Part4();
                    break;
                case 5:
                    Part1();
                    Part2();
                    Part3();
                    Part4();
                    Part5();
                    break;
                case 6:
                    Part1();
                    Part2();
                    Part3();
                    Part4();
                    Part5();
                    Part6();
                    break;
                case 7:
                    Part1();
                    Part2();
                    Part3();
                    Part4();
                    Part5();
                    Part6();
                    Part7();
                    break;
                case 8:
                    Part8();
                    Part1();
                    Part2();
                    Part3();
                    Part4();
                    Part5();
                    Part6();
                    Part7();
                    break;
                case 9:
                    Part9();
                    Part8();
                    Part1();
                    Part2();
                    Part3();
                    Part4();
                    Part5();
                    Part6();
                    Part7();
                    break;
                case 10:
                    Part9();
                    Part8();
                    Part10();
                    Part2();
                    Part3();
                    Part4();
                    Part5();
                    Part6();
                    Part7();
                    break;
            }
        }
        private void Part1()
        {
            WriteLine("    ______");
            WriteLine("   ( . u .)");
        }
        private void Part2()
        {
            WriteLine("   ___|____");
        }
        private void Part3()
        {
            WriteLine("  /   |    \\");
        }
        private void Part4()
        {
            WriteLine(" *    |     *");
        }
        private void Part5()
        {
            WriteLine("      |    ");
        }
        private void Part6()
        {
            WriteLine("     / \\");
        }
        private void Part7()
        {
            WriteLine("    0   0");
        }
        private void Part8()
        {
            WriteLine("       |");
        }
        private void Part9()
        {
            WriteLine("________________");
        }
        private void Part10()
        {
            WriteLine("    ___|___");
            WriteLine("   ( x u x )");
        }
    }
}
