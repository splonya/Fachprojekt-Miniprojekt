using Assets.Scripts.BaseBehaviors;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : LiveObject, IAttacker
{
    private GameObject playerObject;
    private Transform playerTransform;

    public float speed;

    protected override void Start()
    {
        base.Start();

        playerObject = GameObject.FindGameObjectWithTag("Player");
        playerTransform = playerObject.GetComponent<Transform>();
    }

    protected override void Update()
    {
        base.Update();
        transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, speed * Time.deltaTime);
    }

    public void Attack(LiveObject target)
    {
        target.health--;
    }
}
