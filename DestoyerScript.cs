/// script for "destroyer" block to remove environment that player has passed already
/// this script removes anything that collides with the object the script is placed on
/// source: http://unity3d.com/learn/tutorials/modules/beginner/live-training-archive/infinite-runner
/// at 29:15

using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.transform.parent)
		{
			Destroy (other.gameObject.transform.parent.gameObject);
		}
		else
		{
			Destroy (other.gameObject);
		}
	}
}