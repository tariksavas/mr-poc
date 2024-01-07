using System.Collections.Generic;
using UnityEngine;

namespace Runtime
{
    public class Wall : MonoBehaviour
    {
        [SerializeField] 
        private MeshRenderer _meshRenderer;
        [SerializeField] 
        private List<Material> _materials = new();

        private int _activeMaterialIndex = 0;
    
        public void ChangeMaterial()
        {
            _activeMaterialIndex = ++_activeMaterialIndex % _materials.Count;
        
            _meshRenderer.material = _materials[_activeMaterialIndex];
        }
    }
}
