using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour {

    public float speed = 0.1f;
    public float amplitude = 1f;


	// Use this for initialization
	void Start () {
	}

    void Update()
    {
        // transform.localPosition = initialPos + new Vector2(amplitude * Mathf.Sin(Time.time * speed), 0);
    }
}
