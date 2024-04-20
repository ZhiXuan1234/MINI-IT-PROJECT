using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Level2CoinCollect : MonoBehaviour
{
    public int coinCount;
    public TMP_Text coinText;
    public GameObject door2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = ":" + coinCount.ToString() + "/20";

        if (coinCount == 20)
        {
            Destroy(door2);
        }
    }
}
