using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int score;
    private float time;
    private Player player;
    public bool startGame;
    public bool gameOver;
    [SerializeField] private GameObject startScreen;
    [SerializeField] private GameObject ingameScreen;
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private TextMeshProUGUI scoreTextOver;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        score = 0;
        scoreText.text = "Score: " + score;
        time = 61;
        timeText.text = "Time: "+time;
        startGame = false;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (startGame)
        {
            time -= Time.deltaTime;
            timeText.text = "Time: " + (int)time;
        }
        if (time < 0)
        {
            startGame = false;
            gameOver = true;
            ingameScreen.SetActive(false);
            scoreTextOver.text = "Your Score: " + score;
            gameOverScreen.SetActive(true);
        }
    }
    public void IncreaseScore(int scoreToAdd)
    {
        this.score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
    public void SetWhite()
    {
        player.meshRend.material.SetColor("_Color", Color.white);
    }
    public void SetBlack()
    {
        player.meshRend.material.SetColor("_Color", Color.black);
    }
    public void SetYellow()
    {
        player.meshRend.material.SetColor("_Color", Color.yellow);
    }
    public void SetRed()
    {
        player.meshRend.material.SetColor("_Color", Color.red);
    }
    public void StartGame()
    {
        startGame = true;
        startScreen.SetActive(false);
        ingameScreen.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
