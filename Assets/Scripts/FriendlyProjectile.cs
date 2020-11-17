using Assets.Scripts.BaseBehaviors;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyProjectile : LiveObject, IAttacker
{
    public float speed;

    private Vector2 target;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();

        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();

        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target) < 0.2f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D obstacle)
    {
        collisionController.Collide(this, obstacle);
    }

    public void Attack(LiveObject target)
    {
        target.health--;
    }
}
