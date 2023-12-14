
namespace FantasyFighter
{
    public class Game
    {
        private List<Character> _enemies;

        private Hero? _player;

        public bool IsGameRunning { get; private set; }

        public Game()
        {
            this._enemies = new List<Character>()
            {
                new Dragon("Red Dragon"),
                new Dragon("Golden Dragon"),
                new Goblin("Goblin #1"),
                new Goblin("Goblin #2"),
                new Troll("Paolo"),
                new Slime("Slime #1"),
                new Slime("Slime #2")
            };
        }

        public void StartNewGame()
        {
            if (IsGameRunning)
            {
                Console.WriteLine("The game is already running");
                return;
            }

            this.IsGameRunning = true;

            // messaggio di benvenuto al giocatore
            this.DisplayWelcomeMessage();

            // chiedere al giocatore di scegliere un nome
            this.GetPlayerName();

            // chiedere al giocatore di scegliere un ruolo

            // costruire il nostro hero

            // iniziano i turni
            
            // stop game
        }

        /// <summary>
        /// this should not be done
        /// </summary>
        /// <param name="name"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        private static bool IsPlayerNameValid(string name, out string result)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                result = "The name cannot be empty or white spaces";
                return false;
            }

            string[] prohibitedWords = new string[]
            {
                ".",
                ",",
                ";",
                ":"
            };

            foreach (string prohibitedWord in prohibitedWords)
            {
                if (name.Contains(prohibitedWord))
                {
                    result = $"The name cannot include {prohibitedWord}";
                    return false;
                }
            }
            
            /*if (name.Contains("."))
                return false;
            
            if (name.Contains(","))
                return false;
            
            if (name.Contains(";"))
                return false;
            
            if (name.Contains(":"))
                return false;*/

            result = "Name is ok";
            return true;
        }
        
        private static bool IsPlayerNameValid(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                result = "The name cannot be empty or white spaces";
                return false;
            }
            
            string[] prohibitedWords = new string[]
            {
                ".",
                ",",
                ";",
                ":"
            };

            foreach (string prohibitedWord in prohibitedWords)
            {
                if (name.Contains(prohibitedWord))
                {
                    result = $"The name cannot include {prohibitedWord}";
                    return false;
                }
            }

            result = "Name is ok";
            return true;
        }
        
        private string GetPlayerName()
        {
            Console.WriteLine("Please choose your name");
            var name = Console.ReadLine();

            if (!IsPlayerNameValid(name, out string errorMessage))
            {
                Console.WriteLine(errorMessage);
            }
            
            //TODO: richiedere il nome al giocatore

            return name!;
        }

        private void DisplayWelcomeMessage()
        {
            Console.WriteLine("Messaggio di benvuto....");
        }
    }
}
