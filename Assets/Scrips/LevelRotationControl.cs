using Assets.Scrips;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRotationControl : MonoBehaviour
{
    // Start is called before the first frame update
    bool isPressed = false;

    Vector2 currentPos;
    Vector2 previousPos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(SingleTone.IsActive)
        {
            float YOffset = 0;
            float XOffset = 0;

            if (Input.GetMouseButtonDown(0))
            {
                previousPos = Input.mousePosition;
            }

            if (Input.GetMouseButton(0))
            {
                currentPos = Input.mousePosition;

                YOffset = currentPos.y - previousPos.y;
                XOffset = currentPos.x - previousPos.x;

                previousPos = currentPos;

                Debug.Log(previousPos.ToString());
            }

            float ZAngle = (XOffset / Screen.width) * 25;
            float XAngle = (YOffset / Screen.height) * 25;

            //SingleTone.GameConfig.currentLevel.transform.rotation.x = YOffset;
            //SingleTone.GameConfig.currentLevel.transform.rotation.z = XOffset;

            //SingleTone.GameConfig.currentLevel.transform.Rotate(XAngle, 0, -ZAngle);
            SingleTone.GameConfig.currentLevel.transform.RotateAround(transform.position, new Vector3(1, 0, 0), XAngle);
            SingleTone.GameConfig.currentLevel.transform.RotateAround(transform.position, new Vector3(0, 0, 1), -ZAngle);
        }

        transform.SetParent(SingleTone.GameConfig.currentLevel.transform);
    }   
}
