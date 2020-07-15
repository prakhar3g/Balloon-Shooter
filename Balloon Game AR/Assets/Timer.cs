using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update

    public Text timerText;
    private float start_t;
    void Start()
    {
        start_t = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - start_t;

        string min = ((int)t / 60).ToString();
        string sec = (t % 60).ToString("f0");

        timerText.text = min + ":" + sec;
    }
}
