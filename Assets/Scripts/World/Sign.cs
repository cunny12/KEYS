using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sign : MonoBehaviour
{
  public GameObject dialogBox;
  public Text dialogText;
  public string dialog;
  public bool playerInRange;   

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.E) && playerInRange)
    {
        Debug.Log("E key was pressed.");
        if(dialogBox.activeInHierarchy)
        {
            dialogBox.SetActive(false);
        }else{
            dialogBox.SetActive(true);
            dialogText.text = dialog;
        }
    }
  }
  
  private void OnTriggerEnter2D(Collider2D other)
  {
    if(other.CompareTag("Player"))
    {
        playerInRange = true;
        Debug.Log("Player in range!");
    }
  }
  private void OnTriggerExit2D(Collider2D other)
  {
    if(other.CompareTag("Player"))
    {
        playerInRange = false;
        Debug.Log("Player left range D:");
        dialogBox.SetActive(false);
    }
  }
}
