using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	private int HP;

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Player") {
			getHit ();
			if (getHP() == 0) {
				Destroy (this.gameObject);
			}
		}
	}

	public int getHP(){
		return HP;
	}

	public void getHit(){
		HP--;
	}

	public void setHP(int n){
		HP = n;
	}
}
