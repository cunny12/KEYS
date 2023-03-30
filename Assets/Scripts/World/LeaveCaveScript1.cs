using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LeaveCaveScript1 : MonoBehaviour
{
  public Vector2 PlayerChange;
  public GameObject LeaveCaveIcon;
  public bool playerInRange;   
  public VectorValue playerStorage;

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.E) && playerInRange)
    {
      playerStorage.initialValue = PlayerChange;
      SceneManager.LoadScene("Outside");
    }
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    if(other.CompareTag("Player"))
    {
        playerInRange = true;
        Debug.Log("Player in range!");
        if(LeaveCaveIcon.activeInHierarchy)
        {
            LeaveCaveIcon.SetActive(false);
        }
        else
        {
            LeaveCaveIcon.SetActive(true);
        }
    }
  }
  private void OnTriggerExit2D(Collider2D other)
  {
    if(other.CompareTag("Player"))
    {
        playerInRange = false;
        Debug.Log("Player left range D:");
        LeaveCaveIcon.SetActive(false);
    }
  }
}
