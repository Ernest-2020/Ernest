
using UnityEngine;
using System;
using UnityEngine.UI;

public class DisplayFishGame
{
    private Text _finishGameLabel;

    public DisplayFishGame(GameObject endGame)
    {
        _finishGameLabel = endGame.GetComponentInChildren<Text>();
        _finishGameLabel.text = String.Empty;
    }

    public void FinishGame(string name)
    {
        _finishGameLabel.text = "Вы победили!";
    }
}

