using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHP : MonoBehaviour
{
  public float totalHP;
  public float HP;
  public GameObject hpBar;

  void Awake()
  {
    HP = totalHP;
  }
  void Update()
  {
    if(hpBar != null)
    {
        hpBar.transform.localScale = new Vector2(HP / totalHP, hpBar.transform.localScale.y);
    }
  }






}
