using UnityEngine.SceneManagement;
using UnityEngine;

public class BackSelect : MonoBehaviour
{
    public void BaccToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void resetAllScores()
    {
        PlayerPrefs.DeleteAll();
    }
}
