using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    
    public float vLookSensitivity = 300f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

        

        // Update is called once per frame
    void Update()
    {
        var vLookInput = vLookSensitivity * Input.GetAxis("Mouse Y") * Time.deltaTime;
        var point = transform.parent.position;
        var axis = transform.parent.right;
        
        transform.RotateAround( point, axis, vLookInput);
    }
}
