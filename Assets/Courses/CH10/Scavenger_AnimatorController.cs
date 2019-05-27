using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Scavenger_AnimatorController : MonoBehaviour
{

    public string []animatorName;


    [Header("How To Test?:Input trigger name,  Click it")]
    [Header("---- TEST AREA ----")]
    public string sTestAnimateName = "";
    public bool bTestFlag=false;


    // Start is called before the first frame update
    void Start()
    {
        AnimatorTriggerByName("");
    }


    public int AnimatorTriggerByName( string sTriggerName) {

        for (int i =0; i < animatorName.Length; i ++ ) {
            //Debug.Log("i=" + i);

        if( sTriggerName == animatorName[i] )
        
            gameObject.GetComponent<Animator>().SetTrigger(sTriggerName);
            return 1;
        }

        return 0;

    }


    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.T)) bTestFlag = true;

        if(bTestFlag == true) {
            bTestFlag = false;
            gameObject.GetComponent<Animator>().SetTrigger(sTestAnimateName);
        }


    }
}
