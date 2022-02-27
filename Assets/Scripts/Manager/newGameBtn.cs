using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonUI : MonoBehaviour
{
    [SerializeField] private string newGame = "GridEnvironment";

   public void newGameBtn()
   {
       SceneManager.LoadScene(newGame);
   }
}
