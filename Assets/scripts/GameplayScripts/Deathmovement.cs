﻿using UnityEngine;
using System.Collections;

public class Deathmovement : MonoBehaviour {

    protected Vector3 velocity;
    public Transform transformm;
    public float distance = 5f;
    public float speed = 1f;
    Vector3 originalPosition;
    bool isGoingUp = false;
    public float distFromStart;
    public void Start()
    {
        originalPosition = gameObject.transform.position;
        transformm = GetComponent<Transform>();
        velocity = new Vector3(0, speed, 0);
        transformm.Translate(0, velocity.y * Time.deltaTime, 0);
    }

    void Update()
    {
        distFromStart = transformm.position.y - originalPosition.y;

        if (isGoingUp)
        {
            // Ändrar riktining nedåt
            if (distFromStart < -distance)
            {
                SwitchDirection();
            }
            transformm.Translate(0, -velocity.y * Time.deltaTime, 0);
            
        }
        else
        {
            // ändrar riktning uppåt
            if (distFromStart > distance)
            {
                SwitchDirection();
            }
            transformm.Translate(0, velocity.y * Time.deltaTime, 0);
        }
    }

    void SwitchDirection()
    {
        isGoingUp = !isGoingUp;
    }
}
