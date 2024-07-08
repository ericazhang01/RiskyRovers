using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockexperiment : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D x) {
        Debug.Log("YAYYY");
    }

    void Start() {
        Debug.Log("what");
    }
}
