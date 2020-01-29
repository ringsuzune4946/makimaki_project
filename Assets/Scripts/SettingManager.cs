using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingManager : MonoBehaviour
{
    public GameObject VolumeObject;
    public GameObject KeyObject;
    public GameObject TitleObject;
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
                VolumeObject.GetComponent<ChangeScaleBeat>().enabled = true;
                KeyObject.GetComponent<ChangeScaleBeat>().enabled = false;
                TitleObject.GetComponent<ChangeScaleBeat>().enabled = false;
            }
            if (select == 1)
            {
                VolumeObject.GetComponent<ChangeScaleBeat>().enabled = false;
                KeyObject.GetComponent<ChangeScaleBeat>().enabled = true;
                TitleObject.GetComponent<ChangeScaleBeat>().enabled = false;
            }
            if (select == 2)
            {
                VolumeObject.GetComponent<ChangeScaleBeat>().enabled = false;
                KeyObject.GetComponent<ChangeScaleBeat>().enabled = false;
                TitleObject.GetComponent<ChangeScaleBeat>().enabled = true;
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
                VolumeObject.GetComponent<ChangeScaleBeat>().enabled = true;
                KeyObject.GetComponent<ChangeScaleBeat>().enabled = false;
                TitleObject.GetComponent<ChangeScaleBeat>().enabled = false;
            }
            if (select == 1)
            {
                VolumeObject.GetComponent<ChangeScaleBeat>().enabled = false;
                KeyObject.GetComponent<ChangeScaleBeat>().enabled = true;
                TitleObject.GetComponent<ChangeScaleBeat>().enabled = false;
            }
            if (select == 2)
            {
                VolumeObject.GetComponent<ChangeScaleBeat>().enabled = false;
                KeyObject.GetComponent<ChangeScaleBeat>().enabled = false;
                TitleObject.GetComponent<ChangeScaleBeat>().enabled = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (select == 0)
            {
            }
            if (select == 1)
            {
            }
            if (select == 2)
            {
                SceneManager.LoadScene("Title");
            }
        }



    }
}
