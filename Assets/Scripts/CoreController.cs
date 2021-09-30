using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;


public class CoreController : MonoBehaviour
{
    void Awake()
    {
       
    }

    private GameObject InstantiateObjByURL(string url,Vector3 pos,Quaternion rot)
    {
        return Instantiate(Resources.Load<GameObject>(url), pos, rot);
    }

    // Start is called before the first frame update
    void Start()
    {
        GameEventDispatcher.GetInstance().AddEventListener(BaseGameEvent.GameEventType.GAME_PAUSE, OnGamePause);
        GameEventDispatcher.GetInstance().AddEventListener(BaseGameEvent.GameEventType.GAME_CONTINUE, OnGameContinue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {

    }

    void OnDestroy()
    {
        GameEventDispatcher.GetInstance().RemoveEventListener(BaseGameEvent.GameEventType.GAME_PAUSE, OnGamePause);
        GameEventDispatcher.GetInstance().RemoveEventListener(BaseGameEvent.GameEventType.GAME_CONTINUE, OnGameContinue);
    }

    void OnGamePause(BaseGameEvent gEvent)
    {
        
    }

    void OnGameContinue(BaseGameEvent gEvent)
    {

    }
}
