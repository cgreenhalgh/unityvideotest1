using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class quit : MonoBehaviour
{
    public Button yourButton;

    void Start()
    {
        Debug.Log("Hello");
        if (yourButton)
        {
            Button btn = yourButton.GetComponent<Button>();
            btn.onClick.AddListener(OnQuit);
        }
    }

    public void SetScene(string scene)
    {
        Debug.Log("Load scene " + scene);
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
      
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Debug.Log("escaping...");
            Application.Quit();
        }

    }

    public void OnQuit() {
        Debug.Log("bye!");
        Application.Quit();
    }

    public void Test()
    {
        Debug.Log("test");
    }
}
