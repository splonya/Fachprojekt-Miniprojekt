using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APISupportedObject : MonoBehaviour
{
    protected CollisionController collisionController;
    protected virtual void Start()
    {
        var api = GameObject.FindGameObjectWithTag("API");
        collisionController = api.GetComponent<CollisionController>();
    }
}
