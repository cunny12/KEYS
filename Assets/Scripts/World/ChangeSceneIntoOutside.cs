using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneIntoOutside : MonoBehaviour
{
    public VectorValue playerStorage;
    public Vector2 PlayerChange;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "player")
        {
            
            SceneManager.LoadScene("Outside");
            playerStorage.initialValue = PlayerChange;
        }
    }
}
