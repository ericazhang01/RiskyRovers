using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScore : MonoBehaviour
{
   private GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    private void OnMouseDown() {
        gameManager.UpdateScore(1);
    }

}
