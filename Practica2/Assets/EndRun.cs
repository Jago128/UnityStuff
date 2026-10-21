using UnityEngine;

public class EndRun : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("You have reached the end! Well done!");
        }
    }
}
