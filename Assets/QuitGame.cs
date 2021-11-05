using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public int countDown;
    // Start is called before the first frame update
    void Start()
    {
        countDown = 10;
        StartCoroutine(SalirJuego());
    }

    IEnumerator SalirJuego()
    {
        yield return new WaitForSecondsRealtime(1);
        countDown--;
        StartCoroutine(SalirJuego());
        if (countDown == 0)
            Application.Quit();
    }
}
