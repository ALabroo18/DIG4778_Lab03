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

        var length = Time.deltaTime * 0.50f;
        var vect1 = new Vector3(0, 1, 5);
        var vect2 = new Vector3(0, 2, 1);
        var lerpVect = Vector3.Lerp(vect1, vect2, length);
        var moveTowards = Vector3.MoveTowards(vect2 - vect1, lerpVect, length);
        Debug.Log(lerpVect);
        circleObj01.transform.position = vect1;
        circleObj02.transform.position = vect2;
        circleLerp.transform.position = lerpVect;

        Input.GetAxis()

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    void Location()
    {
        
    }
}
