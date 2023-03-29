using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCDialog1 : MonoBehaviour
{
    public GameObject DialogPanel;
    public Text DialogText;
    public string [] dialog;
    private int index;

    public GameObject continueButton;
    public float wordSpeed;
    public bool playerInRange;
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInRange)
    {
       if (DialogPanel.activeInHierarchy)
       {
        zeroText();
       }
       else
       {
        DialogPanel.SetActive(true);
        StartCoroutine(Typing());
       }
    }
    if(DialogText.text == dialog[index])
    {
        continueButton.SetActive(true);
    }
    }

      public void zeroText()
    {

        DialogText.text = "";
        index = 0;
        DialogPanel.SetActive(false);
    }

    IEnumerator Typing()
    {
        foreach(char letter in dialog[index].ToCharArray())
        {
            DialogText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }
    public void NextLine()
    {
        continueButton.SetActive(false);

        if(index < dialog.Length - 1)
        {
            index ++;
            DialogText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
          zeroText();
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
        DialogPanel.SetActive(false);
    }
  }
}
