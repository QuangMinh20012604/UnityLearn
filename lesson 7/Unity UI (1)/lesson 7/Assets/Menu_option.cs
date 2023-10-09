
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_option : MonoBehaviour
{
    public void Exit_Home()
    {
        SceneManager.LoadScene(0);
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
