using UnityEngine;
using System.Collections;

public class PickUpGenerator : MonoBehaviour {

    public PickUpController pickUpPrefab;

    public int MinRandomCount = 3;
    public int MaxRandomCount = 10;

    public int GoodPickUpRate = 60;

	// Use this for initialization
	void Start () {

        int nRandomCount = Random.Range( MinRandomCount, MaxRandomCount);

        for (int i = 0; i < nRandomCount; i++)
        {
            int nRandPositionX = Random.Range(-10, 10) ;
            int nRandPositionY = Random.Range(-10, 10);

			///Home work-2
			// solution-1
			if( nRandPositionX <3  && nRandPositionX >=0) nRandPositionX =  3 + Random.Range(0,7) ;
			if( nRandPositionX >-3 && nRandPositionX <=0) nRandPositionX = -3 + Random.Range(0 ,-7);

			if( nRandPositionY <3  && nRandPositionY >=0) nRandPositionY = 3 + Random.Range(0,7) ;
			if( nRandPositionY >-3 && nRandPositionY <=0) nRandPositionY = -3  + Random.Range(0 ,-7);

			// solution-2
			//			while(nRandPositionX <= 3 && nRandPositionY <= 3)
			//			{
			//					nRandPositionX = Random.Range(-10, 10);
			//				    nRandPositionY = Random.Range(-10, 10);
			//			}    

			// solution-2 version3
			//			if( Mathf.Abs( nRandPositionX ) <=3 ) nRandPositionX =  3 + Random.Range(0,7) ;
			//			if( Mathf.Abs( nRandPositionY ) <=3 ) nRandPositionY =  3 + Random.Range(0,7) ;





            PickUpController obj = GameObject.Instantiate(pickUpPrefab);

            if (Random.Range(0, 100) <= GoodPickUpRate)
                obj.initRole(PICKUP.PICUP_GOOD);
            else
                obj.initRole(PICKUP.PICUP_BAD);


          obj.name = "PickUp_" + i;
            obj.transform.position = new Vector3(nRandPositionX, nRandPositionY, 0);

            obj.transform.parent = this.transform; 
        }
        

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
