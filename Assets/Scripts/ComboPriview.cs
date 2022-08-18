using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ComboPriview : MonoBehaviour
{

    [SerializeField]
    private DataBox dataBox;
    [SerializeField]
    private Image itemImageOne;
    [SerializeField]
    private Image itemImageTwo;
    [SerializeField]
    private TextMeshProUGUI itemTextOne;
    [SerializeField]
    private TextMeshProUGUI itemTextTwo;
    [SerializeField]
    private ItemManager itemManager;

    void Update()
    {

        itemImageOne.sprite = dataBox.itemImages[itemManager.GetItemOneIndex()];

        itemImageTwo.sprite = dataBox.itemImages[itemManager.GetItemTwoIndex()];

        itemTextOne.text = dataBox.itemNames[itemManager.GetItemOneIndex()];

        itemTextTwo.text = dataBox.itemNames[itemManager.GetItemTwoIndex()];

        itemManager.GetItemOneIndex();
    }
}
