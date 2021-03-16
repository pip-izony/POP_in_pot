using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Shop : MonoBehaviour
{
    public void shopButton()
    {
        SceneManager.LoadScene("Shop");
    }
    public void returnButton()
    {
        PlayerPrefs.SetFloat("floata", 0);
        PlayerPrefs.SetFloat("floatb", 0);
        PlayerPrefs.SetFloat("floatc", 0);
        PlayerPrefs.SetFloat("floatav", 0);
        PlayerPrefs.SetFloat("floatbv", 0);
        PlayerPrefs.Save();
        SceneManager.LoadScene("SampleScene");
    }
    public void homeButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void middleButton()
    {
        SceneManager.LoadScene("Middle");
    }
}
