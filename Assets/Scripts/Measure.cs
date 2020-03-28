﻿using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.SceneManagement;
 public class Measure : MonoBehaviour
 {
     public FadeCtrl fade;

     private bool firstPush = false;
     void Update()
     {
          if (fade.compFadeOut)
          {
              SceneManager.LoadScene("Measure");
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
 }