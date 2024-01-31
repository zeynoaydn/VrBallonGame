using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunuBaslatScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void MainMenuu()
    {
        // Ýkinci sahneyi yükle
        SceneManager.LoadScene("Balon");
    }
    public void Menu()
    {
        // Ýkinci sahneyi yükle
        SceneManager.LoadScene("MENU");
    }



}
