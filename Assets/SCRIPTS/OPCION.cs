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
      if (Input.GetKeyDown(KeyCode.A))
      {
          usser_input.text="Tu canción es Psycho Killer";
      }
      if (Input.GetKeyDown(KeyCode.B))
      {
          usser_input.text="Tu canción es Lullaby";
      }
      if (Input.GetKeyDown(KeyCode.C))
      {
          usser_input.text="Tu canción es Dear God";
      }
      if (Input.GetKeyDown(KeyCode.D))
      {
          usser_input.text="Tu canción es Smells Like Teen Spirit";
      }

    }
    public void Reset() 
    {
        usser_input.text="";
    }
}