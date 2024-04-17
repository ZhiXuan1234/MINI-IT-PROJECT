using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2CoinCollect : MonoBehaviour
{
    public Level2CoinCollect cm;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            CoinSoundManager.instance.coinssource.PlayOneShot(CoinSoundManager.instance.CoinSound);
            Destroy(other.gameObject);
            cm.coinCount++;
        }
    }

}
