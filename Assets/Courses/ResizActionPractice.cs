using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizActionPractice : MonoBehaviour
{
    public bool bChangeSize = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }



    void ChangeSizeAndColor( bool bChange  ) {
        Transform trans = gameObject.GetComponent<Transform>();
        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        if (bChange) {
            trans.localScale = new Vector3(2, 2, 1);
            spriteRenderer.color = Color.red;

        } else {

            trans.localScale = new Vector3(1, 1, 1);
            spriteRenderer.color = Color.white;

        }



    }



    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return)) {
            bChangeSize = !bChangeSize;

            ChangeSizeAndColor(bChangeSize); 
        }


    }
}
