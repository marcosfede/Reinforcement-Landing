using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volcado : MonoBehaviour {

    private GameManager gameManager;

    void Start() {
        gameManager = this.transform.parent.parent.Find("GameManager").GetComponent<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        gameManager.loose();
    }
}
