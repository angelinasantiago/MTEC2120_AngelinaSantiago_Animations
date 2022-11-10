using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMaterialButton : MonoBehaviour
{
    public GameObject cube;
    Button button;
    public Material newMaterial;

    // Start is called before the first frame update
    void OnEnable()
    {

        button = GetComponent<Button>();
        button.onClick.AddListener(ChangeMaterial);

    }

    void OnDisable()
    {
        button.onClick.RemoveListener(ChangeMaterial);

    }

    public void ChangeMaterial() 
    {
        Renderer rend = cube.GetComponent<Renderer>();
        rend.material = newMaterial;
    }

}
