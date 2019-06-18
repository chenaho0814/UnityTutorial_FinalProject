using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAssignActionOnStart : MonoBehaviour
{
    public Action mAssignAction;

    // Start is called before the first frame update
    void Start()
    {

        if (mAssignAction)
            mAssignAction.ExecuteAction(null);


    }
}
