using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void levelSelect()
    {
        SceneManager.LoadScene(1);
    }
    public void levelSelect2()
    {
        SceneManager.LoadScene(2);
    }
    public void levelSelect3()
    {
        SceneManager.LoadScene(3);
    }
    public void levelSelect4()
    {
        SceneManager.LoadScene(4);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

}
