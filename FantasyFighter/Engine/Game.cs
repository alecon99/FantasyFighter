
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
        
        private class PlayerNameCheckResult
        {
            public bool IsValid { get; }
            
            public string ErrorMessage { get; }

            public PlayerNameCheckResult(bool isValid, string errorMessage)
            {
                IsValid = isValid;
                ErrorMessage = errorMessage;
            }
        }
        
        private PlayerNameCheckResult IsPlayerNameValid(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return new PlayerNameCheckResult(false,"The name cannot be empty or white spaces");
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
                    return new PlayerNameCheckResult(false,$"The name cannot include {prohibitedWord}");
                }
            }
            
            return new PlayerNameCheckResult(true,"Name is ok");
        }
        
        private string GetPlayerName()
        {
            Console.WriteLine("Please choose your name");
            var name = Console.ReadLine();

            var playerNameCheck = IsPlayerNameValid(name);

            if (!playerNameCheck.IsValid)
            {
                Console.WriteLine(playerNameCheck.ErrorMessage);
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
