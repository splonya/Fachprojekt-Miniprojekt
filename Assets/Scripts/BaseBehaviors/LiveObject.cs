using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveObject : APISupportedObject
{
    public int health;

    protected virtual void Update()
    {
        if(health <= 0)
        {
            Debug.Log($"{gameObject.name} has health 0 and will be destroyed");
            Destroy(gameObject);
        }
    }
}
