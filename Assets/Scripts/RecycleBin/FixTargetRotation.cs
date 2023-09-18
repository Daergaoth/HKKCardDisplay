using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixTargetRotation : MonoBehaviour
{

    public Transform imageTarget;
    public Transform obj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //AlignObject();
        //obj.position = imageTarget.position;
        //obj.rotation = imageTarget.rotation;
    }

    public void AlignObject()
    {
        obj.position = imageTarget.position;

        // Get your targets right vector in world space
        var right = imageTarget.right;

        // If not anyway the case ensure that your objects up vector equals the world up vector
        obj.up = Vector3.up;

        // Align your objects right vector with the image target's right vector
        // projected down onto the global XZ plane => erasing its Y component
        obj.right = Vector3.ProjectOnPlane(right, Vector3.up);
    }
}
