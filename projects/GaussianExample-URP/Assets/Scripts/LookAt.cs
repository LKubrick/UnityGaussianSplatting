using UnityEngine;

public class LookAt : MonoBehaviour
{
   public Transform player; // Assign your player or camera here

    void Update()
    {
        if (player != null)
        {   
            Vector3 direction = (player.position - transform.position).normalized;
        transform.forward = -direction; // Flip the direction if necessary
        }
    }
}
