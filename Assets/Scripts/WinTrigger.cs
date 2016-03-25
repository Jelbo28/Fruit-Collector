using UnityEngine;
using System.Collections;

public class WinTrigger : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            GM.instance.Win();
        }
    }
}
