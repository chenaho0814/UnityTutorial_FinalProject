using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementMoveNormal : MonoBehaviour
{

    public float speed = 10;

    public bool bMoveVertical = true;
    public bool bMoveHorizon = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (bMoveVertical) {
            if (Input.GetKey(KeyCode.W))
            {
                this.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
            }

            if (Input.GetKey(KeyCode.S))
            {
                this.transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
            }
        }


        if (bMoveHorizon) {
            if (Input.GetKey(KeyCode.A))
            {
                this.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
            }

            if (Input.GetKey(KeyCode.D))
            {
                this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            }
        }



    }
}
