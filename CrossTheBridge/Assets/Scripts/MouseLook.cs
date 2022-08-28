using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{   

    public Transform tf;
    private float rawInputRotationX,rawInputRotationY;
    private float xRotation=0;
    private float mouseSensitivity=4f;    
    
    // Start is called before the first frame update
    void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {   
       // Debug.Log(rawInputRotationX);
        //transform.Rotate(rawInputRotationY*Time.deltaTime*45);
        
    }
    public void Mouse(InputAction.CallbackContext context){
        Vector2 mouseValue= context.ReadValue<Vector2>();
        rawInputRotationY=mouseValue.x*mouseSensitivity*Time.deltaTime; //new Vector3(0,,0);
        rawInputRotationX=mouseValue.y*mouseSensitivity*Time.deltaTime;//new Vector3(,0,0);
        xRotation-=rawInputRotationX;
        xRotation=Mathf.Clamp(xRotation,-90f,90f);
        
        
        transform.localRotation=Quaternion.Euler(xRotation,0f,0f);
         tf.Rotate(Vector3.up*rawInputRotationY);
        }
}
