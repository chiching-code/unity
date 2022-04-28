using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float speed = 1.5f;
    public Transform m_transform;
    public GameUIManager gameUI;
    public GameObject myObj;
    public int coinNum = 0;

    // Use this for initialization
    void start()
    {
        
        m_transform = this.transform;
    }
    void OnTriggerEnter(Collider other)
    {
        coinNum++;
        Destroy(other.gameObject);
        
    }
    // Update is called once per frame
    void Update()
    {
        gameUI.SetCoin(coinNum);
        Vector3 move = myObj.transform.position;
        move.y = 12.5f;
        move = new Vector3(move.x, move.y, move.z);
        m_transform.position = move;
        //if (Input.GetKey(KeyCode.L))
        //{
        //    m_transform.Translate(Vector3.left * Time.deltaTime * speed);
        //}
        //if (Input.GetKey(KeyCode.J))
        //{
        //    m_transform.Translate(Vector3.right * Time.deltaTime * speed);
        //}
        //if (Input.GetKey(KeyCode.K))
        //{
        //    m_transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //}
        //if (Input.GetKey(KeyCode.I))
        //{
        //    m_transform.Translate(Vector3.back * Time.deltaTime * speed);
        //}


        
    }
    
}
