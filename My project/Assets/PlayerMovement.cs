using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform moveDestination;

    public LayerMask stopsMovement;

    // Start is called before the first frame update
    void Start()
    {
        moveDestination.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveDestination.position, moveSpeed * Time.deltaTime);
        
        if(Vector3.Distance(transform.position, moveDestination.position) <= .05f){
            //Horizontal movement
            if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)){
                moveDestination.position += new Vector3(.5f, 0f, 0f);
            }
            if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)){
                moveDestination.position += new Vector3(-.5f, 0f, 0f);
            }
            //vertical movement
            if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)){
                moveDestination.position += new Vector3(0f, .5f, 0f);
            }
            if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)){
                moveDestination.position += new Vector3(0f, -.5f, 0f);
            }
        }
    }
}
