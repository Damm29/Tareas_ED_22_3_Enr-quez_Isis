using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        texto.text = "Ingresa Opción";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
      {
          texto.text="Tu canción es Psycho Killer";
      }
      if (Input.GetKeyDown(KeyCode.B))
      {
          texto.text="Tu canción es Lullaby";
      }
      if (Input.GetKeyDown(KeyCode.C))
      {
          texto.text="Tu canción es Dear God";
      }
      if (Input.GetKeyDown(KeyCode.D))
      {
          texto.text="Tu canción es Smells Like Teen Spirit";
      }
    }
}

