using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameIntroTextScr : MonoBehaviour
{
    float startTime = 0f;
    public GameObject introText;
    public GameObject introText2;
    public GameObject introText3;
    public GameObject introText4;
    public GameObject introText5;
    public GameObject introText6;
    public GameObject introText7;
    public GameObject introText8;
    //public GameObject loadingText;
    public bool checkEnd;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        checkEnd = false;
        startTime = 0f;
        Time.timeScale = 1;
        //SceneManager.LoadScene("MainZone");
    }

    // Update is called once per frame
    void Update()
    {
        // startTime += Time.deltaTime;
        // introText.SetActive(true);
        // if (startTime > 7)
        // {
        //     introText.SetActive(false);
        //     introText2.SetActive(true);

        //     if (startTime > 14)
        //     {
        //         introText2.SetActive(false);
        //         introText3.SetActive(true);

        //         if (startTime > 21)
        //         {
        //             introText3.SetActive(false);
        //             introText4.SetActive(true);
        //             if (startTime > 28)
        //             {
        //                 introText4.SetActive(false);
        //                 introText5.SetActive(true);
        //                 if (startTime > 35)
        //                 {
        //                     introText5.SetActive(false);
        //                     introText6.SetActive(true);
        //                     if (startTime > 42)
        //                     {
        //                         introText6.SetActive(false);
        //                         introText7.SetActive(true);

        //                         if (startTime > 49)
        //                         {
        //                             introText7.SetActive(true);
        //                             //SceneManager.LoadScene("TestStartScene");
        //                             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //                             checkEnd = true;
        //                         }
        //                     }
        //                 }
        //             }
        //         }
        //     }
        // }


        startTime += Time.deltaTime;
        introText.SetActive(true);
        if (startTime > 3)
        {
            //introText.SetActive(false);
            introText2.SetActive(true);

            if (startTime > 6)
            {
                Debug.Log("Hmm");
                //introText2.SetActive(false);
                introText3.SetActive(true);

                if (startTime > 9)
                {
                    introText.SetActive(false);
                    introText2.SetActive(false);
                    introText3.SetActive(false);
                    // introText3.SetActive(false);
                    introText4.SetActive(true);

                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                    checkEnd = true;
                    // if (startTime > 28)
                    // {
                    // introText4.SetActive(false);
                    // introText5.SetActive(true);
                    // if (startTime > 35)
                    // {
                    //     introText5.SetActive(false);
                    //     introText6.SetActive(true);
                    //     if (startTime > 42)
                    //     {
                    //         introText6.SetActive(false);
                    //         introText7.SetActive(true);

                    //         if (startTime > 49)
                    //         {
                    //             introText7.SetActive(true);
                    //             //SceneManager.LoadScene("TestStartScene");
                    //             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                    //             checkEnd = true;
                    //         }
                    //     }
                    // }
                    //  }
                }
            }
        }



        if (checkEnd)
        {
            startTime = 0f;
            checkEnd = false;
        }

        if (Input.anyKey)
        {
            // introText7.SetActive(false);
            // introText6.SetActive(false);
            // introText5.SetActive(false);
            introText4.SetActive(true);
            //introText4.SetActive(false);
            introText3.SetActive(false);
            introText2.SetActive(false);
            introText.SetActive(false);
            // introText8.SetActive(true);
            //SceneManager.LoadScene("TestStartScene");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
