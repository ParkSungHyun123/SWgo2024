using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.VFX;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject StartUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickWeapon_1()
    {
        SceneManager.LoadScene("alarm");
    }
    
    public void ClickWeapon_2()
    {
        SceneManager.LoadScene("baton");
    }

    public void ClickWeapon_3()
    {
        SceneManager.LoadScene("Spray");
    }

    public void ClickWeapon_4()
    {
        
    }

    public void ClickExit()
    {
        StartUI.SetActive(true);
    }
}
