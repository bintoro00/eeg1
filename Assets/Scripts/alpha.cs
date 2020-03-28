using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class alpha : MonoBehaviour
{
    private Image img;
    public Slider slider;

    void Start()
    {
        img = GetComponent<Image>();
        slider.value = 0;
        img.color = new Color(255, 255, 255, slider.value);
    }
    void Update(){
        
    }
    public void Alfa(){
        img.color = new Color(255, 255, 255, slider.value);
    }
}
