using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class TEXTBEHAVIOUR : MonoBehaviour
{
    public TextMeshProUgui texto; 
    // Start is called before the first frame update
    void Start()
    {
        texto.text="Bienvenido a recomendaciones musicales";
        texto.text="Y de peliculas tambien"
        texto.text="Elige una opcion"
        texto.text="A. Talking heads"
        texto.text="B. The Cure"
        texto.text="C. XTC"
        texto.text="D. Nirvana"
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            texto.text="Tu cancion es: Psycho Killer";
            texto.text="Tu pelicula es: The Joker";
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            texto.text="Tu cancion es: Lets go to bed";
            texto.text="Tu pelicula es: Pulp Fiction";
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            texto.text="Tu cancion es: Dear God";
            texto.text="Tu pelicula es: Las Virgenes Suicidas";
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            texto.text="Tu cancion es: Smells Like Teen Spirit";
            texto.text="Tu pelicula es: The Batman"
        }
    }
}
