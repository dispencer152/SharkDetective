using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {
	bool didPlayerWin = false;
	public Text display;
	public Transform player;
	public Transform goal;
	public GameObject captain;
	public Transform first;
	public Transform second;
	public Transform third;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (didPlayerWin) {
			display.text = "Uh... guess you got a little hungry..." +
			"Oh well! \nAnother case cracked by the peerless SHARK DETECTIVE!!";
		} else if ((goal.position - player.position).magnitude < 5f) {
			display.text = "You found the Captain! Press [SPACE] to put him \nin your mouth" +
			" and bring him safely home! Wait a minute....";
			if (Input.GetKey (KeyCode.Space)) {
				didPlayerWin = true;
				captain.SetActive (false);
			}
		} else if ((first.position - player.position).magnitude < 5f) {
			display.text = "Some shipping crates containing rum from the wreck!" +
			"\n You decide to follow the scent to the northeast!";
		} else if ((second.position - player.position).magnitude < 5f) {
			display.text = "Oars from the lifeboats! \nWhy would they leave these behind?" +
			" \nYou hear something to the south!";
		} else if ((third.position - player.position).magnitude < 5f) {
			display.text = "The life raft! The Captain must be close! \nYou smell blood to the west.";
		}
	}
}