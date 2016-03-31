using UnityEngine;
using System.Collections;

public class Speed : Enemy {
	private float Movement=0.5f;
	private Vector3 initPos;
	private Vector3 endPos;
	private Vector3 lastPos;

	void Start () {
		initPos = transform.position;
		lastPos = initPos;
		endPos = new Vector3(initPos.x+1,initPos.y,initPos.z);
		setHP (1);
	}

	void Update(){
		if (transform.position.x>=endPos.x) {
			lastPos = endPos;
		} else if(transform.position.x<=initPos.x){
			lastPos = initPos;
		}
		if(transform.position.x>=initPos.x && lastPos.x==initPos.x){
			moveTo (endPos);
		}else if(transform.position.x<=endPos.x && lastPos.x==endPos.x){
			moveTo (initPos);
		}
	}

	void moveTo(Vector3 end){
		float step = Movement * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position,end,step);
	}
}

