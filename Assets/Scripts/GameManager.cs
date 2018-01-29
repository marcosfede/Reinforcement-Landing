using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private GameObject nave;
    private GameObject winObj;
    private GameObject looseObj;
    private GameObject baseObj;
    private bool aboutToWin;
    public bool lost;
    public bool won = false;
    private Rigidbody2D naveRB;

    void Start() {
        nave = this.transform.parent.Find("Nave").gameObject;
        winObj = GameObject.Find("UI").transform.Find("Win").gameObject;
        looseObj = GameObject.Find("UI").transform.Find("Loose").gameObject;
        naveRB = nave.GetComponent<Rigidbody2D>();
        baseObj = transform.parent.Find("Base").gameObject;
        reset();
    }

    public void setAboutToWin() {
        aboutToWin = true;
    }

    public void win() {
        won = true;
        nave.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        // winObj.SetActive(true);
    }

    public void loose() {
        lost = true;
        nave.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        // looseObj.SetActive(true);
    }

    public void reset() {
        won = false;
        lost = false;
        aboutToWin = false;
        looseObj.SetActive(false);
        winObj.SetActive(false);
        nave.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        nave.transform.localPosition = new Vector2(Random.Range(-2F, 2F), 4F);
        nave.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
        baseObj.transform.localPosition = new Vector2(Random.Range(-4F, 4F), baseObj.transform.localPosition.y);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            reset();
        }
        if (naveRB.velocity.magnitude < 0.001f && aboutToWin && !lost) {
            win();
        }
    }
}
