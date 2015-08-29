using UnityEngine;
using System.Collections;

public class SpeedPowerup : MonoBehaviour, IPowerup {

	public float duration = 10f;
	public float boost = 3f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public IEnumerator ApplyPowerup(Player playerScript) {

		float startTime = Time.time;
		playerScript.playerMovement.speed += boost;
		Debug.Log ("speed = " + playerScript.playerMovement.speed);

		while (Time.time < startTime + duration) {
			yield return null;
		}

		playerScript.playerMovement.speed -= boost;
		Debug.Log ("speed = " + playerScript.playerMovement.speed);

		yield return new WaitForSeconds(0f);
	}

}
