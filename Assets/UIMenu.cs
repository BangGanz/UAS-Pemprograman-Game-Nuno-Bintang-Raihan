using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void play()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Gamez");
    }

    public void credit()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Credit");
    }

    public void menu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }

    public void quit()
    {
        // If we are in the editor, stop the play mode.
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            // Quit the game in a built version
            Application.Quit();
#endif
    }
}