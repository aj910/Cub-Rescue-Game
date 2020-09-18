using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    
    public int startingLives;
    private int lifeCounter;

    private Text theText;

    // Start is called before the first frame update
    void Start()
    {
        theText = GetComponent<Text>();

        lifeCounter = startingLives;
    }

    // Update is called once per frame
    void Update()
    {
        if(lifeCounter <= 0)
        {
            SceneManager.LoadScene ("GameOver");
        }
        theText.text = "x " + lifeCounter;
    }

    public void TakeLife(int Damage)
    {
        lifeCounter -= Damage;
    }

    public void FullLife()
    {
        lifeCounter = startingLives;
    }
}
