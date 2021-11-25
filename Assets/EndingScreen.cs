using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingScreen : MonoBehaviour
{
    [Header("Data")]
    public List<Transform> spawnPoints;

    [Header("UI")]
    public Text firstText;
    public Text secondText, thirdText, fourthText;

    private void Start()
    {
        firstText.text = PublicScores.player1Score.ToString();
        secondText.text = PublicScores.player2Score.ToString();
        thirdText.text = PublicScores.player3Score.ToString();
        fourthText.text = PublicScores.player4Score.ToString();

    }

    void Update()
    {
        if (Input.GetButton("Cancel"))
        {
            Application.Quit();
        }
    }
}
