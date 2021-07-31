using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowKeyObject : MonoBehaviour
{

    [SerializeField] private string SelectableTag = "ObjetoInteractuable";
    [SerializeField] private Material highlightMaterial;
    [SerealizeField] private Material defaultMaterial;

    public update()
    {
        selectRender selectionRender = GameObject.getComponent<Renderer>();
        if (SelectableTag)
        {
                if (selectionRender != defaultMaterial)
            {
                showObject();
            }
            else
            {
                DeselectObjetc();
            }
        }
    }
    public void showObject()
    {
                selectionRender.material = highlightMaterial;
    }
    public void DeselectObjetc()
    {
        selectionRender.material = defaultMaterial;
    }
}
