using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHeightModulator : MonoBehaviour
{
    public GameObject cam;
    
    public void GoUp()
    {
        Vector3 temp = cam.transform.position;
        temp.y = .3f;
        cam.transform.position = temp;
    }
}
//cam.transform.position = new Vector3(0, .3f, 0);
//Debug.Log("Up");