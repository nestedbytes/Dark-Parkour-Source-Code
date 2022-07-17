using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class winmenu : MonoBehaviour
{
public void PlayGameAg () {
SceneManager.LoadScene("game");
}
public void menu () {
SceneManager.LoadScene("mainmenu");
}


}
