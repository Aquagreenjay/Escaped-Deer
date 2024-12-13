using System.Collections;
using UnityEngine;

public class Flag : MonoBehaviour
{    
    [Header("Flag 1")]
    
    public DialougeTrigger dialougeTrigger1;
    public AudioClip newsSong;
    public AudioSource newsSource;
    public GameObject trigger1;

    [Header("Flag 2")]

    public GameObject deerAnimObj;

    public void RunFlagCheck(float flagNum) 
    {
        if(flagNum == 1)
        {
            dialougeTrigger1.TriggerDialouge();
            newsSource.clip = newsSong;
            newsSource.Play();
            trigger1.SetActive(false);
        }
        else if(flagNum == 2)
        {
            Animator deerAnim = deerAnimObj.GetComponent<Animator>();
            deerAnim.SetTrigger("roadJump");
        }
    }
}
