using UnityEngine;
using System.Collections;

public class CurrencyPickUp : MonoBehaviour {

    [SerializeField]
    GameObject Coin;

    public float AddScore = 1f;

	void Start ()
    {
	    
	}
	
	void OnTriggerEnter (Collider other)
    {
	    if(other)
        {
            Destroy(other.gameObject);
            Debug.Log("Working?");
           // AddScore();
        }
	}
}
