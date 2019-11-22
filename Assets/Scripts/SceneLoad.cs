using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("GOGOGOGO SCENE");

        SceneManager.LoadScene("BossScene", LoadSceneMode.Single); //load this scene... change SCENENAME to the name of the scene you want
        SceneManager.UnloadScene(0);
    }
}
