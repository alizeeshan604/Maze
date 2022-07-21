using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject aboutUsPanel;

    private void OnEnable()
    {
        // Load Main Menu Panel
        aboutUsPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
    public void OnClick_PlayBtn()
    {
        // Load Level Selection Scene
        SceneManager.LoadScene(1);
    }

    public void OnClick_AboutUsBtn()
    {
        // Load About Us Panel
        mainMenuPanel.SetActive(false);
        aboutUsPanel.SetActive(true);

    }

    public void OnClick_CloseBtn()
    {
        Debug.Log("exited");
        Application.Quit();
    }
}
