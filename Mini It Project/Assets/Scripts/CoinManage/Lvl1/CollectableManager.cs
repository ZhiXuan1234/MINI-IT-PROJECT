using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CollectableManager : MonoBehaviour
{
    public int coinCount;
    public TMP_Text coinText;
    public GameObject door;
    private bool doorDestroyed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = ":" + coinCount.ToString() + "/8";

        if (coinCount == 8 && !doorDestroyed)
        {
            doorDestroyed = true;
            Destroy(door);
        }
    }
}
