﻿using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadSceneComponent : MonoBehaviour 
{
 float timer = 0;
 public string loadThisScene;

 void Start()
 {  
     Time.timeScale = 1;
     GameManager.Instance.GetComponentInChildren<ScoreManager>().ResetScore();
 }

 void Update()
 {
    timer += Time.deltaTime;

    if (timer > 3)
    {
        SceneManager.LoadScene(loadThisScene);
    }
 }
}