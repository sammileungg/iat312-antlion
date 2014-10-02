///displays the score after the game is over in gameover scene (to be dragged onto camera)
///source: http://unity3d.com/learn/tutorials/modules/beginner/live-training-archive/infinite-runner
///at 1:00:56

using UnityEngine;
using System.Collections;

public class ScoreGameOverScript : MonoBehaviour {

	int score = 0;

	///get previously saved score
	void Start () {
		score = PlayerPrefs.GetInt("Score");
	}

	void OnGui ()
	{
		/// not perfectly centered
		GUI.Label(new Rect(Screen.width / 2 - 40, 50, 80, 30), "GAME OVER");
		GUI.Label(new Rect(Screen.width / 2 - 40, 300, 80, 30), "Score: " + score);

		/// retry button
		if(GUI.Button(new Rect(Screen.width / 2 - 30, 350, 60, 30), "Retry?"))
		{
			/// loads game level again
			Application.LoadLevel(1);
		}
	}
}