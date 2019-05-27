using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void UFOAnimationHit() {
        gameObject.GetComponent<Animator>().SetTrigger("IsHit");
    }


    // Update is called once per frame
    void Update()
    {
    
        
    }
}
