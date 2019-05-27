using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Collider2D))]
public class Condition_MouseClick : ConditionBase
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        
    }

    void OnMouseDown()
    {
        Vector2 mousePos;
        Vector3 screenPos;

        Debug.Log("OnMouseDown");

        mousePos = Input.mousePosition;
        screenPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, transform.position.z - Camera.main.transform.position.z));

        Collider2D cold = gameObject.GetComponent<Collider2D>();
        if (cold)
        {
            if (cold.OverlapPoint(screenPos))
            {

                /// check the collectable 
                //Collectable_Attribute collectable = gameObject.GetComponent<Collectable_Attribute>();
                //if (collectable)
                //{
                //    collectable.Collect();
                //}
                ExecuteAllActions( gameObject);


            }
        }
        else
        {

            /// print an hint to request CircleCollider2D
        }

    }


}
