using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelChange : MonoBehaviour
{
    int level = 1;
    public TextMeshProUGUI mytext;
    public Sprite[] imageDisplay;
    public Image levelImage;

    
    public void changelevelfwd()
    {
        if (level < 6)
        {
            level += 1;
            mytext.text = "MAP " + (level).ToString();
            ActivateImage(level);

        }
    }
    
    public void changelevelbcwd()
    {
        if (level > 1)
        {
            level -= 1;
            mytext.text = "MAP " + (level).ToString();
            ActivateImage(level);
        }
    }

    public void ActivateImage(int index)
    {
        levelImage.sprite = imageDisplay[index-1];
    }


    public void loadlevel()
    {
        print(level);
        if (level == 1)
        {
            SceneManager.LoadScene("MapOne");
        }
    }

}
