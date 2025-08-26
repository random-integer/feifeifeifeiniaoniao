using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public TMPro.TMP_Text scoreText;

    public GameObject gameOverScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("Add Score")]
    public void addScore(int increment)
    {
        playerScore += increment;
        scoreText.text = "スコア: " + playerScore.ToString();
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        scoreText.color = Color.white;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
