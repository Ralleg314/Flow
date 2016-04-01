using UnityEngine;
using System.Collections;

public class game : MonoBehaviour {
	public Transform Normal;
	public float currentTime;
	public int round;
	public int enemiesSpawned;
	public const float time=10f;
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
			for (int i=0; i < enemiesSpawned; i++) {
				spawnEnemy ("None");
			}
			round++;
		}
	}

	public float getTime(){
		return currentTime;
	}

	public int getRound(){
		return round;
	}

	public int getEnemies(){
		return enemiesSpawned;
	}

	public void enemyKilled(){
		enemiesSpawned--;
	}

	public void spawnEnemy(string type){
		Vector3 pos = new Vector3 (10, 10, 0);
		Instantiate (Normal, pos, Quaternion.identity);
	}
}
