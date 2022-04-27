using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    public Transform target;
    public bool isMove = false;
    public GameUIManager gameUI;
    public int coinNum = 0;
    

    void Update()
    {
        
        gameUI.SetCoin(coinNum);

    }
    

    void onCollisionEnter(Collider other)
    {
        coinNum++;
        if (other.gameObject.tag == "Player")
        {
            coinNum++;
            Destroy(gameObject);
        }

    }

    
}

