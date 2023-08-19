using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D myrygibody;
    public Vector2 velocitty;
    public float speed;
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //myrygibody.MovePosition(myrygibody.position - velocitty * Time.deltaTime);
            myrygibody.velocity = new Vector2(-speed, myrygibody.velocity.y); 
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //myrygibody.MovePosition(myrygibody.position + velocitty * Time.deltaTime);
            myrygibody.velocity = new Vector2(+speed, myrygibody.velocity.y);

        }
    }
}
