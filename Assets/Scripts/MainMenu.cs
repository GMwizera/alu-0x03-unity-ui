using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayMaze()
    {
        SceneManager.LoadScene("maze");
    }

    public void QuitMaze()
    {
        // Application.Quit() does nothing in the editor, so log it too.
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
