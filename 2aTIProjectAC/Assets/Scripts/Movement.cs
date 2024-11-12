using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float vectorX;
    [SerializeField] float vectorY = 0;
    [SerializeField] float vectorZ;
    [SerializeField] float speed = 10;

    void Instructions()
    {
        Debug.Log("Witaj w grze");
        Debug.Log("Aby poruszac kostka naciskaj klawisze WSAD lub strzalki");
    }

    void Start()
    {
        Instructions();
    }

    void Move()
    {
        vectorX = Input.GetAxis("Horizontal");
        vectorZ = Input.GetAxis("Vertical");
        transform.Translate(vectorX * Time.deltaTime * speed, vectorY, vectorZ * Time.deltaTime * speed);
    }

    void Update()
    {
        Move();
    }



}
