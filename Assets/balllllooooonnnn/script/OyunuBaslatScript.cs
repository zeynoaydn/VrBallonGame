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
        // �kinci sahneyi y�kle
        SceneManager.LoadScene("Balon");
    }
    public void Menu()
    {
        // �kinci sahneyi y�kle
        SceneManager.LoadScene("MENU");
    }



}
