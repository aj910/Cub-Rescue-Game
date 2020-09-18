using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    float currentTime = 0f;

    float startTime = 180f;

    [SerializeField]
    Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("000");

        if(currentTime <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
