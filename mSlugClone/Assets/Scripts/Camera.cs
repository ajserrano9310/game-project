
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform target;
    public Vector3 offset;
    [Range(0, 10)]
    public float smoothFactor; 
    

    private void LateUpdate()
    {
        Follow();   
    }

    void Follow()
    {
        Vector3 targetPosition = target.position + offset;
        // This makes sure that the numbers remain constant for any pc. 
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothFactor*Time.fixedDeltaTime); // This smooths out the way the camera follows the player
        transform.position = smoothedPosition;
        //transform.position = targetPosition;

    }
}
