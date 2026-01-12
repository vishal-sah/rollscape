using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("MiniGame");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
