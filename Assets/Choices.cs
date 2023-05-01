using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choices : MonoBehaviour{

    public GameObject TextBox;
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject Choice03;
    public int ChoiceMade;

    public void ChoiceOption1 () {
        TextBox.GetComponent<Text>().text = "You are in a place called The Room. This is a very dangerous place, Please be carful who you trust.";
        ChoiceMade = 1;
    }

    public void ChoiceOption2() {
        TextBox.GetComponent<Text>().text = "Who I am does not matter. In this place there are dangerous people, so you must be carful.";
        ChoiceMade = 2;
    }

    public void ChoiceOption3() {
        TextBox.GetComponent<Text>().text = "... I'm doing Good. We are in what we call The Room. This is a very dangerous place to be, so please be carful!";
        ChoiceMade = 3;
    }



    // Update is called once per frame
    void Update() {
        if (ChoiceMade >= 1) {
            Choice01.SetActive(false);
            Choice02.SetActive(false);
            Choice03.SetActive(false);
        }
    }
}
