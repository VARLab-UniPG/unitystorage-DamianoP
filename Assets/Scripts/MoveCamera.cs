using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // questo script gestisce il movimento della telecamera in modo tale da seguire la pallina
    public GameObject ball;
    private Vector3 distance;
    void Start(){
        distance = transform.position - ball.transform.position;
    }
    // Update is called once per frame
    void Update(){
        transform.position = distance + ball.transform.position;
    }
}
