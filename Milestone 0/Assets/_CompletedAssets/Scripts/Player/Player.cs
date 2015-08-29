using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public CompleteProject.PlayerHealth playerHealth;
	public CompleteProject.PlayerMovement playerMovement;
	public CompleteProject.PlayerShooting playerShooting;

	// Use this for initialization
	void Start () {
		this.playerHealth = this.GetComponentInChildren<CompleteProject.PlayerHealth>() as CompleteProject.PlayerHealth;
		this.playerMovement = this.GetComponentInChildren<CompleteProject.PlayerMovement>() as CompleteProject.PlayerMovement;
		this.playerShooting = this.GetComponentInChildren<CompleteProject.PlayerShooting>() as CompleteProject.PlayerShooting;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter(Collider collider)
	{
		if (collider.tag == "Power-up")
		{
			Debug.Log("power-up collected");
			IPowerup powerup = collider.gameObject.GetComponentInChildren<IPowerup>() as IPowerup;
			StartCoroutine(powerup.ApplyPowerup(this));
			Destroy(collider.gameObject);
		}
	}
}
