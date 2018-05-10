using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject SpotLight;
    public float TimeSeccond;
	// Use this for initialization
	void Start ()
    {
        //最初からライトは消しておく
        SpotLight.SetActive(false);

    }

    // Update is called once per frame
    void Update ()
    {
        float TimeSeccond = 0.0f;
        //Lを押した時ライトを付ける
		if(Input.GetKeyDown(KeyCode.L)==true)
        {
            SpotLight.SetActive(true);
            //ライトを3秒後に自動で消す
        }

        //Lを話した時ライトを消す
        if(Input.GetKeyDown(KeyCode.Space)==true)
        {
            SpotLight.SetActive(false);
        }
    }
}
