
using UnityEngine;
using System.Collections;

public class eggController : MonoBehaviour {



	public float speed = 2;
	public float turnSpeed = 1;
	public float yawAmount = 25;  

	private Rigidbody rb;	
	void Start () {
		rb = GetComponent<Rigidbody> (); 
	}



	void FixedUpdate () {		

		float turnAmount = Input.GetAxis("Horizontal") * turnSpeed;  
		float yaw = Input.GetAxis ("Horizontal") * -yawAmount;  


		Vector3 rotationAmount = new Vector3 ( transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + turnAmount, yaw);

		transform.rotation = Quaternion.Euler (rotationAmount);		

		rb.velocity = transform.forward * turnSpeed;	
	}
}

