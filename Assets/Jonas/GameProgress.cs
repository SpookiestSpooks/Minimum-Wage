using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameProgress : MonoBehaviour
{
    float maxDirt;
    public GameObject[] remainingDirt;
    public Transform[] respawnLocation;
    public GameObject Player1, Player2, Player3, Player4; //prefabs
    WindowManager windowManager;

    [Header("Timer & Completion")]
    public float timer = 120;
    public float dirtCleaned;
    [Space(10)]
    [SerializeField] Text timerText;
    [SerializeField] Text percentText;

    [Header("Player Scores")]
    public Text p1Text; 
    public Text p2Text, p3Text, p4Text;
    public int p1Score, p2Score, p3Score, p4Score;
    public int scorePerClean = 10;

    private void Start()
    {
        remainingDirt = GameObject.FindGameObjectsWithTag("Wiper");
        maxDirt = remainingDirt.Length;
    }

    private void FixedUpdate()
    {
        remainingDirt = GameObject.FindGameObjectsWithTag("Wiper");

        if (Input.GetButton("Cancel"))
        {
            Application.Quit();
        }

        setupTime();
        setupCleanCount();

    }

    public void respawn(GameObject player, string playerTag)
    {    
        Destroy(player);
        StartCoroutine(waitRespawn(playerTag));
    }

    IEnumerator waitRespawn(string playerTag)
    {
        yield return new WaitForSeconds(2);
        int random = Random.Range(0,3);
        if (playerTag == "Player")
        {
            GameObject spawnedPlayer = Instantiate(Player1, respawnLocation[random].position, respawnLocation[random].rotation);
        }
        if (playerTag == "Player2")
        {
            GameObject spawnedPlayer = Instantiate(Player2, respawnLocation[random].position, respawnLocation[random].rotation);
        }
        if (playerTag == "Player3")
        {
            GameObject spawnedPlayer = Instantiate(Player3, respawnLocation[random].position, respawnLocation[random].rotation);
        }
        if (playerTag == "Player4")
        {
            GameObject spawnedPlayer = Instantiate(Player4, respawnLocation[random].position, respawnLocation[random].rotation);
        }
    }

    void setupTime()
    {
        timer = timer - Time.fixedDeltaTime;

        int minutes = Mathf.FloorToInt(timer / 60F);
        int seconds = Mathf.FloorToInt(timer - minutes * 60);
        string niceTime = string.Format("{0:00}:{1:00}", minutes, seconds);

        timerText.text = niceTime;
    }

    void setupCleanCount()
    {
        dirtCleaned = maxDirt - remainingDirt.Length;
        windowManager = gameObject.GetComponent<WindowManager>();

        percentText.text = Mathf.RoundToInt(100 * (dirtCleaned / maxDirt)) + "%";
    }

    public void getPoints(int playerNumber)
    {
        int[] playerScores = { p1Score, p2Score, p3Score, p4Score };

        playerScores[playerNumber - 1] = playerScores[playerNumber - 1] + scorePerClean;

        Text[] playerTexts = { p1Text, p2Text, p3Text, p4Text };
        playerTexts[playerNumber - 1].text = playerScores[playerNumber - 1].ToString();

        //print("Player " + playerNumber + " has gained 10 points!");
        print("Player " + playerNumber + ": " + playerScores[playerNumber-1]);
    }
}
