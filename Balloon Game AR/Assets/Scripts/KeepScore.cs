using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepScore : MonoBehaviour
{
    // Start is called before the first frame update
    public static int Score = 0;
    public Text x;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        x.text = Score.ToString();
    }

   /*  void OnGUI()
    {
        GUI.Box(new Rect(10, 40, 100, 100), Score.ToString());
      
    } */
}
