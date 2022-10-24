using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    public GameObject[] Banana;
    public int indexes = 0;
    
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawingFunction", 5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void SpawingFunction()
    {
       
        Instantiate(Banana[indexes]);

        if (indexes >= 3) {

            Debug.Log("Game Completed");
        indexes = 0;
        }
        else
        {
            indexes = indexes + 1;
           // GameObject.Find("Canvas").transform.GetChild(0).gameObject.SetActive(true);
        }

    }

    public void Selection()
    {
        SceneManager.LoadScene("Selection");
    }

}
