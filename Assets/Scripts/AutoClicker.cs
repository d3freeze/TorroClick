using System.Collections;
using UnityEngine;
using TMPro;

public class AutoClicker : MonoBehaviour
{
    public TextMeshProUGUI UpgradePriceText;
    public ClickManager clickManager;
    public int _pointsPerSec = 1;
    private bool flag = false;
    public double basePrice = 100;

    private void Start()
    {
        UpgradePriceText.text = basePrice.ToString();
    }

    public void EnableAutoclicker()
    {
        StartCoroutine(AutoClick());
    }
    public void UpgradeAutoclicker()
    {
        if (clickManager.counter < basePrice)
        {
            return;
        }
        clickManager.AddPoints(-basePrice);

        if (flag == false)
        {
            EnableAutoclicker();
            flag = true;
        }
        _pointsPerSec *= 2;
        basePrice *= 2;
        if (basePrice < 1000)
        {
            UpgradePriceText.text = basePrice.ToString();
        }
        else if (basePrice >= 1000 && basePrice < 1000000)
        {
            UpgradePriceText.text = ((basePrice - basePrice % 1) / 1000).ToString() + "k";
        }
        else if (basePrice >= 1000000 && basePrice < 1000000000)
        {
            UpgradePriceText.text = ((basePrice - basePrice % 1) / 1000000).ToString() + "m";
        }
        else if (basePrice >= 1000000000 && basePrice < 1000000000000)
        {
            UpgradePriceText.text = ((basePrice - basePrice % 1) / 1000000).ToString() + "b";
        }
    }
    IEnumerator AutoClick()
    {
        while (true)
        {
            clickManager.AddPoints(_pointsPerSec);
            yield return new WaitForSeconds(1);
        }
    }
}
