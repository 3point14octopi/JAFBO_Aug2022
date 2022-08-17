using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ComboPriview : MonoBehaviour
{
    public Sprite[] itemImages;


    public Image itemImageOne;
    public Image itemImageTwo;



    public TextMeshProUGUI itemTextOne;

    public TextMeshProUGUI itemTextTwo;

    public ItemManager itemManager;

    void Update()
    {

        itemImageOne.sprite = itemImages[itemManager.GetItemOneIndex()];

        itemImageTwo.sprite = itemImages[itemManager.GetItemTwoIndex()];

        itemTextOne.text = itemManager.itemNames[itemManager.GetItemOneIndex()];

        itemTextTwo.text = itemManager.itemNames[itemManager.GetItemTwoIndex()];

        itemManager.GetItemOneIndex();
    }
}
