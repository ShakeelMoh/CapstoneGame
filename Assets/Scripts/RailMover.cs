using UnityEngine;
using System.Collections;

public class RailMover : MonoBehaviour {


	public RailCamera rail;
	public Transform lookAt;
	public bool smothMove = true;
	public float moveSpeed;

	private Transform thisTransform;
	private Vector3 lastPosition;
	void Start () {

		thisTransform = transform;
	}


	void Update ()
	{
		if (smothMove)
		{
			lastPosition = Vector3.Lerp(lastPosition, rail.ProjectPositionOnRail(lookAt.position), Time.deltaTime * moveSpeed);
			thisTransform.position = lastPosition;
		}
		else
		{
			thisTransform.position = rail.ProjectPositionOnRail(lookAt.position);
		}
		thisTransform.position = rail.ProjectOnSegment(Vector3.zero, Vector3.forward * 100, lookAt.position);
		thisTransform.LookAt(lookAt.position);
	}


}
