using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    public float timer = 0.0f;
    public float rez = 0.0f;
    public float hScore1 = 0.0f;
    public float hScore2 = 0.0f;
    public float hScore3 = 0.0f;
    public float hScore4 = 0.0f;

    float hScore1s = 0f;
    float hScore2s = 0f;
    float hScore3s = 0f;
    float hScore4s = 0f;

    public float totalScore = 0;
    public float EndHscore = 0;

    private void Start()
    {
        EndHscore = PlayerPrefs.GetFloat("HighScore", 0);
        totalScore = PlayerPrefs.GetFloat("totalScore", 0);
        hScore1 = PlayerPrefs.GetFloat("hScore1", 0);
        hScore2 = PlayerPrefs.GetFloat("hScore2", 0);
        hScore3 = PlayerPrefs.GetFloat("hScore3", 0);
        hScore4 = PlayerPrefs.GetFloat("hScore4", 0);

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            totalScore = 0f;
            hScore1s = 0f;
            hScore2s = 0f;
            hScore3s = 0f;
            hScore4s = 0f;
        }

    }

    public Transform player; // ņem transform no player (player unity jāievelk kastītē)
    public Text scoreText; // Text sadaļai







    void Update()
    {
        float PlayerPos = player.position.z;
        //scoreText.text = player.position.z.ToString("0");
        scoreText.text = rez.ToString("0");

        timer += Time.deltaTime;
        rez = PlayerPos - timer*5;



    }

    public void levelScore()
    {
        Debug.Log("              LevelScore aktivizets");
        
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            Debug.Log("             pēdējais level");
            totalScore = totalScore + rez;
            hScore4s = rez;

            if (hScore4s > hScore4)
            {
                PlayerPrefs.SetFloat("hScore4", hScore4s);
            }

            if (totalScore > PlayerPrefs.GetFloat("HighScore",0))
            {
                EndHscore = totalScore;
                Debug.Log("              highScore score labāks un seivots ?");
                PlayerPrefs.SetFloat("HighScore", EndHscore);
            }
        }
        else if(SceneManager.GetActiveScene().buildIndex == 3)
        {
            Debug.Log("          lvl3");
            totalScore = totalScore + rez;
            PlayerPrefs.SetFloat("totalScore", totalScore);
            hScore3s = rez;

            if (hScore3s > hScore3)
            {
                PlayerPrefs.SetFloat("hScore3", hScore3s);
            }

        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            Debug.Log("          lvl2");
            totalScore = totalScore + rez;
            PlayerPrefs.SetFloat("totalScore", totalScore);
            hScore2s = rez;

            if (hScore2s > hScore2)
            {
                PlayerPrefs.SetFloat("hScore2", hScore2s);
            }

        }
        else if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            Debug.Log("          lvl1");
            totalScore = totalScore + rez;
            PlayerPrefs.SetFloat("totalScore", totalScore);
            hScore1s = hScore1s + rez;

            Debug.Log(hScore1);
            Debug.Log(hScore1s);

            if (hScore1s > hScore1)
            {
                PlayerPrefs.SetFloat("hScore1", hScore1s);
                Debug.Log("hS1s > hS1");
            }

        }



        // SceneManager.LoadScene(SceneManager.GetActiveScene().name)
    }

}
