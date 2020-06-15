using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
    
{
    GameObject follow;
     public float smoothTime;
    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        follow = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update() { 
  
        transform.position = new Vector3(
follow.transform.position.x, follow.transform.position.y + 5, follow.transform.position.z - 15);
}
}
