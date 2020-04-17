using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectabaleMove : MonoBehaviour
{
    // VARIABLES
    public Transform pos1, pos2;
    public float speed;
    public Transform startPos;

    Vector3 nextPos;
    // Start is called before the first frame update
    void Start()
    {
        // SET START POS
        nextPos = startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        // if else to move the GameObject from pos1 to pos2
        if (transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }

        if(transform.position == pos2.position)
        {
            nextPos = pos1.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        // draw line which will determine direction of start and end positions
        Gizmos.DrawLine(pos1.position, pos2.position);        
    }

    // References :
    // Alexander Zotov - Youtube (Coin Counter)
}
