using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player; // Reference to the player GameObject
    private Vector3 offset; // Offset between camera and player

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Calculate and store the offset value by getting the distance between the player's position and camera's position.
        // offset is when the camera is at its initial position relative to the player
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    // void Update()
    // {

    // }

    void LateUpdate()
    {
        // Ensures the camera follows the player after all movement calculations are done
        transform.position = player.transform.position + offset;
    }
}
