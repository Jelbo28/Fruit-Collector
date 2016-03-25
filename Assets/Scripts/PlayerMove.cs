using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour 
{
	// Basic stuff
	[SerializeField]
	float speed = 4f;

	Vector3 movement;
	Rigidbody playerRigidbody;
	int floorMask;
	float camRayLength = 100f;


	void awake ()
	{
		floorMask = LayerMask.GetMask ("Floor");
		playerRigidbody = GetComponent <Rigidbody> ();
	}
	

	void FixedUpdate ()
	{
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		Move (h, v);
		Turning ();
	}
	void Move (float h, float v)
	{
		movement.Set (h, 0f, v);
		movement = movement.normalized * speed * Time.deltaTime;
        gameObject.GetComponent<Rigidbody>().MovePosition (transform.position + movement);
	}
	void Turning ()
	{
		Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit floorHit;
		if (Physics.Raycast (camRay, out floorHit, camRayLength, floorMask))
		{
			Vector3 playerToMouse = floorHit.point - transform.position;
			playerToMouse.y = 0f;
			Quaternion newRotation = Quaternion.LookRotation (playerToMouse);
            gameObject.GetComponent<Rigidbody>().MoveRotation (newRotation);
		}
	}
}