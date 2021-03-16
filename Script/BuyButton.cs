using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{

    public enum ItemType
    {
        gold
    }

    public ItemType itemType;

    //public Text priceText;
    //private string defaultText;
    // Start is called before the first frame update
    /*void Start()
    {
        defaultText = priceText.text;
        StartCoroutine(LoadPriceRoutine());
    }*/

    public void ClickBuy()
    {
        switch (itemType)
        {
            case ItemType.gold:
                IAPManager.Instance.BuyGold();
                break;
        }
    }

    /*private IEnumerator LoadPriceRoutine()
    {
        while(!IAPManager.Instance.IsInitialized())
        {
            yield return null;
        }
        string loadedPrice = "";

        switch (itemType)
        {
            case ItemType.gold:
                loadedPrice = IAPManager.Instance.GetProducePriceFromStore(IAPManager.Instance.Gold);
                break;
        }
        priceText.text = defaultText + " " + loadedPrice;
    }*/
}
