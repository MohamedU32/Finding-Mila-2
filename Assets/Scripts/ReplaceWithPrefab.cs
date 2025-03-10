using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ReplaceWithPrefab : MonoBehaviour
{
    [SerializeField] private GameObject newPrefab; // The new prefab to replace with

    [ContextMenu("Replace Models")]
    private void Start()
    {
        GameObject[] oldModels = GameObject.FindGameObjectsWithTag("Old_Box");

        foreach (GameObject oldModel in oldModels)
        {
            GameObject newObject = (GameObject)PrefabUtility.InstantiatePrefab(newPrefab);
            newObject.transform.position = oldModel.transform.position;
            // newObject.transform.rotation = oldModel.transform.rotation;

            DestroyImmediate(oldModel);
        }
        Debug.Log("Replacement completed!");
    }
}
