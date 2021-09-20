using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HolesScript : MonoBehaviour
{

    public GameObject table;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Balls"))
        {
            other.gameObject.SetActive(false);
            table.GetComponent<GameManager>().Counter();

        }
    }
}
