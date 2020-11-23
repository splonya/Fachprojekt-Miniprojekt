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

    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy").OfType<GameObject>().ToList();
    }

    void Update()
    {
        if(player == null)
        {
            loadNewSceneScript.LoadFailScene();
        }
        else if(enemies.All(x => x == null))
        {
            loadNewSceneScript.LoadScene();
        }
    }
}
