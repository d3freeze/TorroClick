using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class ClickManager : MonoBehaviour
{
    public TMP_Text points;
    public TMP_Text pricetxt;
    private double counter = 0;
    private double price = 100;
    private double addPoints = 1;
    public GameObject yellow;
    public GameObject blue;
    public GameObject purple;
    public GameObject pink;
    public GameObject guy;
    public GameObject guy1;
    public GameObject guy2;
    public GameObject guy3;
    public void SetText()
    {
        counter += addPoints;
        points.SetText((counter - counter % 1).ToString());
    }
    public void UpgradePrice()
    {
        if (counter >= price)
        {
            counter -= price;
            points.SetText((counter - counter % 1).ToString());
            price *= 2;
            addPoints *= 2.05;

        }
        if (price < 1000)
        {
            pricetxt.SetText((price - price % 1).ToString());
            yellow.SetActive(true);
            blue.SetActive(false);
            purple.SetActive(false);
            pink.SetActive(false);
            guy.SetActive(true);
            guy1.SetActive(false);
            guy2.SetActive(false);
            guy3.SetActive(false);
        }
        else if (price >= 1000 && price < 1000000)
        {
            pricetxt.SetText(((price - price % 1) / 1000).ToString() + "k");
            yellow.SetActive(false);
            blue.SetActive(true);
            purple.SetActive(false);
            pink.SetActive(false);
            guy.SetActive(false);
            guy1.SetActive(true);
            guy2.SetActive(false);
            guy3.SetActive(false);
        }
        else if (price >= 1000000 && price < 1000000000)
        {
            pricetxt.SetText(((price - price % 1) / 1000000).ToString() + "m");
            yellow.SetActive(false);
            blue.SetActive(false);
            purple.SetActive(true);
            pink.SetActive(false);
            guy.SetActive(false);
            guy1.SetActive(false);
            guy2.SetActive(true);
            guy3.SetActive(false);
        }
        else if (price >= 1000000000 && price < 5000000000)
        {
            pricetxt.SetText(((price - price % 1) / 1000000000).ToString() + "b");
            yellow.SetActive(false);
            blue.SetActive(false);
            purple.SetActive(false);
            pink.SetActive(true);
            guy.SetActive(false);
            guy1.SetActive(false);
            guy2.SetActive(false);
            guy3.SetActive(true);
        }
        else if (price >= 5000000000)
        {
            SceneManager.LoadScene(2);
        }
    }
}