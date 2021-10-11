using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
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

                if (EventSystem.current.currentSelectedGameObject != null)
                {
                    if (EventSystem.current.currentSelectedGameObject != lugarDelMapa)
                    {
                        lugarDelMapa.GetComponent<Button>().Select();
                        i = 100;
                    }
                    else
                    {
                        lugarDelMapa.SetActive(false);
                        lugarDelMapa.SetActive(true);
                        lugarDelMapa.GetComponent<Button>().Select();
                        i = 100;
                    }
                }
                else
                {
                    lugarDelMapa.GetComponent<Button>().Select();
                }
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
