using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeScript : MonoBehaviour
{
	public int sceneNum;
	
	// Sent when another object enters a trigger collider attached to this object (2D physics only).
	protected void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Player"))
		{
			SceneManager.LoadScene(sceneNum);
		}
	}
	
}
