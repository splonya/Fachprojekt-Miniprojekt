using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public int nextSceneId;
    public float delay = 2;
    public bool isManual = false;
    private IEnumerator WaitForSceneLoad(float delay, int sceneId)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneId);
    }

    // Start is called before the first frame update
    void Start()
    {
        if(!isManual)
        {
            LoadScene();
        }
    }

    public void LoadScene()
    {
        StartCoroutine(WaitForSceneLoad(delay, nextSceneId));
    }

    public void LoadFailScene()
    {
        StartCoroutine(WaitForSceneLoad(0, 1));
    }
}
