using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarDisplay : MonoBehaviour
{
    [SerializeField] private Image HPBarImg;
    [SerializeField] private Text  HPBarText;

    private int Min = 0;
    private int nCurrentValue = 0;
    private float fCurrentPersent = 0f;

    public int Max = 100;


    public void SetHealth( int nHealth , int HealthMax ) {

        Max = HealthMax;

        if (nHealth != nCurrentValue) { 
            if( Max - Min == 0) {
                nCurrentValue = 0;
                fCurrentPersent = 0; 
            } else {
                nCurrentValue = nHealth;

                fCurrentPersent = (float)nCurrentValue / (float)(Max - Min);

                HPBarText.text = string.Format("{0} %", Mathf.RoundToInt(fCurrentPersent * 100));
                HPBarImg.fillAmount = fCurrentPersent; // transfer to 0~1 ;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        SetHealth(Max, Max);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
