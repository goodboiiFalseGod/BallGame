using Assets.Scrips;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class GameConfig : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Level> LevelsList;
    public GameObject player;

    public int _currentLvl
    {
        get { return CurrentLvl; }
        set 
        {
            CurrentLvl = value; 

            if(CurrentLvl >= LevelsList.Count - 1)
            {
                CurrentLvl = 0;
            }

            ToNextLvl();
        }
    }
    public int CurrentLvl;
    public Level currentLevel;
    public Level nextLevel;
    public Level previousLevel;

    private void Start()
    {
        SingleTone.GameConfig = this;
        StartGame();
    }

    void StartGame()
    {
        currentLevel = GameObject.Instantiate(LevelsList[CurrentLvl], Vector3.zero, LevelsList[CurrentLvl].transform.rotation);
        Vector3 targetPos = new Vector3(player.transform.position.x, player.transform.position.y - 2, player.transform.position.z);
        Vector3 currentPos = currentLevel.start.transform.position;
        Vector3 offset = targetPos - currentPos;

        currentLevel.transform.position += offset;
    }

    void ToNextLvl()
    {
        previousLevel = currentLevel;
        currentLevel = GameObject.Instantiate(LevelsList[_currentLvl], Vector3.zero, LevelsList[_currentLvl].transform.rotation);
        Vector3 targetPos = new Vector3(previousLevel.finish.transform.position.x, previousLevel.finish.transform.position.y - 25, previousLevel.finish.transform.position.z);
        Vector3 currentPos = currentLevel.start.transform.position;
        Vector3 offset = targetPos - currentPos;

        currentLevel.transform.position += offset;

        nextLevel = null;

        Vector3 dir = currentLevel.start.transform.position - player.transform.position;
        player.GetComponent<Rigidbody>().velocity = dir * 2;
    }
}
