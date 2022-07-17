using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameover : MonoBehaviour
{
  void OnTriggerEnter(Collider other)
  {
    SceneManager.LoadScene("gameoverscene");
  }




}