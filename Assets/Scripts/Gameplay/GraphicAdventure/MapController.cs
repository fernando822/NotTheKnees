using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MapController : MonoBehaviour
{
    [SerializeField] GameObject casa;
    [SerializeField] GameObject taller;
    [SerializeField] GameObject torneo;

    private void OnEnable()
    {
        ActualizarMapa();
        GameObject primerObjeto = transform.GetChild(0).gameObject;
        if (EventSystem.current.currentSelectedGameObject == primerObjeto && primerObjeto.activeSelf)
        {
            primerObjeto.GetComponent<Button>().interactable = false;
            primerObjeto.GetComponent<Button>().interactable = true;
            primerObjeto.GetComponent<Button>().Select();
        }
        else
        {
            primerObjeto.GetComponent<Button>().Select();
        }
        
    }

    public void ActualizarMapa()
    {
        if(Estados.DevolverEstado("haveKey"))
            taller.GetComponent<Button>().interactable = true;
        else
            taller.GetComponent<Button>().interactable = false;

        if(Estados.DevolverEstado("checkedCar"))
            torneo.GetComponent<Button>().interactable = true;
        else
            torneo.GetComponent<Button>().interactable = false;

    }
    // Start is called before the first frame update
    void Start()
    {
        ActualizarMapa();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
