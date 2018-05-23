using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBehaviour : MonoBehaviour
{

    public GameAction HealthAction;
    public Image HealthBarImage;
    
    
    private void Start()
    {
        HealthAction.Call(HealthBarImage);
    }
}
