using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WallHandler : MonoBehaviour
{
    [SerializeField] 
    private OVRSceneManager _ovrSceneManager;

    private List<Wall> _walls = new List<Wall>();

    private void Awake()
    {
        _ovrSceneManager.SceneModelLoadedSuccessfully += OnSceneModelLoadedSuccessfully;
        
        Debug.LogError($"WallHandler Awake");
    }

    private void OnSceneModelLoadedSuccessfully()
    {
        StartCoroutine(HandleWalls());
    }

    private IEnumerator HandleWalls()
    {
        yield return new WaitForEndOfFrame();
        
        _walls = FindObjectsOfType<Wall>().ToList();
    }

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            _walls.ForEach(x=> x.ChangeMaterial());
        }
    }

    private void OnDestroy()
    {
        _ovrSceneManager.SceneModelLoadedSuccessfully -= OnSceneModelLoadedSuccessfully;
    }
}
