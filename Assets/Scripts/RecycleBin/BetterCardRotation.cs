using UnityEngine;
using System.Collections;

/// <summary>
/// This script should be attached to the card game object to display card`s rotation correctly.
/// </summary>

[ExecuteInEditMode]
public class BetterCardRotation : MonoBehaviour {

    // parent game object for all the card face graphics
    public RectTransform CardFront;

    // parent game object for all the card back graphics
    public RectTransform CardBack;

    public Transform Myself;

    /*private float timeElapsed = 0;

    private bool startBlocker = false;*/

	// Update is called once per frame
	void Update () 
    {
        /*if (startBlocker && timeElapsed % 6 == 0)
        {
            CardFront.gameObject.SetActive(!CardFront.gameObject.activeSelf);
            CardBack.gameObject.SetActive(!CardBack.gameObject.activeSelf);
        }else if (!startBlocker)
        {
            startBlocker = true;
        }

        timeElapsed++;*/
        

        if (Myself.rotation.y == 1)
        {
            //Myself.rotation = new Quaternion(x: 0, y: 0, z: 0, w: 0);
            /*CardFront.gameObject.SetActive(false);
            CardFront.gameObject.transform.rotation = new Quaternion(x:0,y:0,z:0,w:0);
            CardBack.gameObject.SetActive(true);*/
        }
        else if (Myself.rotation.y < 0.7071068)
        {
            /*CardFront.gameObject.SetActive(true);
            CardBack.gameObject.SetActive(false);*/
        }

    }
}
