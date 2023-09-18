using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    public void openURL()
    {
        Debug.Log("Semmi");
        Application.OpenURL("https://beholder.hu/?m=hkk&in=hkk.php&kartya=7062");
    }
}
 