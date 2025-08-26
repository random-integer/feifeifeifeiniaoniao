using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;

    public float flapStrength;

    public LogicScript logic;

    private bool dead;

    private InputAction flapAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dead = false;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        flapAction = InputSystem.actions.FindAction("jump");
    }

    // Update is called once per frame
    void Update()
    {
        if (dead) return;
        if (flapAction.triggered)
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
