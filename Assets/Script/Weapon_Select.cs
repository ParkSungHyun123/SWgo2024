using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Weapon_Select : MonoBehaviour
{
    public GameObject secret_Weapon;

    public int clear;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (clear == 3) secret_Weapon.SetActive(true);
        else secret_Weapon.SetActive(false);
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
        SceneManager.LoadScene("StartScene");
    }
}
