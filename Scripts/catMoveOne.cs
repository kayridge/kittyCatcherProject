using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catMoveOne : MonoBehaviour
{
    public float catOneMoveSpeed = 2f;

    public int testInt = 0;

    Rigidbody2D catOneRB;
    private Vector2 catOneMoveVel;

    public float catOneX = 0;
    public float catOneY = 0;
    //public float catOneZ;
    //public bool catOneCaught = false;

   // public Transform catOneTransform;

    //MOVE CAT 

    // Start is called before the first frame update
    void Start()
    {
        catOneRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 catOneMoving = new Vector2(catOneX, catOneY);

        catOneMoveVel = catOneMoving.normalized * catOneMoveSpeed;

  

    }

    private void FixedUpdate()
    {
        
        //want to bounce between 

        //Go right if greater than 0 and less than 10
        //add to int
        if ((testInt >= 0) && (testInt < 60))
        {
            //GO RIGHT
            catOneRB.MovePosition(catOneRB.position + (catOneMoveVel * Time.fixedDeltaTime));
            testInt++;
        }

        //Go left if greater than / = 10 and less than 19
        if ((testInt >= 60) && (testInt < 119))
        { 
            //GO LEFT
            catOneRB.MovePosition(catOneRB.position - (catOneMoveVel * Time.fixedDeltaTime));
            testInt++;
        }
        
        if (testInt == 119)
        {
            testInt = 0;
        }
        
    }
}


/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charMove : MonoBehaviour { 

    public float charSpeed;

    private RigidBody2D charRigidBody;
    private Vector2 charMoveVelocity;

    // Start is called before the first frame update
    void Start()
    {
        charRigidBody = GetComponent<RigidBody2d>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 charMoveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        charMoveVelocity = charMoveInput.normalized * charSpeed;
    }

    private void FixedUpdate()
    {
        charRigidBody.MovePosition(charRigidBody.position + charMoveVelocity * Time.fixedDeltaTime);
    }
}
*/
