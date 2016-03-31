using UnityEngine;
using System.Collections;

public class game : MonoBehaviour {
	private float currentTime;
	private int round;
	private int enemiesSpawned;
	private const float time=10f;
	// Use this for initialization
	void Start () {
		enemiesSpawned = (int)Random.Range(1,3);
		currentTime = time;
		round = 0;
	}
	
	// Update is called once per frame
	void Update () {
		currentTime -= Time.deltaTime;
		if(time==0 || enemiesSpawned==0){
			currentTime = time;
			enemiesSpawned = (int)Random.Range(1,3);
			round++;
		}
	}

	public float getTime(){
		return currentTime;
	}

	public int getEnemies(){
		return enemiesSpawned;
	}
}
