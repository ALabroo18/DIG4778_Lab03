using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Vector : MonoBehaviour
{
    public GameObject circleObj01;
    public GameObject circleObj02;
    public GameObject circleLerp; 
    // Start is called before the first frame update
    void Start()
    {
        //Magnitude: The length of the vector
        //
        var length = Time.deltaTime * 0.50f;
        var vect1 = new Vector3(0, 1, 5);
        var vect2 = new Vector3(0, 2, 1);


        //Adding vectors
        var vect3 = vect1 + vect2; //(0+0, 1+2, 5+1)

        //The same formula applies to addition, multiplication, and division

        //Using this is useful to apply to finding the distance between two points 

        //Goes inbetween the other points
        var lerpVect = Vector3.Lerp(vect1, vect2, length);

        //Move towards the interpolated value (???)
        var moveTowards = Vector3.MoveTowards(vect2 - vect1, lerpVect, length);
        Debug.Log(lerpVect);
        circleObj01.transform.position = vect1;
        circleObj02.transform.position = vect2;
        circleLerp.transform.position = lerpVect;
       

        
        

        

    }

    // Update is called once per frame
    void Update()
    {
        //Reflects off of the opposite of the original object
        //Parameter 1: The original position
        //Parameter 2: the new reflected position
        var reflect = Vector3.Reflect(circleObj01.transform.position, Vector3.right);


    }
    void Location()
    {
        
    }
}
