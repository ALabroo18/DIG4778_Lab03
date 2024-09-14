using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    /*public Transform target;*/
    public  Transform gameObject;
    /*public bool once = true;*/
    // Use this for initialization
    void Start()
    {
       
        // new Vector3(combinedRotation.x, combinedRotation.y, combinedRotation.z);



    }

    
    void Update()
    {
        transform.RotateAround(gameObject.position, Vector3.forward, 30 * Time.deltaTime);
        var dist = Vector3.Distance(gameObject.position, transform.position);
        if(dist < 3)
        {
            float step = 2 * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, gameObject.position, step);
        }
        


    }
}
