using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public Rigidbody2D theRB;
    public float moveSpeed;
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
    // theRB.velocity = Vector2(-moveSpeed, 0f);
        // Vector 2 only X and Y axis
          // No time.deltaTime because there is no moveInput multiplier (player)
            // Velocity is a way of saying "This is how much movement we want to apply to this object" every frame.
                // Not dependent on the frame rate of the game -- Unity processes in the BG

        theRB.velocity = (target.position - transform.position).normalized * moveSpeed;
        // NOT PYTHAGORAS THEOREM 
        // To make enemy follow player, getCurrentPlater location (0,0) and subtract enemyCurrentLocation (0,0) to get the distance between the two
            // Normalized limits to length of 1
                // Note that velocity, by default, uses Vector 2

    }
}
