﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    public void LoadGameplay()
    {
        SceneManager.LoadScene(1);
    }
    public void ReloadGame()
    {
        SceneManager.LoadScene(0);
    }
}
