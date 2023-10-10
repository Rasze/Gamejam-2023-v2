using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endgame : MonoBehaviour
{
    public KeyCode quitKey = KeyCode.E; // Voit vaihtaa t‰m‰n n‰pp‰imen tarpeidesi mukaan

    // Update-funktio suoritetaan joka ruutup‰ivitys
    void Update()
    {
        // Tarkista, onko pelaaja painanut lopetuspainiketta (esim. ESC)
        if (Input.GetKeyDown(quitKey))
        {
            QuitGame(); // Kutsu pelin lopettamismetodia
        }
    }

    // Metodi, joka lopettaa pelin ja palaa p‰‰valikkoon (voit muuttaa t‰m‰n tarpeidesi mukaan)
    public void QuitGame()
    {
        //Debug.Log("Peli loppui");
        QuitGame();
    }
}
