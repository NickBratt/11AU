﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
            else {
                Time.timeScale = 1;
            }
        }
	}
}
