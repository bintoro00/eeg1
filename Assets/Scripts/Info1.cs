using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.SceneManagement;
 public class Info1 : MonoBehaviour
 {
     public FadeCtrl fade;

     private bool firstPush = false;
     void Update()
     {
          if (fade.compFadeOut)
          {
              SceneManager.LoadScene("Info");
          }
     }

     public void PressStart()
     {
          Debug.Log("Press Start!");
          if (!firstPush)
          {
              if (fade != null)
              {
                  fade.StartFadeOut();
                  firstPush = true;
              }
          }
     }
     public void ChangeScene(){
         SceneManager.LoadScene("Info");
     }
 }