using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyScript : MonoBehaviour
{
    /*public Transform target;*/
    public Transform radius;
    public Transform player;
    // Use this for initialization
    void Start()
    {
       
        // new Vector3(combinedRotation.x, combinedRotation.y, combinedRotation.z);



    }

    
    void Update()
    {
        //Uses distance to determine whether or not the enemy is close to the player
        var dist = Vector3.Distance(player.position, transform.position);

        var minDistance = 1;
        var maxDistance = 10;

        //Determines how fast the enemy will try to move close to player if they are within the same distance
        float step = 0.5f * Time.deltaTime;
        Vector3 Direction = (player.position - transform.position ).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(Vector3.forward, Direction);

        if (dist > 10)
        {
            transform.RotateAround(radius.position, Vector3.forward, 100 * Time.deltaTime);
           
            Debug.Log("More than 10");

        }
        else if (dist <= 10 && dist > 5)
        {
            transform.RotateAround(radius.position, Vector3.forward, 70 * Time.deltaTime);
            transform.position = Vector3.MoveTowards(transform.position, player.position, step);

            Debug.Log("10");
        }
        else if(dist <= 5 && dist > 1)
        {
            transform.RotateAround(radius.position, Vector3.forward, 40 * Time.deltaTime);
            transform.position = Vector3.MoveTowards(transform.position, player.position, step);
            Debug.Log("5");
        }
        else if(dist <= 1)
        {
            transform.RotateAround(radius.position, Vector3.forward, 30 * Time.deltaTime);
            
            Debug.Log("1");
        }
        transform.position = Vector3.MoveTowards(transform.position, player.position, step);



    }
}
