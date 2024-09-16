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

        //Determines how fast the enemy will try to move close to player if they are within the same distance
        float step = 0.5f * Time.deltaTime;
        Vector3 Direction = (player.position - transform.position ).normalized;
       /* Quaternion lookRotation = Quaternion.LookRotation(Vector3.forward, directionToPlayer);
*/

        if (dist <= 10)
        {
            transform.RotateAround(player.position, Vector3.forward, 40 * Time.deltaTime);
            /* transform.position = Vector3.MoveTowards(transform.position, player.position, step);*/
        }
        else if(dist <= 5)
        {
            transform.RotateAround(player.position, Vector3.forward, 30 * Time.deltaTime);
        }
        else if(dist <= 1)
        {
            transform.RotateAround(player.position, Vector3.forward, 10 * Time.deltaTime);
        }
        else
        {
            transform.RotateAround(radius.position, Vector3.forward, 100 * Time.deltaTime);
            /*transform.position = Vector3.MoveTowards(transform.position, player.position, step);*/

        }



    }
}
/*using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform radius; // The center of the circle/orbit
    public Transform player; // The player the enemy orbits
    public float baseSpeed = 2.0f; // The base movement speed for the enemy
    public float orbitDistance = 3f; // The distance at which the enemy orbits the player

    void Update()
    {
        // Calculate the distance between the enemy and the player
        float distanceToPlayer = Vector3.Distance(player.position, transform.position);

        // Adjust speed based on the distance to the player (farther = faster)
        float speed = baseSpeed * distanceToPlayer * Time.deltaTime;

        // Orbit around the player (using the player's position as the center)
        transform.RotateAround(player.position, Vector3.forward, speed);

        // Ensure the enemy always faces the player
        Vector3 directionToPlayer = (player.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(Vector3.forward, directionToPlayer);
        transform.rotation = lookRotation;

        // Adjust the enemy's position to maintain the orbit distance
        Vector3 orbitPosition = (transform.position - player.position).normalized * orbitDistance + player.position;
        transform.position = orbitPosition;
    }
}*/
