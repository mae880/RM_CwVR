using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightModulator : MonoBehaviour
{
    public GameObject cam;
    
    public void GoUp()
    {
        Vector3 temp = transform.position;
        temp.y = .3f;
        transform.position = temp;
    }
}
cam.transform.position = new Vector3(0, .3f, 0);
Debug.Log("Up");