using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public GameObject SelectObject;
    public GameObject SettingObject;
    public GameObject ExitObject;
    private int select = 0;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (select == 2)
            {
                select = 0;
            }
            else
            {
                select += 1;
            }
            if (select == 0)
            {
                SelectObject.GetComponent<ChangeScaleBeat>().enabled = true;
                SettingObject.GetComponent<ChangeScaleBeat>().enabled = false;
                ExitObject.GetComponent<ChangeScaleBeat>().enabled = false;
            }
            if (select == 1)
            {
                SelectObject.GetComponent<ChangeScaleBeat>().enabled = false;
                SettingObject.GetComponent<ChangeScaleBeat>().enabled = true;
                ExitObject.GetComponent<ChangeScaleBeat>().enabled = false;
            }
            if (select == 2)
            {
                SelectObject.GetComponent<ChangeScaleBeat>().enabled = false;
                SettingObject.GetComponent<ChangeScaleBeat>().enabled = false;
                ExitObject.GetComponent<ChangeScaleBeat>().enabled = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (select == 0)
            {
                select = 2;
            }
            else
            {
                select -= 1;
            }
            if (select == 0)
            {
                SelectObject.GetComponent<ChangeScaleBeat>().enabled = true;
                SettingObject.GetComponent<ChangeScaleBeat>().enabled = false;
                ExitObject.GetComponent<ChangeScaleBeat>().enabled = false;
            }
            if (select == 1)
            {
                SelectObject.GetComponent<ChangeScaleBeat>().enabled = false;
                SettingObject.GetComponent<ChangeScaleBeat>().enabled = true;
                ExitObject.GetComponent<ChangeScaleBeat>().enabled = false;
            }
            if (select == 2)
            {
                SelectObject.GetComponent<ChangeScaleBeat>().enabled = false;
                SettingObject.GetComponent<ChangeScaleBeat>().enabled = false;
                ExitObject.GetComponent<ChangeScaleBeat>().enabled = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (select == 0)
            {
                SceneManager.LoadScene("SelectScene");
            }
            if (select == 1)
            {
                SceneManager.LoadScene("SettingScene");
            }
            if (select == 2)
            {
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
            }
        }



    }
}
