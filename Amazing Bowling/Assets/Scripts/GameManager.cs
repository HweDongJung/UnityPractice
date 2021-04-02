using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public UnityEvent onReset;

    public static GameManager instance;

    private int score;
    public ShooterRotator shooterRotator;
    public CamFollow cam;
    public Text scoreText;
    public Text bestScoreText;
    public Text messageText;
    public GameObject readyPannel;
    private bool isRoundActive;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        StartCoroutine("RoundRoutine");
    }

    public void AddScore(int newScore)
    {
        score += newScore;
        UpdateBestScore();
    }

    int GetBestScore()
    {
        return PlayerPrefs.GetInt("BestScore");
    }

    void UpdateBestScore()
    {
        if (GetBestScore() < score)
        {
            PlayerPrefs.SetInt("BestScore", score);
        }
    }

    

    // Update is called once per frame
    void UpdateUI()
    {
        scoreText.text = "Score: " + score;
        bestScoreText.text = "Best Score: " + GetBestScore(); 
    }

    public void OnBallDestroy()
    {
        UpdateUI();
        isRoundActive = false;
    }

    public void Reset()
    {
        score = 0;
        UpdateUI();

        StartCoroutine("RoundRoutine");
    }

    IEnumerator RoundRoutine()
    {
        onReset.Invoke();

        readyPannel.SetActive(true);
        
        cam.SetTarget(shooterRotator.transform, CamFollow.State.Idle);
        shooterRotator.enabled = false;

        isRoundActive = false;
        messageText.text = "Ready...";

        yield return new WaitForSeconds(3f);

        isRoundActive = true;
        readyPannel.SetActive(false);
        shooterRotator.enabled = true;
        cam.SetTarget(shooterRotator.transform, CamFollow.State.Ready);

        while (isRoundActive == true)
        {
            yield return null;
        }

        readyPannel.SetActive(true);
        shooterRotator.enabled=false;

        yield return new WaitForSeconds(3f);
        Reset();
    }

}
