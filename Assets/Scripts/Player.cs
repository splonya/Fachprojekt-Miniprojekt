using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : LiveObject
{
    public float speed;

    public Rigidbody2D rb;
    public Text healthDisplay;
    public SwitchScene switchSceneScript;


    private Vector2 moveVelocity;

    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        healthDisplay.text = $"Health: {health}";
        base.Update();

        var moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * speed;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D obstacle)
    {
        collisionController.Collide(this, obstacle);
    }
}
