using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int score;
    public int playerHP = 100;
    public int rockets = 50;
    public float laserEnergy = 100f;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void AddScore(int amount) => score += amount;

    public void DamagePlayer(int amount)
    {
        playerHP -= amount;
        if (playerHP <= 0) GameOver();
    }

    void GameOver()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
