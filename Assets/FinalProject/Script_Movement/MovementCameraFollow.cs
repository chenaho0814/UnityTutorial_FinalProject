using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCameraFollow : MonoBehaviour
{

    public float nOffset_X = 0;
    public float nOffset_Y = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.transform.position = new Vector3(gameObject.transform.position.x + nOffset_X, gameObject.transform.position.y + nOffset_Y, -10);
        
    }
}
