using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapController : MonoBehaviour
{

    private void OnEnable()
    {
        GameObject lugarDelMapa;
        for(int i = 0; i < 3; i++)
        {
            lugarDelMapa = transform.GetChild(i).gameObject;
            if (lugarDelMapa.activeSelf)
            {
                lugarDelMapa.GetComponent<Button>().Select();
                i = 100;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
