using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveObject : APISupportedObject
{
    public int health;
    public bool isAttackable = true;

    protected Action deathCallback;
    protected virtual void Update()
    {
        if(health <= 0)
        {
            deathCallback?.Invoke();

            Debug.Log($"{gameObject.name} has health 0 and will be destroyed");
            Destroy(gameObject);
        }
    }
}
