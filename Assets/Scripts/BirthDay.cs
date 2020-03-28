using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class BirthDay : MonoBehaviour {

    public Dropdown dropDownYear;
    public Dropdown dropDownMonth;
    public Dropdown dropDownDay;

    int year;
    int month;
    int day;

    // Use this for initialization
    void Start () {

        if (dropDownYear) {
            dropDownYear.ClearOptions();    //現在の要素をクリアする
            List<string> list = new List<string>();
            for (int i = 1960; i < 2002; i++) {
                if (i == 1960) {
                    list.Add ("年");
                } else {
                    list.Add (i.ToString () + "年");
                }
            }
            dropDownYear.AddOptions(list);  //新しく要素のリストを設定する
            dropDownYear.value = 0;         //デフォルトを設定(0～n-1)
        }

        if (dropDownMonth) {
            dropDownMonth.ClearOptions();    //現在の要素をクリアする
            List<string> list = new List<string>();
            for (int i = 0; i <= 12; i++) {
                if (i == 0) {
                    list.Add ("月");
                } else {
                    list.Add (i.ToString () + "月");
                }
            }
            dropDownMonth.AddOptions(list);  //新しく要素のリストを設定する
            dropDownMonth.value = 0;         //デフォルトを設定(0～n-1)
        }

        if (dropDownDay) {
            dropDownDay.ClearOptions();    //現在の要素をクリアする
            List<string> list = new List<string>();
            for (int i = 0; i <= 31; i++) {
                if (i == 0) {
                    list.Add ("日");
                } else {
                    list.Add (i.ToString () + "日");
                }
            }
            dropDownDay.AddOptions(list);  //新しく要素のリストを設定する
            dropDownDay.value = 0;         //デフォルトを設定(0～n-1)
        }

    }

    // Update is called once per frame
    void Update () {

    }

}