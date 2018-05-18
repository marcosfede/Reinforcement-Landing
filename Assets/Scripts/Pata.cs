using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pata : MonoBehaviour {

    private GameManager gameManager;

    void Start() {
        gameManager = this.transform.parent.parent.Find("GameManager").GetComponent<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Piso") {
            gameManager.loose();
        } else {
            if (other.tag == "Base") {
                gameManager.setAboutToWin();
            }
        }
    }
}
