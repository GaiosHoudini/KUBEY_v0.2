using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{


    public void Quit ()
    {
        Application.Quit();
    }

    public void StartMenu()
    {
        SceneManager.LoadScene(0);
    }


}
