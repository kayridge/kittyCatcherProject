using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollisionCat : MonoBehaviour
{

    
    // Start is called before the first frame update
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Cat collided");
            
            Destroy(gameObject);
        }
    }

}
