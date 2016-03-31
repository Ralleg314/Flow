using UnityEngine;
using System.Collections;

public class SpawnEnemies : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject go = (GameObject)Instantiate(Resources.Load("Normal"));
	}
}
