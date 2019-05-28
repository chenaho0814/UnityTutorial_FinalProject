using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MouseDetectMove : MonoBehaviour
{
    private Vector2 mousePos;
    private Vector3 screenPos;
    GameObject UFO;

    // Use this for initialization
    void Start()
    {

        UFO = GameObject.Find("UFO");
    }

    void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
        mousePos = Input.mousePosition;
        screenPos = Camera.main.ScreenToWorldPoint(
            new Vector3(mousePos.x, mousePos.y, transform.position.z - Camera.main.transform.position.z));

        //UFO.transform.DOMove(new Vector3(screenPos.x, screenPos.y, 0), 1);
        UFO.transform.DOMove( new Vector3( screenPos.x, screenPos.y , 0)  , 1 ).SetEase( Ease.InBounce );  // good reference http://robertpenner.com/easing/easing_demo.html
    }
}
