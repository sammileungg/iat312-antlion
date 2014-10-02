///switch to gameover scene when colliding with antlion, dragged onto antlion in game
///source: http://unity3d.com/learn/tutorials/modules/beginner/live-training-archive/infinite-runner
/// at 56:30

using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Player")
		{
			///the 2 indicates the scene number on building menu, change accordingly to scene number
			Application.LoadLevel(2)
			return;
		}
	}
}