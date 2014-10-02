///player input movement left and right, continuous movement up
///sources: http://unity3d.com/learn/tutorials/modules/beginner/live-training-archive/infinite-runner
///at time 16:43
///and in-lab playermovement code

using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	void Update () {
		Movement();
	}

	void Movement()
	{
	if(Input.GetKey (KeyCode.RightArrow))
		{
			transform.Translate(Vector2.right * 4f * Time.deltaTime);
		}
	
		if(Input.GetKey (KeyCode.LeftArrow))
		{
			transform.Translate(Vector2.left * 4f * Time.deltaTime);
		}
	}

	void FixedUpdate()
	{
		transform.Translate(Vector2.up * 4f * Time.deltaTime);
	}
}

