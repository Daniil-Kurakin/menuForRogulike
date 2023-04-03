using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace menuForRogulike
{
    class Game
    {
        public void Start()
        {
            Title = "Рот того шатал, Рогалик";
            RunMainMenu();
            
        }
        private void RunMainMenu()
        {
            string prompt = @"
    ______    ______    _______       __      _____  ___   
   /    "" \  /"" _  ""\  /""     ""|     /""""\    (\""   \|""  \  
  // ____  \(: ( \___)(: ______)    /    \   |.\\   \    | 
 /  /    ) :)\/ \      \/    |     /' /\  \  |: \.   \\  | 
(: (____/ // //  \ _   // ___)_   //  __'  \ |.  \    \. | 
 \        / (:   _) \ (:      ""| /   /  \\  \|    \    \ | 
  \""_____/   \_______) \_______)(___/    \___)\___|\____\) 
                                                           
Шалом, рады видеть тебя в нашем Рог, блять, алике.
(для управления в меню стрелку вниз-вверх тыкай, не заблудишься. Enter - )";
            string[] options = { "Play","Save Game", "Load Game", "Learning", "Setting","About of creaters", "Exit"};
            Menu mainMenu = new Menu(prompt,options);
            int selectedIndex = mainMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    RunGame();
                    break;
                case 1:
                    Learning();
                    break;
                case 2:
                    DisplayOptionsMenu();
                    break;
                case 3:
                    DisplayAboutInfo();
                    break;
                case 4:
                    ExitGame();
                    break;
            }
            ReadKey(true);
        }
        private void RunGame()
        {
            
        }
        private void DisplayOptionsMenu()
        {
            string prompt = "Here you can customize the game for yourself";
            string[] options = { "Sound settings", "Control Settings", "Back to menu" };
            Menu optionsMenu = new Menu(prompt,options);
            int selectedIndex = optionsMenu.Run();
            switch(selectedIndex) 
            {

            }
        }
        private void Learning()
        {
            Clear();
            WriteLine($"Аптечка {'+'} - hill from 15 to 50 хп\n" +
                $"Топор {'þ'} - на карте 1 топор. Damage - 30, blocking - 20, stun percentage - 50, прочность - 15\n" +
                $"Кемпинговая лампа {'Ì'} - there are at least 5 pieces on the map. Blocking - 10, +3 visibility cells, прочность - 3\n" +
                $"Зажигалка {'§'} - Базовый предмет. +2 visibility cells\n" +
                $"");
        }
        private void DisplayAboutInfo()
        {
            string prompt = @"Чепенко Маргарита - Mommy детского сада
Паталаха Арсений - ""Папа, не бей""
Перцев Алексей - DJ Smash
Мальцев Максим - бездарный бездарь
Куракин Даниил - ленивый шакал";
            string[] options = { "<<Вернуться в меню>>" };
            Menu authorsMenu = new Menu(prompt, options);
            int selectedIndex = authorsMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                RunMainMenu();
                break;
            }   
        }
        private void ExitGame()
        {
            Clear();
            WriteLine("\nНажми куда-нибудь для выхода");
            ReadKey(true);
            Environment.Exit(0);
        }
    }
}
