using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelChange : MonoBehaviour
{
    int level = 1;
    public TextMeshProUGUI text;
    public Image[] image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changelevel()
    {
        Debug.Log("Here I am");
        level += 1;

    }
}
