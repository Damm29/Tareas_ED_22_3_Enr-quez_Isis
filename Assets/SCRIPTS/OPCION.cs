using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{

    public TextMeshProUGUI usser_option;
    public TMP_InputField usser_input;

    public void opcionmusical()
    {

        usser_option.text = usser_input.text;

    }
}
