using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    
    void Start()
    {
        offset = transform.position - player.transform.position;
    }
    
    // UPDATE METHOD RUNS ON EVERY FRAME
    // LATE UPDATE RUNS AFTER EVERY UPDATE RUNS
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
    
    
}
