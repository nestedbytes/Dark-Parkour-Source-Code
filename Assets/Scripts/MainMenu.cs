using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
public void PlayGame () {
SceneManager.LoadScene("game");
}
public void About () {
 SceneManager.LoadScene("about");
}
public void Quit () {
    Application.Quit();
}


}
