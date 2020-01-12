using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float num = 0;
    public Text score;

    // Update is called once per frame
    void Update()
    {
        num += Time.deltaTime;
        score.text = "Score: " + (num).ToString("0");
    }
}
