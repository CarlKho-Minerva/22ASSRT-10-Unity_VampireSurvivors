using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    // private because we want it to be automatic
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        // getElementByID vibes -- .transform is important because it's the var type 
        // verify if "Player" was really chosen by "debug" in Inspector (hit play first)
        target = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
        // LateUpdate is called after Update in other scripts - such as PlayerController.cs
            // this is because we want the camera to follow the player
            // after the player has moved
    void LateUpdate()
    {
        // We initially did 
            // transform.position = target.position;
        // However, this made the camera follow the player directly; we need the z-axis to be -10 to show the game
        // So, we do this instead:
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
        // This makes the camera follow the player, but not the z-axis. "transform.position.z" retains the z-axis value of the camera before we hit play
    }
}
