using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

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

        //Determines how fast the enemy will try to move close to player if they are within the same distance
        float step = 0.5f * Time.deltaTime;
        if (dist < 3)
        {
            transform.RotateAround(radius.position, Vector3.forward, 30 * Time.deltaTime);
            transform.position = Vector3.MoveTowards(transform.position, player.position, step);
        }
        else
        {
            transform.RotateAround(radius.position, Vector3.forward, 100 * Time.deltaTime);
            transform.position = Vector3.MoveTowards(transform.position, player.position, step);

        }



    }
}
