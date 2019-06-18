using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public string levelName = SAME_SCENE;
    public const string SAME_SCENE = "0";


    // Start is called before the first frame update
    public void RunLoadLevel() {


        if (levelName == SAME_SCENE)
        {
            //just restart the level
            SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
        }
        else
        {
            //load another scene
            SceneManager.LoadScene(levelName, LoadSceneMode.Single);
        }
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
