using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public float speed = 3f;
    public float lookSensitivity = 300f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log( message: "Hello World!");
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frameS
    void Update()
    {
        

        var vInput = speed * Input.GetAxis("Vertical") * Time.deltaTime;
        var hInput = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        var movement = new Vector3(hInput,0, vInput);
        
        
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
