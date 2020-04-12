using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 1.0f;
    public Vector3 moveVector;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,0,45)*Time.deltaTime);
    }
}
