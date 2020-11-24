using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheImperfectOne : MonoBehaviour
{
    public Transform firstDiamondPosition;
    public GameObject firstDiamond;
    public Transform secondDiamondPosition;
    public GameObject secondDiamond;

    public Transform[] bombPositions;
    public GameObject bomb;

    public Player player;

    void Start()
    {
    }

    private float waitingTime = 0;
    void Update()
    {
        waitingTime -= Time.deltaTime;

        if(waitingTime <= 0)
        {
            SpawnDiamonds();
            waitingTime = 5;
        }
    }

    private bool useOhterDiamonds = false;
    private void SpawnDiamonds()
    {
        if (!useOhterDiamonds)
        {
            firstDiamond.GetComponentInChildren<LaserBeam>().player = player;
            Instantiate(firstDiamond, firstDiamondPosition.position, Quaternion.identity);

            secondDiamond.GetComponentInChildren<LaserBeam>().player = player;
            Instantiate(secondDiamond, secondDiamondPosition.position, Quaternion.identity);
        }
        else
        {
            for (int i = 0; i < bombPositions.Length; i++)
            {
                Instantiate(bomb, bombPositions[i].position, Quaternion.identity);
            }
        }

        useOhterDiamonds = !useOhterDiamonds;
    }
}
