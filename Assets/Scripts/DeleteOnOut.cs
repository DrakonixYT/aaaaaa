using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnOut : MonoBehaviour
{
    public GameObject pablo;
    private void OnTriggerExit(Collider other)
    {
        pablo.SetActive(false);
    }
}
