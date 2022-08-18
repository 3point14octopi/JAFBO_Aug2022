using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    

    [SerializeField]
    private ComboManager comboManager;
    private int comboItemOneIndex, comboItemTwoIndex;
    private bool itemOneSet = false;
    private bool itemTwoSet = false;

    private void Update() 
    {
        if(itemTwoSet) 
        {
            comboManager.Combine();
            Cancel();
        }  
    }

    public int GetItemOneIndex()
    {
        return comboItemOneIndex;
    }

    public int GetItemTwoIndex()
    {
        return comboItemTwoIndex;
    }

    public void SetItem(int itemIndex)
    {
        if(!itemOneSet)
        {
            comboItemOneIndex = itemIndex;
            itemOneSet = true; 
        }  
        else
        {
            comboItemTwoIndex = itemIndex;
            itemTwoSet = true;
        } 
    }

    public void Cancel()
    {
        comboItemOneIndex = 0;
        itemOneSet = false;
        comboItemTwoIndex = 0;
        itemTwoSet = false;
    }

}
