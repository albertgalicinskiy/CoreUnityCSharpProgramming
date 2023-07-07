using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Adding namespace to use Unity Scene Manager

public class LevelLoader : MonoBehaviour
{

    public int sceneNumber;

    // Start is called before the first frame update
    void Start()
    {
        print("Level Loaded");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // If we click to the left mouse button Level will be Reloaded or Restarted
        {
            // LoadLevel();

            RestartLevel();
        } 
    }

    void LoadLevel()
    {
        // SceneManager.LoadScene("Level2"); // Load Level using Scene Name
        // SceneManager.LoadScene(1); // Load Level using Scene Index
        // SceneManager.LoadScene(sceneNumber); // Load Level using Scene Index setted in Inspector as a value of the Variable
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Restart Current Level/Scene
    }
}
