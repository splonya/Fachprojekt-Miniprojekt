using Assets.Scripts.BaseBehaviors;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionController : MonoBehaviour
{
    public void Collide(Player player, Collider2D collider2D)
    {
        var collisionObject = collider2D.gameObject;  
        if(collisionObject.TryGetComponent<BaseAttacker>(out var attacker))
        {
            attacker.Attack(player);
        }
    }

    public void Collide(FriendlyProjectile projectile, Collider2D collider2D)
    {
        var collisionObject = collider2D.gameObject;

        if (collisionObject.TryGetComponent<LiveObject>(out var liveObject))
        {
            if(liveObject.isAttackable && liveObject.isHostile)
            {
                projectile.Attack(liveObject);
                if(collisionObject.CompareTag("Boss"))
                {
                    var slider = GameObject.FindGameObjectWithTag("Healthbar").GetComponent<Slider>();
                    if (slider != null)
                    {
                        slider.value = liveObject.health;
                    }
                }
            }
        }

        if (collisionObject.TryGetComponent<BaseAttacker>(out var attacker))
        {
            attacker.Attack(projectile);
        }

        if (collisionObject.TryGetComponent<BlindSpot>(out var blindSpot))
        {
            if (blindSpot.transform.parent.TryGetComponent<LiveObject>(out var parentLiveObject))
            {
                projectile.Attack(parentLiveObject);
                if (blindSpot.transform.parent.CompareTag("Boss"))
                {
                    var slider = GameObject.FindGameObjectWithTag("Healthbar").GetComponent<Slider>();
                    if (slider != null)
                    {
                        slider.value = parentLiveObject.health;
                    }
                }
            }
        }
    }

    public void Collide(EnemyProjectile projectile, Collider2D collider2D)
    {
        var collisionObject = collider2D.gameObject;

        if (collisionObject.TryGetComponent<Player>(out var player))
        {
            projectile.Attack(player);
        }

        if (collisionObject.TryGetComponent<FriendlyProjectile>(out var friendlyProjectile))
        {
            projectile.Attack(friendlyProjectile);
        }
    }
}
