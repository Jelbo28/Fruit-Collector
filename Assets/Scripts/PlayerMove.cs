﻿using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour 
{
    #region Variables
    [SerializeField]
	float speed = 4f;

	Vector3 movement;
    #endregion
	
	void FixedUpdate ()
	{
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		Move (h, v);
	}

	void Move (float h, float v)
	{
		movement.Set (h, 0f, v);
		movement = movement.normalized * speed * Time.deltaTime;
        gameObject.GetComponent<Rigidbody>().MovePosition(transform.position + movement);
    }
}