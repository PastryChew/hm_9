﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitationScr : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Rigidbody>().useGravity = false;
    }
    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Rigidbody>().useGravity = true;
    }
}
