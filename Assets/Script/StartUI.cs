using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnLevelWasLoaded()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void ClickStartButten()
    {
        SceneManager.LoadScene("WeaponSelect");
    }

    public void ClickQuitButten()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
