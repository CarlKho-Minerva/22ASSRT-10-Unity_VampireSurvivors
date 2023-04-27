using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // public = shows as INPUT FIELD in Unity
    // private = hardcoded in the C# script
    // variables are camelCase

    public float moveSpeed;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        // takes THREE (3) vector values 
        // `f` in "0f" => float
        Vector3 moveInput = new Vector3(0f,0f,0f);

        // View types of input (Axes) = Edit --> Project Settings --> Input Manager --> Axes
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        // viewable in "Play >" --> Console
            // if autoscroll not working --> pause/play
        
        // visualize with graph (diagonal = longer than horizontal/vertical)
        // makes it so that diagonal movement is not faster than horizontal/vertical movement
        moveInput.Normalize(); 

        Debug.Log(moveInput); 

        // transform is basically modifying axes value
        // position just maps it too position instead of rotation/scale
            // increment base speed * multiplier
                // 💡LESSON: Diff PCs = Diff Framerates due to power
                    // V-Sync helps stablize that. However, it isn't always on by default.
                        // Time.deltaTime represents the amount of time in seconds it took to complete the last frame.
        transform.position += moveInput * moveSpeed * Time.deltaTime;
    }
}
