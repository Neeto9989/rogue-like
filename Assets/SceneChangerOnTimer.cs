using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChangerOnTimer : MonoBehaviour
{
    public float changeTime;
    public string SceneName;

    // Update is called once per frame
    void Update()
    {
        changeTime -= Time.deltaTime;
        if (changeTime <= 0)
        {
            SceneManager.LoadScene(SceneName);
        }
    }
    public void SkipScene()
    {
        SceneManager.LoadScene(SceneName);
    }
}
