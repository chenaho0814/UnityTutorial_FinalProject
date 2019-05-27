using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable_Action : Action
{
    public ScoreManager scoreManager; // used to report score Add
    public int nResourceNumber = 1;


    // Start is called before the first frame update
    void Start()
    {

        if (scoreManager == null)
        {

            scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
            if (scoreManager == null)
                Debug.Log("please assign score system");
        }



    }

    public override bool ExecuteAction(GameObject dataObject)
    {
        Debug.Log("Collect:" + dataObject.name + "," + nResourceNumber);
        scoreManager.AddScore(nResourceNumber);
        dataObject.SetActive(false);

        return true;
    }
}