using Assets.Scripts.BaseBehaviors;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LaserBeam : MonoBehaviour
{

    public float defDistanceRay = 500;
    public LineRenderer line;
    Transform start;
    public Player player;
    public Transform end;


    // Start is called before the first frame update
    void Start()
    {
        start = transform;
    }

    // Update is called once per frame
    void Update()
    {
        ShootLaser();
    }

    void ShootLaser()
    {
        if (Physics2D.Raycast(start.position, transform.right))
        {
            RaycastHit2D hit = Physics2D.Raycast(start.position, transform.right);
            Draw2DRay(start.position, end.position);

            if (hit.collider != null)
            {
                if (hit.collider.CompareTag("Player"))
                {
                    Draw2DRay(start.position, hit.point);
                    player.health--;
                    Debug.Log(player.health);
                }
            }

        }
        else
        {
            Draw2DRay(start.position, start.transform.right * defDistanceRay);
        }

    }

    void Draw2DRay(Vector2 startPos, Vector2 endPos)
    {

        line.SetPosition(0, startPos);
        line.SetPosition(1, endPos);
    }



}
