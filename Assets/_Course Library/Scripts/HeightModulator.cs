using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightModulator : MonoBehaviour
{
    public GameObject cam;
    
    public void GoUp()
    {
        cam.transform.position = new Vector3 (0, 0, 1.0f);
        Debug.Log("Up");
    }
}
