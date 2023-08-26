using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D myrygibody;
    public Vector2 friction = new Vector2(.1f, 0);
    public float Speed;
    public float ForceJump = 1.5f;
    public float Speedcaracter;
   
    private float Speedforce;
    private void Update()
    {
        MyPlayer();
        PlayerJump();
    }

    private void MyPlayer()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        
            Speedforce = Speedcaracter;
        else
                Speedforce = Speed;
        

       if (Input.GetKey(KeyCode.LeftArrow))
        {
            //myrygibody.MovePosition(myrygibody.position - velocitty * Time.deltaTime);
            myrygibody.velocity = new Vector2(-Speedforce, myrygibody.velocity.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //myrygibody.MovePosition(myrygibody.position + velocitty * Time.deltaTime);
            myrygibody.velocity = new Vector2(+Speedforce, myrygibody.velocity.y);

        }
        if (myrygibody.velocity.x > 0)
        {
            myrygibody.velocity -= friction; 
        }
        else if (myrygibody.velocity.x < 0)
        {
            myrygibody.velocity += friction;

        }

    }

    private void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myrygibody.velocity = Vector2.up * ForceJump;
        }
    }
}
