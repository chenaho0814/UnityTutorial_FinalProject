using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Follow : MonoBehaviour
{
	public Transform target; // Target to follow
	Vector3 targetLastPos;
	Tweener tween;

    public int movement = 3;

	void Start()
	{
        if (!target) {
            Debug.LogError("Please Assign Target GameObject");
            return;
        }

        // First create the "move to target" tween and store it as a Tweener.
        // In this case I'm also setting autoKill to FALSE so the tween can go on forever
        // (otherwise it will stop executing if it reaches the target)
        tween = transform.DOMove(target.position, movement).SetAutoKill(false);
		// Store the target's last position, so it can be used to know if it changes
		// (to prevent changing the tween if nothing actually changes)
		targetLastPos = target.position;
	}

	void Update()
	{

        if (!target) return;
		// Use an Update routine to change the tween's endValue each frame
		// so that it updates to the target's position if that changed
		if (targetLastPos == target.position) return;
		// Add a Restart in the end, so that if the tween was completed it will play again
		tween.ChangeEndValue(target.position, true).Restart();
		targetLastPos = target.position;
	}
}