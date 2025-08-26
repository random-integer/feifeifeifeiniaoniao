using System;
using UnityEngine;
using UnityEngine.Serialization;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;

    public float flapStrength;

    public LogicScript logic;

    public bool dead;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dead = false;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dead) return;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        dead = true;
    }
}
