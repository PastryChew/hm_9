using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explscr : MonoBehaviour
{

    public int power;
    public Rigidbody[] gameObjects;
    public float TimeToExplosion;
    public float radius;
    public float distance;

   
    void Update()
    {
        TimeToExplosion -= Time.deltaTime;
        if (TimeToExplosion <=0)
        {
            Explosion();
        }
    }
    public void Explosion()
    {

        foreach (Rigidbody item in gameObjects)
        {
            distance = Vector3.Distance(transform.position, item.transform.position);
            if (distance < radius)
            {
                Vector3 direction = item.transform.position - transform.position;

                item.AddForce(direction.normalized * power * (radius - distance), ForceMode.Impulse);
            }
        }

        TimeToExplosion = 3;
    }
}
