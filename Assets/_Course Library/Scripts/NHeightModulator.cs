using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NHeightModulator : MonoBehaviour
{
    public GameObject cam;

    public void GoDown()
    {
        Vector3 temp = cam.transform.position;
        temp.y = 0f;
        cam.transform.position = temp;
    }
}
//Debug.log("Down")