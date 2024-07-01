using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    private int text;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Rocks Found: " + score + "/4"; 

    }

    public void UpdateScore(int scoreToAdd) {
        score += scoreToAdd;
        scoreText.text = "Rocks Found: " + score + "/4";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
