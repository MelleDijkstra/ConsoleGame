using System;

namespace ConsoleGame
{
    class Game
    {
        public GameForm _gameForm;
        public Game(GameForm gameForm)
        {
            _gameForm = gameForm;
            Player player = Player.Instance();
            player.location = new LocationBeach();
            Player randomEntity = Player.Instance();

            _gameForm.locationTextBox.Text = LocationManager.ToString();
        }
    }
}
