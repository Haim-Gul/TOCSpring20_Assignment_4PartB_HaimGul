﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
   public void SceneLoader(string name)
    {
        SceneManager.LoadScene(name);
    }
}
