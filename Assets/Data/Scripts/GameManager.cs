using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public static GameManager instance;

    //[SerializeField] public GameObject winScreen;
    //[SerializeField] public GameObject Stars_3;
    //[SerializeField] public GameObject Stars_2;
    //[SerializeField] public GameObject Stars_1;
    //[SerializeField] public GameObject loseScreen;
    //[SerializeField] public GameObject confettiPS;

    //[SerializeField] private int totalBalls;
    //[SerializeField] private int ballCounter;

    //[SerializeField] private int totalStars;
    //[SerializeField] private int starCounter;

    //[SerializeField] private string nextLevel;

    //[SerializeField] private string startLevel;

    //// Scoring
    //[SerializeField] private int score = 0;
    //private int scoreInc = 10;

    //private void Awake()
    //{
    //    totalBalls = GameObject.FindGameObjectsWithTag("Ball").Length;
    //    ballCounter = 0;
    //    totalStars = GameObject.FindGameObjectsWithTag("Star").Length;
    //    starCounter = 0;

    //    if (instance == null)
    //        instance = this;
    //    else
    //        Destroy(gameObject);

    //    if (PlayerPrefs.HasKey("Level"))
    //    {
    //        startLevel = PlayerPrefs.GetString("Level");
    //    }
    //    else
    //    {
    //        startLevel = "Level01";
    //    }
    //}

    //public void GoalReached(GameObject ball)
    //{
    //    Destroy(ball, 2);
    //    ball.GetComponent<Ball>().enabled = false;
    //    ballCounter++;

    //    if (ballCounter == totalBalls)
    //    {
    //        StartCoroutine(Delay());
    //        AudioManager.instance.Play("Goal");
    //        if (confettiPS != null)
    //        {
    //            confettiPS.SetActive(true);
    //        }
    //    }
    //}

    //public void YouLose()
    //{
    //    if (loseScreen != null)
    //    {
    //        loseScreen.SetActive(true);
    //    }
    //}

    //public void IncrementScore()
    //{
    //    score += scoreInc;
    //    starCounter++;
    //}

    //public int GetScore()
    //{
    //    return this.score;
    //}

    //public void PlayGame()
    //{
    //    SceneManager.LoadScene(startLevel);
    //    SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
    //}

    //public void MainMenu()
    //{
    //    SceneManager.LoadScene("MainMenu");
    //    SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
    //}

    //public void NextLevel()
    //{
    //    AudioManager.instance.Stop();
    //    PlayerPrefs.SetString("Level", nextLevel);
    //    SceneManager.LoadScene(nextLevel);
    //    SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
    //}

    //public void ReplayLevel()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //    SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
    //}

    //private void DisplayStars()
    //{
    //    if (starCounter == 1)
    //    {
    //        Stars_1.SetActive(true);
    //    }
    //    else if (starCounter == 2)
    //    {
    //        Stars_2.SetActive(true);
    //    }
    //    else if (starCounter == 3)
    //    {
    //        Stars_3.SetActive(true);
    //    }
    //}

    //IEnumerator Delay()
    //{
    //    yield return new WaitForSeconds(4);
    //    if (winScreen != null)
    //    {
    //        winScreen.SetActive(true);
    //        if (starCounter > 0)
    //        {
    //            DisplayStars();
    //        }
    //    }
    //}
}
