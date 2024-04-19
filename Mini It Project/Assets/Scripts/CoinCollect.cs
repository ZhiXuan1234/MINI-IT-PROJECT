using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public CollectableManager cm;
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
