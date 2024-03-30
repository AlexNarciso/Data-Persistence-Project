using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public static MainMenu Instance;
    public string name;
    public Text showName;
    private string saveName;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }


    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }

    public void NameAlex()
    {
       
        name = "Alex";
        showName.text = "Name: " + name;
        saveName = name;
        MainMenu.Instance.saveName = saveName;
    }

    public void NameRob()
    {
        name = "Rob";
        showName.text = "Name: " + name;
        saveName = name;
        MainMenu.Instance.saveName = saveName;
    }
}
