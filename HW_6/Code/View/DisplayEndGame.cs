using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

namespace Game
{
    public sealed class DisplayEndGame
    {
        private Text _endGameLabel;

        public DisplayEndGame(GameObject endGame,GameObject restartButton,GameObject nextLevel)
        {
            _endGameLabel = endGame.GetComponentInChildren<Text>();
            _endGameLabel.text = String.Empty;
        }

        public void GameOver(string name)
        {
            _endGameLabel.text = $"Вы проиграли. Вас убил {name}!";
        }
        public void FinishGame(string name)
        {
            _endGameLabel.text = $"Победа!{name}";
        }
    }
}


