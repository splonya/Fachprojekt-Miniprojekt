using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public void Collide(Player player, Collider2D collider2D)
    {
        var collisionObject = collider2D.gameObject;

        if(collisionObject.TryGetComponent<Enemy>(out var enemy))
        {
            Collide(player, enemy);
        }
    }

    public void Collide(Projectile projectile, Collider2D collider2D)
    {
        var collisionObject = collider2D.gameObject;

        if (collisionObject.TryGetComponent<Enemy>(out var enemy))
        {
            Collide(projectile, enemy);
        }
    }

    private void Collide(Player player, Enemy enemy)
    {
        enemy.Attack(player);
    }

    private void Collide(Projectile projectile, Enemy enemy)
    {
        projectile.Attack(enemy);   
        enemy.Attack(projectile);
    }
}
