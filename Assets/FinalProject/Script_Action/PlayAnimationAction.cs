using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayAnimationAction : Action
{
    public string sAnimationName="";


    public override bool ExecuteAction(GameObject dataObject) {


        gameObject.GetComponent<Animator>().Play(sAnimationName );

        return true;
    }
}
