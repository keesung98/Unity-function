using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
 
public class SliderTimer : MonoBehaviour
{
    Slider slTimer;
    float fSliderBarTime;

    private int speed=10;
    void Start()
    {
        slTimer = GetComponent<Slider>();
    }
 
    void Update()
    {
        if (slTimer.value == 100.0f)
        {
            slTimer.value =0.0f;
        }
        else
        {
            // 시간이 변경한 만큼 slider Value 변경을 합니다.
            slTimer.value =slTimer.value+speed*(Time.deltaTime);
        }
    }
}