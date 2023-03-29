using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
   public int maxStackedItems = 5;
   public InvSlot[] InventorySlots;
   public GameObject inventoryItemPrefab;

   int selectedSlot = -1;
   private void Start()
   {
     ChangeSelectSlot(0);
   }

   private void Update()
   {
    if (Input.inputString != null)
    {
        bool isNumber = int.TryParse(Input.inputString, out int number);
        if (isNumber && number > 0 && number <8)
        {
            ChangeSelectSlot(number -1);
        }
    }
   }
   void ChangeSelectSlot(int newValue)
   {
    if (selectedSlot >= 0){
    InventorySlots[selectedSlot].Deselect();
   }
    InventorySlots[newValue].Select();
    selectedSlot = newValue;
   }



   public bool AddItem(Item item)
   {
      
       for (int i = 0; i <InventorySlots.Length; i++)
       {
        InvSlot slot = InventorySlots[i];
        InvItem itemInSlot =slot.GetComponentInChildren<InvItem>();
        if (itemInSlot != null && itemInSlot.item == item && itemInSlot.count < maxStackedItems && itemInSlot.item.stackable == true) {

        itemInSlot.count++;
        itemInSlot.RefreshCount();
        return true;
        }
       }
      
       for (int i = 0; i <InventorySlots.Length; i++)
       {
        InvSlot slot = InventorySlots[i];
        InvItem itemInSlot =slot.GetComponentInChildren<InvItem>();
        if (itemInSlot == null){
        SpawnNewItem(item, slot);
        return true;
        }
       }
       return false;
   }
   void SpawnNewItem(Item item, InvSlot slot)
   {
      GameObject newItemGo = Instantiate(inventoryItemPrefab, slot.transform);
      InvItem invItem = newItemGo.GetComponent<InvItem>();
      invItem.InitialiseItem(item);

   }

   public Item GetSelectedItem(bool use)
   {
    InvSlot slot = InventorySlots[selectedSlot];
    InvItem itemInSlot = slot.GetComponentInChildren<InvItem>();
    if (itemInSlot != null)
    {
        return itemInSlot.item;
        if (use == true)
        {
            itemInSlot.count--;
            if (itemInSlot.count <= 0)
            {
                Destroy(itemInSlot.gameObject);
            }
            else 
            {
                itemInSlot.RefreshCount();
            }
        }
    }
    return null;
   }
}

