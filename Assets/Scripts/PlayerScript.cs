using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public int moveSpeed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.position += new Vector3 (moveSpeed, 0, 0) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (0, 0, 0);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.position += new Vector3 (0, 0, moveSpeed) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (0, -90, 0);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.position += new Vector3 (-moveSpeed, 0, 0) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (0, 180, 0);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.position += new Vector3 (0, 0, -moveSpeed) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (0, 90, 0);
		}
		Camera.main.transform.position = transform.position + new Vector3 (-6, 4, 0);

	}
}
