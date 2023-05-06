using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MAINMENU : MonoBehaviour
{

    public void GoToScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void DownloadKartu(string link)
    {
        Application.OpenURL(link);
    }
}
