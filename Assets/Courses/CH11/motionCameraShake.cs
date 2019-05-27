using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class motionCameraShake : MonoBehaviour
{
    public float fDuration = 0.5f;
    public float fStrength = 1f;

    Tweener shakeTween;
    //TweenCallback shakeTweenComplete;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MotionCameraShaking() {

        shakeTween = Camera.main.transform.DOShakePosition(fDuration, fStrength);
        shakeTween.OnComplete(delegate () {
            Camera.main.transform.localPosition = new Vector3(0,0, Camera.main.transform.localPosition.z);
        });

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.T))
        {
            MotionCameraShaking();

        }


    }
}
