using UnityEngine;

public class DoorTriggerOptimization : MonoBehaviour
{
    public GameObject trees;

    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log("Working");
        trees.SetActive(false);
    }
}
