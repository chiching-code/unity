using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    public GameUIManager gameUI;
    public int coinNum = 0;
    

    void Update()
    {
        print(coinNum);
        //gameUI.SetCoin(coinNum);
    }
    

    void OnTriggerEnter(Collider other)
    {
        print(coinNum);
        if (other.gameObject.tag == "getCoin")
        {
            coinNum++;
            Destroy(gameObject);
        }

    }

    
}

