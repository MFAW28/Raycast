using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform castPoint;
    public float sightRange;
    //public LayerMask hitSomething;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(castPoint.position, Vector2.right, sightRange);

        if (hit.collider)
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("Hit Player");
                //FlipTowardsPlayer();
                //JumpAttack();
                //MoveInAir();
                Debug.DrawLine(castPoint.position, castPoint.TransformDirection(Vector2.right) * sightRange, Color.yellow);
            }
            if (hit.collider.CompareTag("Wall"))
            {
                Debug.DrawLine(castPoint.position, castPoint.TransformDirection(Vector2.right) * sightRange, Color.red);
            }
        }
        else
        {
            Debug.Log("Hit Another");
            //Patrolling();
            Debug.DrawLine(castPoint.position, castPoint.TransformDirection(Vector2.right) * sightRange, Color.white);
        }
    }
}
