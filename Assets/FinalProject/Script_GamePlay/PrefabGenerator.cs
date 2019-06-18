using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public int MinRandomCount = 3;
    public int MaxRandomCount = 10;

    public int nRandomPos_X_Min=-10;
    public int nRandomPos_X_Max=10;

    public int nRandomPos_Y_Min=-10;
    public int nRandomPos_Y_Max=10;


    public GameObject PrefabToGenerate;


    // Start is called before the first frame update
    void Start()
    {

        int nRandomCount = Random.Range( MinRandomCount, MaxRandomCount);
        for (int i = 0; i < nRandomCount; i++){
            int nRandPositionX = Random.Range(nRandomPos_X_Min, nRandomPos_X_Max) ;
            int nRandPositionY = Random.Range(nRandomPos_Y_Min, nRandomPos_Y_Max);


            GameObject obj = Instantiate( PrefabToGenerate );
            obj.SetActive(true);

            obj.name = "SpawnObj_" + i;
            obj.transform.position = new Vector3(nRandPositionX, nRandPositionY, 0);

            obj.transform.parent = this.transform;


        }


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
