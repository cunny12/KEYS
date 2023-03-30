using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneIntoCave : MonoBehaviour
{
    public VectorValue playerStorage;
    public Vector2 PlayerChange;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "player")
        {
            playerStorage.initialValue = PlayerChange;
            SceneManager.LoadScene("InsideCave");
        }
    }
}
