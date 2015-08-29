using UnityEngine;
using System.Collections;

public class DamagePowerup : MonoBehaviour, IPowerup {

	public float duration = 10f;
	public float boost = 0.01f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public IEnumerator ApplyPowerup(Player playerScript) {

		float startTime = Time.time;
		playerScript.playerShooting.timeBetweenBullets -= boost;
		Debug.Log ("timeBetweenBullets = " + playerScript.playerShooting.timeBetweenBullets);
		
		while (Time.time < startTime + duration) {
			yield return null;
		}

		playerScript.playerShooting.timeBetweenBullets += boost;
		Debug.Log ("timeBetweenBullets = " + playerScript.playerShooting.timeBetweenBullets);
		yield return new WaitForSeconds(0f);
	}

}
