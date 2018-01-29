using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nave : MonoBehaviour
{

    private GameObject motorDerecho;
    private GameObject motorIzquierdo;
    private GameObject motorCentral;
    private GameObject fuegoCentral;
    private GameObject fuegoDerecho;
    private GameObject fuegoIzquierdo;
    public Rigidbody2D rigidBody;

    public float thrust = 0F;
    public float latThrust = 0.8F;

    void Start()
    {
        motorDerecho = transform.Find("Derecha").gameObject;
        motorIzquierdo = transform.Find("Izquierda").gameObject;
        motorCentral = transform.Find("Centro").gameObject;
        fuegoCentral = motorCentral.transform.Find("Fuego").gameObject;
        fuegoDerecho = motorDerecho.transform.Find("Fuego").gameObject;
        fuegoIzquierdo = motorIzquierdo.transform.Find("Fuego").gameObject;
        rigidBody = GetComponent<Rigidbody2D>();
    }

    public void Idle()
    {
        fuegoCentral.SetActive(false);
        fuegoDerecho.SetActive(false);
        fuegoIzquierdo.SetActive(false);
    }

    public void MoveLeft()
    {
        rigidBody.AddRelativeForce(motorDerecho.transform.up * latThrust);
        fuegoDerecho.SetActive(true);
    }

    public void MoveRight()
    {
        rigidBody.AddRelativeForce(motorIzquierdo.transform.up * latThrust);
        fuegoIzquierdo.SetActive(true);
    }

    public void MoveUp()
    {
        rigidBody.AddRelativeForce(motorCentral.transform.up * thrust);
        fuegoCentral.SetActive(true);

    }

    public void turnOffCentralFire()
    {
        fuegoCentral.SetActive(false);
    }

    public void turnOffLeftFire()
    {
        fuegoIzquierdo.SetActive(false);
    }

    public void turnOffRightFire()
    {
        fuegoDerecho.SetActive(false);
    }
    //void Update()
    //{
    //    if (Input.GetKey(KeyCode.UpArrow))
    //    {
    //        MoveUp();
    //    }
    //    else
    //    {
    //        turnOffCentralFire();
    //    }
    //    if (Input.GetKey(KeyCode.LeftArrow))
    //    {
    //        MoveLeft();
    //    }
    //    else
    //    {
    //        turnOffRightFire();
    //    }
    //    if (Input.GetKey(KeyCode.RightArrow))
    //    {
    //        MoveRight();
    //    }
    //    else
    //    {
    //        turnOffLeftFire();
    //    }
    //}
}
