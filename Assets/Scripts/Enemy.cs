using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public int HP;
	Animator animator;

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Player") {
			getHit ();
			if (getHP() == 0) {
				Destroy (this.gameObject);
			}
		}
	}

	public void setHP(int n){
		HP = n;
		animator = GetComponent<Animator> ();
	}

	public int getHP(){
		return HP;
	}

	public void getHit(){
		HP--;
		animator.SetInteger ("HP", HP);
	}
}
