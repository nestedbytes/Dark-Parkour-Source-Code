using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class win : MonoBehaviour
{
  void OnTriggerEnter(Collider other)
  {
    SceneManager.LoadScene("WinScene");
  }




}