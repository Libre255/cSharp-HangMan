using static System.Console;
using System.Text;

namespace HangManGame
{
    public partial class HangMan
    {
        bool FoundSecretWord = false;
        int AmountOfGuesses = 0;
        string[] SecretWords = { "Hund", "Boll", "Psykologi", "Tyngdlifting" };
        string SecretWord;
        int SecretWordIndex;
        char[] CorrectWords;
        StringBuilder WrongGuesses;
        public void StartGame()
        {
            SecretWordIndex = RandomSecretWord();
            string userInput;

            do
            {
                DisplaySecretWord();
                DisplayWrongGuesses();
                userInput = ReadLine().ToLower();
                CheckEqualWords(userInput, SecretWordIndex);
                DrawHangMan();
            } while (!FoundSecretWord && AmountOfGuesses < 10);

            EndGame(SecretWordIndex);
        }
        private void EndGame(int SWI)
        {
            if (AmountOfGuesses == 10)
            {
                WriteLine("You lose");
            }
            else
            {
                WriteLine("Congratulation you found the secret word!");
            }
            WriteLine($"The secret word is: {SecretWords[SWI]}");

            WriteLine("Press any key to play again");
            ReadKey();
            Clear();
            StartGame();
        }
        private int RandomSecretWord()
        {
            FoundSecretWord = false;
            AmountOfGuesses = 0;
            WrongGuesses = new StringBuilder();
            int randomNr = new Random().Next(0, SecretWords.Length - 1);
            SecretWord = SecretWords[randomNr];
            CorrectWords = new char[SecretWord.Length];
            for (int j = 0; j < CorrectWords.Length; j++)
            {
                CorrectWords[j] = '_';
            }
            
            return randomNr;
        }
        private void CheckEqualWords(string userInput, int SecretWordIndex)
        {
            Clear();
            string SecretWordLowCase = SecretWord.ToLower();
            if (userInput.Length == 1)
            {
                if (SecretWordLowCase.Contains(userInput))
                {
                    int index = SecretWordLowCase.IndexOf(userInput);
                    CorrectWords[index] = SecretWord.ToArray()[index];
                    SecretWord = SecretWord.Remove(index, 1).Insert(index, "_");
                    if (new string(CorrectWords) == SecretWords[SecretWordIndex])
                    {
                        FoundSecretWord = true;
                    }
                }
                else
                {
                    AddWrongGuesses(userInput);
                }
            }
            else if (userInput.Length > 1)
            {
                if (userInput == SecretWords[SecretWordIndex].ToLower())
                {
                    CorrectWords = SecretWord.ToArray();
                    FoundSecretWord = true;
                }
                else
                {
                    AddWrongGuesses(userInput);
                }
            }
        }
        private void DisplaySecretWord()
        {
            foreach (char letter in CorrectWords)
            {
                Write($" {letter} ");
            }
            WriteLine(" ");
        }
        private void DisplayWrongGuesses()
        {
            if (AmountOfGuesses > 0)
            {
                WriteLine(" ");
                WriteLine("[Wrong guesses below]");
                WriteLine(WrongGuesses.ToString());
            }
        }
        private void AddWrongGuesses(string userInput)
        {
            bool checkWgContainsInput = WrongGuesses.ToString().Split(", ").Contains(userInput);
            bool SecretWordLowCase = new string(CorrectWords).ToLower().Contains(userInput);

            if (!SecretWordLowCase && !checkWgContainsInput)
            {
                AmountOfGuesses++;
                WrongGuesses.Append($"{userInput}, ");
            }
        }
    }
}
