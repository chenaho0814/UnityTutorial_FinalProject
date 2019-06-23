using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMaskController : MonoBehaviour
{

    public SpriteRenderer m_TargetSpriteToCover;
    public SpriteMask m_spriteMaskPrefab; 
    public int nSizeOfMaskGrid; // n 


    public int nSizeOfMaskUnit; // 0~n , 0 means disable , n is useless 
    public int nPositionOfMaskUnit; // 0~ (nxn-1)

    private Vector3 mMaskStartPosition;
    private Vector3 mMaskStartSize;

    public float fBlockMoveUnit = 1;


    // Start is called before the first frame update
    void Start()
    {
        mMaskStartPosition = m_spriteMaskPrefab.transform.parent.localPosition;
        mMaskStartSize = m_spriteMaskPrefab.transform.parent.transform.localScale;

    }


    public void ApplyChange() {

        /// start position


        // default size 




        /// Start to apply 
        m_spriteMaskPrefab.transform.parent.transform.localScale = mMaskStartSize * nSizeOfMaskUnit;

        int PosX = nPositionOfMaskUnit % nSizeOfMaskGrid; //(0  ~ nxn -1 )
        int PosY = nPositionOfMaskUnit / nSizeOfMaskGrid;

        Debug.Log(PosX + "," + PosY);
        Debug.Log(mMaskStartPosition.x + "," + mMaskStartPosition.y);




        // mMaskSize
        m_spriteMaskPrefab.transform.parent.localPosition = new Vector3(
            mMaskStartPosition.x + (PosX * fBlockMoveUnit),
            mMaskStartPosition.y - (PosY * fBlockMoveUnit),
            mMaskStartPosition.z
           );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
