using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeAction : MonoBehaviour
{
    // 宣告一個變數來記錄飛碟的狀態
    bool bChangeSize = false;

    //宣告一個方法來進行飛碟的行為處理
    void ChangeSizeAndColor(bool bChange)
    {
        // 宣告一個GameObject 變數來取得飛碟的控制權
        Transform trans = gameObject.GetComponent<Transform>();
        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        if (trans == null || spriteRenderer == null) {
            Debug.LogError("please assign an gamebject with Transform and SpriteRenderer");
            return;
        }
        // 狀態判斷 
        if (bChange){
            //大小控制
                trans.localScale = new Vector3(2, 2, 1);
            //顏色控制
                spriteRenderer.color = Color.red;
        }
        else{
                trans.localScale = new Vector3(1, 1, 1);
                spriteRenderer.color = Color.white;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // To Process the Button press behavior
        if (Input.GetKeyDown(KeyCode.Return))
        {
            bChangeSize = !bChangeSize;
            // 呼叫自己宣告的方法
            ChangeSizeAndColor(bChangeSize);
        }
    }
}
