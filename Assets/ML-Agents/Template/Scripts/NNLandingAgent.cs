using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NNLandingAgent : Agent
{
    private GameObject platform;
    private Rigidbody2D rb;
    private GameManager gameManager;
    private Nave shipController;
    public NNLandingAcademy academy;

    public override void InitializeAgent()
    {
        base.InitializeAgent();
        academy = GameObject.Find("NNLandingAcademy").GetComponent<NNLandingAcademy>();
        rb = this.GetComponent<Rigidbody2D>();
        shipController = this.GetComponent<Nave>();
        platform = this.transform.parent.Find("Base").gameObject;
        gameManager = this.transform.parent.Find("GameManager").GetComponent<GameManager>();
    }

    public override List<float> CollectState()
    {
        Vector2 position = rb.position;
        Vector2 speed = rb.velocity;
        List<float> state = new List<float> { 
            position.x - platform.transform.position.x,
            position.y - platform.transform.position.y,
            speed.x,
            speed.y
        };
        return state;
    }

    public override void AgentStep(float[] act)
    {


        int action = (int)act[0];


        if (action == 1)
        {
            shipController.MoveLeft();
        }
        else
        {
            shipController.turnOffRightFire();
        }
        if (action == 2)
        {
            shipController.MoveRight();
        }
        else
        {
            shipController.turnOffLeftFire();

        }
        if (action == 3)
        {
            shipController.MoveUp();
        }
        else
        {
            shipController.turnOffCentralFire();
        }
        if (action == 4)
        {
            shipController.MoveLeft();
            shipController.MoveUp();
        }
        else
        {
            shipController.turnOffRightFire();
            shipController.turnOffCentralFire();
        }
        if (action == 5)
        {
            shipController.MoveRight();
            shipController.MoveUp();
        }
        else
        {
            shipController.turnOffLeftFire();
            shipController.turnOffCentralFire();
        }

        if (gameManager.won)
        {
            reward += 1;
            done = true;
        }
        else if (gameManager.lost)
        {
            reward -= 1;
            done = true;
        }
        else
        {
            //reward -= 0.005f;
        }
    }

    public override void AgentReset()
    {
        gameManager.reset();
    }

    public override void AgentOnDone()
    {

    }
}
