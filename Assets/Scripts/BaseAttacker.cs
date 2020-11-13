using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAttacker : MonoBehaviour
{
    public int attack = 1;

    public virtual void Attack(LiveObject target)
    {
        target.health -= attack;
    }
}
