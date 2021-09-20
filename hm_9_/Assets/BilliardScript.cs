using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilliardScript : MonoBehaviour
{

    public float power;



    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(-power, 0,0, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    


}
