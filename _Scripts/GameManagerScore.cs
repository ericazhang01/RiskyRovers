using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerScore : MonoBehaviour
{

    public TextMeshProUGUI mainText;
    public int score = 0;
   

    void Start() {
        mainText.text = "Items Found: " + score + "/8";
    }
    public void UpdateScore(int s) {
        score += s;
        mainText.text = "Items Found: " + score + "/8";
    }

}


