using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenInv : MonoBehaviour
{
   public GameObject mainInvGroup;

   void Update()
  {
    if (Input.GetKeyDown(KeyCode.I))
    {
        Debug.Log("I key was pressed.");
        if(mainInvGroup.activeInHierarchy)
        {
            mainInvGroup.SetActive(false);
        }else{
            mainInvGroup.SetActive(true);
    }
  }
}
}