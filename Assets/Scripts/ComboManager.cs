using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboManager : MonoBehaviour
{
    [SerializeField]
    private AudioManager audioManager;
    private bool combotester = false;
    public void Combine()
    {
        if(!combotester)
        {
            NewCombo();
            combotester = true;
        }
        else
        {
            OldCombo();
        }

    }


    public void OldCombo()
    {
        audioManager.PlayOldCombo();
        
    }

    public void NewCombo()
    {
        
        audioManager.PlayNewCombo();
        
    }

}
