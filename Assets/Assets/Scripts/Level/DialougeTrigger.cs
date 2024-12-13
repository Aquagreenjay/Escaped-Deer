using UnityEngine;

public class DialougeTrigger : MonoBehaviour
{
   public Dialouge dialouge;

    public void TriggerDialouge()
    {
       Object.FindFirstObjectByType<DialougeManager>().StartDialouge(dialouge);
    }
}
