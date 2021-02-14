using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //SceneManager.LoadScene(sceneBuildIndex:1);

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        SceneManager.LoadScene(1);
    }
}