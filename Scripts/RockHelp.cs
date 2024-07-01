using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockHelp : MonoBehaviour
{
    private GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }

    private void OnMouseDown() {
        gameManager.UpdateScore(1);

    } 
}
