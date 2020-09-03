using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class MoverScript : MonoBehaviour
{
    public float speed = 3f;
    public float lookSensitivity = 300f;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log( message: "Hello World!");
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        

        var vInput = speed * Input.GetAxis("Vertical") * Time.deltaTime;
        var hInput = lookSensitivity * Input.GetAxis("Horizontal") * Time.deltaTime;
        var movement = new Vector3(0,0, vInput);
        
        
        var hLookInput = lookSensitivity * Input.GetAxis("Mouse X") * Time.deltaTime;
        
        var lookDelta = new Vector3(0, hLookInput,0);
        
        transform.Rotate(lookDelta);
        transform.Translate(movement);
    }

    public void Up()
    {
        transform.Translate(0, speed, 0);
    }
}
