using Assets.Scrips;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStart : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.Destroy(SingleTone.GameConfig.previousLevel.gameObject);
            SingleTone.IsActive = true;
        }
    }
}
