using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public string[] itemNames;

    private int comboItemOneIndex, comboItemTwoIndex;

    private bool itemOneSet = false;
    private bool itemTwoSet = false;

    private void Update() 
    {
        if(itemTwoSet) 
        {
            Combine();
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

    private void Combine()
    {
        //make comparrissons and see if combo exists

        if(comboItemOneIndex == 1 && comboItemTwoIndex == 3)
        {
            Debug.Log("And he gives a darn :D");
        }
        else
        {
            Debug.Log("He don't give a darn :C");
        }
    }
}
