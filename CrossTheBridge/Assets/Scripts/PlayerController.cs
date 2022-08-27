using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed =5.0f;
    public Rigidbody rb;
    private Vector3 rawInputUD,rawInputLR;

    public delegate void PlayerDelegate(int score,int health);
    public static PlayerDelegate playerDelegate;
    
    //public GameObject bullet,Target;

    private void Awake() {
        Cursor.lockState = CursorLockMode.Locked;
        //rb=GetComponent<Rigidbody>();
        /*health.setMaxHealth(maxHealth);
        presentHealth=maxHealth;*/
    }
    private void Update() {
        /*Vector3 TDir= Target.transform.position-transform.position;
        Debug.Log(TDir.magnitude);
        if(TDir.magnitude<10){
            transform.position=transform.position;
            //Shoot();
        }else{
        rb.transform.Translate(Tdir*Time.deltaTime*speed);
        }*/
        rb.transform.Translate(rawInputUD*Time.deltaTime*speed);
        rb.transform.Translate(rawInputLR*Time.deltaTime*speed);
}
    public void movement(InputAction.CallbackContext context){
        Vector2 inputValue= context.ReadValue<Vector2>();
        rawInputUD = new Vector3(0,0,inputValue.y);
        rawInputLR=new Vector3(inputValue.x,0,0);
        Debug.Log(inputValue);
        }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            playerDelegate?.Invoke(20,10);
        }
    }

}
