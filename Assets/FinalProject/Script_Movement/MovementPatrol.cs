using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class MovementPatrol : MonoBehaviour
{


    [Header("Movement")]
    public float Duration = 5f;
    public float directionChangeInterval = 3f;

    [Header("Orientation")]
    public bool orientToDirection = false;
    public Enums.Directions lookAxis = Enums.Directions.Up;


    [Header("Stops")]
    public Vector2[] waypoints;

    public Ease MoveMode;

    private Vector2[] newWaypoints;
    private int currentTargetIndex;
    private Sequence s;

    // Start is called before the first frame update
    IEnumerator Start()
    {
    

        currentTargetIndex = 0;

        newWaypoints = new Vector2[waypoints.Length + 1];
        int w = 0;
        for (int i = 0; i < waypoints.Length; i++)
        {
            newWaypoints[i] =  new Vector2( transform.position.x + waypoints[i].x , transform.position.y + waypoints[i].y)   ;
            w = i;
        }

        //Add the starting position at the end, only if there is at least another point in the queue - otherwise it's on index 0
        int v = (newWaypoints.Length > 1) ? w + 1 : 0;
        newWaypoints[v] = transform.position;
        waypoints = newWaypoints;

        if (orientToDirection)
        {
            Utils.SetAxisTowards(lookAxis, transform, ((Vector3)newWaypoints[1] - transform.position).normalized);
        }

        // Start after one second delay (to ignore Unity hiccups when activating Play mode in Editor)
        yield return new WaitForSeconds(1);

         s = DOTween.Sequence();

        for (int i = 0; i < waypoints.Length; i++) {

            //if(i==0)
            s.Append(transform.DOMove(newWaypoints[i], Duration).SetEase( Ease.Linear ) );
        }

        s.SetLoops(-1, LoopType.Yoyo);

    }

    public void OnDestroy()
    {
        // Kill the DoTween Animation before Destroy
        Debug.Log("OnDestroy:" + gameObject.name);
        s.Kill();
    }



}
