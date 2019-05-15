using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HStotal : MonoBehaviour
{
    public Text hiScoreTotal;
    public Score info;
    public float Escore;

    public Text hscore1T;
    public Text hscore2T;
    public Text hscore3T;
    public Text hscore4T;


    public float hscore1;
    public float hscore2;
    public float hscore3;
    public float hscore4;

    void Start()
    {
        Escore = PlayerPrefs.GetFloat("HighScore");
        hscore1 = PlayerPrefs.GetFloat("hScore1");
        hscore2 = PlayerPrefs.GetFloat("hScore2");
        hscore3 = PlayerPrefs.GetFloat("hScore3");
        hscore4 = PlayerPrefs.GetFloat("hScore4");
    }


    void Update()
    {
        hiScoreTotal.text = Escore.ToString();
        hscore1T.text = hscore1.ToString();
        hscore2T.text = hscore2.ToString();
        hscore3T.text = hscore3.ToString();
        hscore4T.text = hscore4.ToString();
    }

}
