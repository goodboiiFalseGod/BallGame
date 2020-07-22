using Assets.Scrips;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SingleTone.GameConfig._currentLvl++;
            SingleTone.IsActive = false;
        }
    }
}
