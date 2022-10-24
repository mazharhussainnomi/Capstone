using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SelectionScript : MonoBehaviour
{

    public void Scene1()
    {
        SceneManager.LoadScene("CapstoneScene");
    }
    public void Scene2()
    {
        SceneManager.LoadScene("CapstoneScene2");
    }
}
