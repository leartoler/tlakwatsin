using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsManager : MonoBehaviour
{
    public GameObject[] InGameMenuStars;
    public GameObject[] WinPanelStars;
    public GameObject[] FireGame;
    private int collectedStarsCount = 0;
    private const int Maximum_Stars_Count = 3;

    public void ResetStars()
    {
        collectedStarsCount = 0;

        for (int i = 0; i < Maximum_Stars_Count; i++)
        {
            InGameMenuStars[i].SetActive(false);
            WinPanelStars[i].SetActive(false);
        }
    }
    /*
    public void StarCollected()
    {
        if (collectedStarsCount > Maximum_Stars_Count - 1)
        {
            return;
        }
        InGameMenuStars[collectedStarsCount].SetActive(true);
        WinPanelStars[collectedStarsCount].SetActive(true);
        collectedStarsCount++;
    }*/

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Fire")
        //if (Input.GetKey(KeyCode.A))
        {
            GameObject[] FireGame = GameObject.FindGameObjectsWithTag("Fire");
            if (collectedStarsCount > Maximum_Stars_Count - 1)
            {
                return;
            }
            InGameMenuStars[collectedStarsCount].SetActive(true);
            WinPanelStars[collectedStarsCount].SetActive(true);
            collectedStarsCount++;
            Debug.Log("dasdasd");

        }

        }
    }

   