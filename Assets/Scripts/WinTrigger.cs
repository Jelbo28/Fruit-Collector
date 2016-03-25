using UnityEngine;
using System.Collections;

public class WinTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        GM.Instance.Win();
    }
}
