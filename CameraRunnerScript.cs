/// camera follows player movement

/// source: http://unity3d.com/learn/tutorials/modules/beginner/live-training-archive/infinite-runner
/// at 25:00

using UnityEngine;
using System.Collections;

public class CameraRunnerScript : MonoBehaviour {
	
	public Transform player;

	void Update ()
	{
		transform.position = new Vector3(player.position.y + 0, 0, -10);
		/// the second 0 can be altered according to the camera's original displacement with the player's original y position)
	}
}