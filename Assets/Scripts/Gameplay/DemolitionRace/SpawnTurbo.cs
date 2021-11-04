using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTurbo : MonoBehaviour
{
    [SerializeField] GameObject Turbo;

    [SerializeField] Vector2 X;
    [SerializeField] Vector2 Z;
    [SerializeField] float delay = 5;
    public static int contadorTurbos = 0;

    float time;

    void Start()
    {
        time = delay;
    }

    void FixedUpdate()
    {
        spawn();
    }

    void spawn()
    {
        if (time <= 0)
        {
            var position = new Vector3(Random.Range(X.x, X.y), 1.5f, Random.Range(Z.x, Z.y));

            if(contadorTurbos < 10)
            {
                Instantiate(Turbo, position, Quaternion.identity);
                contadorTurbos++;
            }

            time = delay;
        }
        else
            time -= Time.fixedDeltaTime;
    }
}
