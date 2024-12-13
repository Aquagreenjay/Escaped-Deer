using UnityEngine;

public class FlagEntity : MonoBehaviour
{
    public Flag flag;
    public float flagId;

    private void OnTriggerEnter(Collider other) 
    {
        flag.RunFlagCheck(flagId);
    }
}
