using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Item : MonoBehaviour
{

    //Common parameters for Food_Item

    private Camera mainCamera;
    public bool is_dragging;
    public Vector3 my_place;
    public bool Door_Chosen=false;
    private GameObject Door;
    
    public bool Being_Eaten;
    public int Number_of_Fooditems;
    public int Eating_Time;

    private void Awake() 
    {
        Set_Camera();
    }
    

    private void Set_Camera()
    {
        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }
    
    
    //dragging the food in the screen 
    private void OnMouseDrag()
    {
        Ray ray=mainCamera.ScreenPointToRay(Input.mousePosition);
        is_dragging=true;
        if(Physics.Raycast(ray,out RaycastHit raycastHit))
        {
            transform.position=new Vector3(raycastHit.point.x,2,raycastHit.point.z);
        }
    }
    
    private  void OnMouseUp()
    {
        is_dragging = false;
        if (Door_Chosen == true)
        {
            //if there is no human selected then ..
            Door_Chosen = false;
            Destroy(Door);
            Destroy(this.gameObject);
        }
    }

    private void Reset_Position()
    {
        // if the number of food items are greater than 0
        if (Number_of_Fooditems > 0) 
            transform.position = my_place;
        else
            this.gameObject.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        //if food object is in contact with the human 
        if(other.gameObject.CompareTag("Human"))
        {
            Door_Chosen = true;
            Door = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        /*if the food object is not in contact with the human , 
          so the food object chooses the human null ( why because there are
          no humans right ?? )
        */
        if(other.gameObject.CompareTag("Human"))
        {
            Door_Chosen = false;
            Door = null ;
        }
    }
/* When the human is eating , 
    the human energy will rises
    the human will not have the food anymore since he eats the food
*/
    IEnumerator Eating(float time)
    {
        yield return new WaitForSecondsRealtime(time);   
    } 
    
}
