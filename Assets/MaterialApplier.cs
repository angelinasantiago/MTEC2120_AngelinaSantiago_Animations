using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialApplier : MonoBehaviour
{
    public Material originalMaterial;
    public Material otherMaterial;

    private Renderer rend;

    // Start is called before the first frame update
    public void ApplyOriginal()
    {
        if (rend == null) return;
        rend.material = originalMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        rend = GetComponent<Renderer>();
    }
}
