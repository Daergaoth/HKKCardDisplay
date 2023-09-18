using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteInEditMode]
public class Rotate : MonoBehaviour
{
    public Vector3 vect;
    // Start is called before the first frame update
    //private float yValue = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(vect * Time.deltaTime);

        if (transform.rotation.y >= 0.7071068 || transform.rotation.y <= -0.7071068)
        {
            transform.Rotate(vect * (180 / vect.y));
        }
    }
}
