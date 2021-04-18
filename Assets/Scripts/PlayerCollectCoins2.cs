using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCollectCoins2 : MonoBehaviour
{

    public int points = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnGUI()
    {
        GUI.Label(new Rect(40, 40, 240, 80), "Score:  " + points);
    }



}

