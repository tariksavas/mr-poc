using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] 
    private MeshRenderer _meshRenderer;
    [SerializeField] 
    private List<Material> _materials = new List<Material>();

    private int _activeMaterialIndex = 0;
    
    public void ChangeMaterial()
    {
        _activeMaterialIndex = ++_activeMaterialIndex % _materials.Count;
        
        _meshRenderer.material = _materials[_activeMaterialIndex];
    }
}
