using System;
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

    public bool following = false;
    int i = 0;
    public int numberOfItems;

    List<GameObject> go = new List<GameObject>();
    //public GameObject bullet,Target;

    private void Awake() 
    {
        Cursor.lockState = CursorLockMode.None;
        //rb=GetComponent<Rigidbody>();
        /*health.setMaxHealth(maxHealth);
        presentHealth=maxHealth;*/
    }
    private void Update()
    {
        /*Vector3 TDir= Target.transform.position-transform.position;
        Debug.Log(TDir.magnitude);
        if(TDir.magnitude<10){
            transform.position=transform.position;
            //Shoot();
        }else{
        rb.transform.Translate(Tdir*Time.deltaTime*speed);
        }*/
        //rb.transform.Translate(rawInputUD*Time.deltaTime*speed);
        //rb.transform.Translate(rawInputLR*Time.deltaTime*speed);
            InputMovement();
            /*if (following)
            {
                for (int i = 0; i < go.Count; i++)
                {
                    if (i == 0)
                    {
                        go[i].transform.position = this.transform.position - new Vector3(1, 0, 1);
                    }
                    if (i == 1)
                    {
                        go[i].transform.position = this.transform.position - new Vector3(1, 0, 0);
                    }
                    if (i == 2)
                    {
                        go[i].transform.position = this.transform.position - new Vector3(0, 0, 1);
                    }

                }
            }*/

        }

    private void InputMovement()
    {
        rb.transform.Translate(Vector3.right * Input.GetAxis("Horizontal")*Time.deltaTime*speed);
        rb.transform.Translate(Vector3.forward * Input.GetAxis("Vertical")*Time.deltaTime*speed);

    }



    /*public void movement(InputAction.CallbackContext context){
   Vector2 inputValue= context.ReadValue<Vector2>();
   rawInputUD = new Vector3(0,0,inputValue.y);
   rawInputLR=new Vector3(inputValue.x,0,0);
   //Debug.Log(inputValue);
   }*/

    private void OnCollisionEnter(Collision other)
    {
       
    }

}
