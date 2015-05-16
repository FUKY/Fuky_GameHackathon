using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnviromentController : MonoSingleton<EnviromentController> {

    public float temparature;  //giam % mau
    public float speedEnviroment; //giam % toc do
    public float spawner; //% toc do item
    public Sprite imageCurrent;
    public Sprite[] images;
    private Dictionary<EnviromentState, Sprite> dicEnviroment;
    public EnviromentState stateCurrent;

    public void Start()
    {
        SetData();
        stateCurrent = EnviromentState.SUNNY;
    }

    public void SetData()
    {
        dicEnviroment = new Dictionary<EnviromentState, Sprite>();
        dicEnviroment.Add(EnviromentState.CLOUDY, images[0]);
        dicEnviroment.Add(EnviromentState.SUNNY, images[1]);
        dicEnviroment.Add(EnviromentState.WINDY, images[2]);
    }

    public void ChangeEnviroment(EnviromentState state)
    {
        imageCurrent = dicEnviroment[state];
        switch(state)
        {
            case EnviromentState.SUNNY:
                {
                    temparature = -0.2f;
                    speedEnviroment = 0.2f;
                    spawner = 0.3f;
                    break;
                }
            case EnviromentState.CLOUDY:
                {
                    temparature = -0.0f;
                    speedEnviroment = 0.0f;
                    spawner = 0.0f;
                    break;
                }
            case EnviromentState.WINDY:
                {
                    temparature = 0.0f;
                    speedEnviroment = 0.2f;
                    spawner = -0.2f;
                    break;
                }
        }
    }

    public void RandomState()
    {
        int index = Random.Range(0, 2);
        switch(index)
        {
            case 0:
                {
                    ChangeEnviroment(EnviromentState.WINDY);
                    break;
                }
            case 1:
                {
                    ChangeEnviroment(EnviromentState.CLOUDY);
                    break;
                }
            case 2:
                {
                    ChangeEnviroment(EnviromentState.SUNNY);
                    break;
                }
        }
    }
}
