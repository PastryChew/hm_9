using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupermanScript : MonoBehaviour
{
    Vector3 target;
    public float speed;
    public float power;
    public GameObject point;
    Vector3 punchDirection;


    // Start is called before the first frame update
    void Start()
    {
        target = point.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        punchDirection = collision.transform.position - transform.position;
        
        if (collision.gameObject.GetComponent<Rigidbody>())
        {
            collision.rigidbody.AddForce(punchDirection * power, ForceMode.Impulse);
            Debug.Log("checked");
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        
    }
}
