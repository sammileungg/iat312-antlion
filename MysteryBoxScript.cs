///general script for mystery boxes, to be altered for each different power up/power down
///source: http://unity3d.com/learn/tutorials/modules/beginner/live-training-archive/infinite-runner
///at 50:22

using UnityEngine;
using System.Collections;

public class MysteryBoxScript : MonoBehaviour {

	///declare anything that can be affected, ie: player (for y-position), antlion (for size), etc etc

	void OnTriggerEnter2D(Collider2D other)
	{
		/// if player is the one that touches the mystery box
		if(other.tag == "Player")
		{
			///do something

			///destroy mysterybox
			Destroy (this.gameObject);
		}
	}

}