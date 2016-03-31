using UnityEngine;
using System.Collections;

public class Fight : MonoBehaviour {
	public int HP;
	public int Enemies;

	// Use this for initialization
	void Start () {
		HP = 3;
		//Enemies = game.getEnemies ();
	}
	
	// Update is called once per frame
	void Update () {
		//Enemies = game.getEnemies ();
		//&& game.getTime==0.0f
		/*if(game.getTime()<=0.0f){
			HP--;
		}*/
		if (Enemies == 0) {

		}
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Enemy") {
			Enemies--;
		}
	}
}
