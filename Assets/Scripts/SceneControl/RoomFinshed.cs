using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomFinshed : MonoBehaviour
{
    public SwitchScene loadNewSceneScript;

    public GameObject player;

    private List<GameObject> enemies;
    private GameObject boss;

    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy").OfType<GameObject>().ToList();
        boss = GameObject.FindGameObjectWithTag("Boss");
    }

    void Update()
    {
        if(player == null)
        {
            loadNewSceneScript.LoadFailScene();
        }
        else if(enemies.All(x => x == null) && boss == null)
        {
            loadNewSceneScript.LoadScene();
        }
    }
}
