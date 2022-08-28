using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Food_Item : MonoBehaviour
{

    //Common parameters for Food_Item

    public Camera mainCamera;
    public bool is_dragging=true;
    public bool Door_Chosen=false;
    //private GameObject Door;
    
 
    
    //dragging the food in the screen 
    private void OnMouseDrag()
    {
        Ray ray=mainCamera.ScreenPointToRay(Input.mousePosition);
        
        is_dragging=true;
        if(Physics.Raycast(ray,out RaycastHit raycastHit))
        {
            transform.position=new Vector3(raycastHit.point.x,0,raycastHit.point.z);
        }
    }
    
    private  void OnMouseUp()
    {
        
        
    }


    private void OnTriggerEnter(Collider other)
    {
        //if food object is in contact with the human 
        if (other.gameObject.CompareTag("Door"))
        {
            other.gameObject.GetComponent<Door>().Rotate();
            Destroy(this.gameObject);
        }
       
    }
    
    /* When the human is eating , 
        the human energy will rises
        the human will not have the food anymore since he eats the food
    */


}
