using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour
{
	void OnTriggerEnter (Collider other)
    {
	    if(other.tag == "Player")
        {
            //Debug.Log("Working?");
            GM.instance.UpdateScore();
            Destroy(gameObject);
        }
	}
}
