///keeps track of player score (drag onto main camera)
///source http://unity3d.com/learn/tutorials/modules/beginner/live-training-archive/infinite-runner
/// at 42:00

using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {

	float playerScore = 0;

	/// add time to player score, longer time they stay alive, higher score they get
	void Update () {
		playerScore += Time.deltaTime;
	}

	/// draw the score
	void OnGUI()
	{
		/// rectangle on upper left corner at 10px, 10px (position), 100 wide, 30 tall
		/// offset using percentage: can use screen.Height or screen.Width
		GUI.Label(new Rect(10, 10, 100, 30), "Score: " + (int)(playerScore * 100));
	}
}