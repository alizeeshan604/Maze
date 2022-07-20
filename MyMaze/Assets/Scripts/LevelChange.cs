using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelChange : MonoBehaviour
{
    int level = 1;
    public TextMeshProUGUI mytext;
    public Image[] image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changelevelfwd()
    {
        if (level < 7)
        {
            level += 1;
            mytext.text = "MAP " + level.ToString();
        }
        else
        {
            mytext.text = "MAP " + level.ToString();
        }
    }
    public void changelevelbcwd()
    {
        if (level > 1)
        {
            level -= 1;
            mytext.text = "MAP " + level.ToString();
        }
        else
        {
            mytext.text = "MAP " + level.ToString();
        }
    }
}
