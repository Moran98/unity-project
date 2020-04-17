using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // variables
    public float speed = 1.0f;
    public Vector3 moveVector;
    // Update is called once per frame
    void Update()
    {
        // gameobjects for collectables will rotate
        transform.Rotate(new Vector3(0,0,45)*Time.deltaTime);
    }
}
