using UnityEngine;
using System.Collections;

public class HealthPowerup : MonoBehaviour, IPowerup {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public IEnumerator ApplyPowerup(Player playerScript) {
		playerScript.playerHealth.currentHealth = playerScript.playerHealth.startingHealth;
		playerScript.playerHealth.healthSlider.value = playerScript.playerHealth.startingHealth;
		Debug.Log ("currentHealth = " + playerScript.playerHealth.currentHealth);
		yield return new WaitForSeconds(0f);
	}

}
