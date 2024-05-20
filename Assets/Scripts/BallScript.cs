using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour{
    private Rigidbody rb;
    public int speed = 10;
    public int jumpMult = 20;
    private bool onTerrain = false;
    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update(){
        float hMove = Input.GetAxis("Horizontal");
        float vMove = Input.GetAxis("Vertical");
        Vector3 ballMove = new Vector3(hMove, 0.0f, vMove);
        rb.AddForce(ballMove*speed);
        if (Input.GetKey(KeyCode.Space) && onTerrain==true){ // basterebbe && onTerrain, senza ==true
            Vector3 jumpVect = new Vector3(0.0f, 6.0f, 0.0f);
            onTerrain = false;
            rb.AddForce(jumpVect*jumpMult);
        }
    }
    private void OnCollisionStay(Collision collisionInfo){
        if (!collisionInfo.gameObject.CompareTag("pareteVerticale") ){
            onTerrain = true;   
        }
    }
}
