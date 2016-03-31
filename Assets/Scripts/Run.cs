using UnityEngine;
using System.Collections;

public class Run : MonoBehaviour {

	private Vector3 mousePosition;
	public float moveSpeed = 1f;
	//int state=0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			mousePosition = Input.mousePosition;
			mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
			transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
			//state = 1;
		}

	}
}