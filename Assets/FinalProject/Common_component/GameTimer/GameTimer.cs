using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [SerializeField] private Text UItext;
    [SerializeField] private float mainTimer;

    private float timer;
    public bool canCount = false;
    public bool doOnce = false;

    /// <summary>
    /// Its for time counting purpose 
    /// </summary>
    public bool CounterMode = false;


    // Start is called before the first frame update
    void Start()
    {
        timer = mainTimer;

        if (CounterMode) {
            timer = 0;
            UItext.text = "0";
         }else {
            UItext.text = timer.ToString();
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        if (!CounterMode) {
            if (timer >= 0.0f && canCount)
            {
                timer -= Time.deltaTime;
                UItext.text = timer.ToString("F");
            }
            else if (timer <= 0.0f && !doOnce)
            {

                // finish 
                canCount = false;
                doOnce = true;

                UItext.text = "0.00";
                timer = 0.0f;
            }
        } else {

            if (canCount) {
                timer += Time.deltaTime;
                UItext.text = timer.ToString("F");

            }

        }

    }


    public void CountStart() {
        Debug.Log("CountStart");
        canCount = true;

    }

    public void CountStop()
    {
        Debug.Log("CountStop");
        canCount = false;

    }


    public void CountReset() {

        timer = mainTimer;
    }

}
