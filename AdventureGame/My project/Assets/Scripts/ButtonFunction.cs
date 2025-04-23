using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunction : MonoBehaviour
{
    // Start is called before the first frame update
    public void ButtonDoesThings()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    public void ButtonQuits()
    {
        Application.Quit();
    }
    public void MenuWin()
    {
        SceneManager.LoadScene(0);
    }
}
