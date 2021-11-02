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
        Button primerObjeto = transform.GetChild(0).GetComponent<Button>();
        if (primerObjeto.interactable)
        {
            if (EventSystem.current.currentSelectedGameObject == primerObjeto.GetComponent<Selectable>())
            {
                primerObjeto.interactable = false;
                primerObjeto.interactable = true;
                primerObjeto.Select();
            }
            else
            {
                primerObjeto.Select();
            }
        }
    }

    public void ActualizarMapa()
    {
        taller.GetComponent<Button>().interactable = Estados.DevolverEstado("haveKey");
        torneo.GetComponent<Button>().interactable = Estados.DevolverEstado("checkedCar");
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
