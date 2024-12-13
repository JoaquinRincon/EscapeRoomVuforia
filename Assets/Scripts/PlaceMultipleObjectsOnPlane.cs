using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

/// <summary>
/// For tutorial video, see my YouTube channel: <seealso href="https://www.youtube.com/@xiennastudio">YouTube channel</seealso>
/// How to use this script:
/// - Add ARPlaneManager to XROrigin GameObject.
/// - Add ARRaycastManager to XROrigin GameObject.
/// - Attach this script to XROrigin GameObject.
/// - Add the prefab that will be spawned to the <see cref="placedPrefab"/>.
/// 
/// Touch to place the <see cref="placedPrefab"/> object on the touch position.
/// Will only placed the object if the touch position is on detected trackables.
/// Will spawn a new object on the touch position.
/// Using Unity old input system.
/// </summary>
[HelpURL("https://youtu.be/HkNVp04GOEI")]
public class PlaceMultipleObjectsOnPlaneOldInputSystem : MonoBehaviour {
    
    public GameObject placedObjectPrefab;
    private GameObject spawnedObject;
    private ARRaycastManager raycastManager;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();


    void Awake()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
        // Detectar el plano y colocar el objeto
        if (spawnedObject == null && raycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.PlaneWithinBounds))
        {
            Pose hitPose = hits[0].pose;
            spawnedObject = Instantiate(placedObjectPrefab, hitPose.position, hitPose.rotation);
        }
        
        // Detectar toque en el objeto
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Touch touch = Input.GetTouch(0);
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.transform.gameObject == spawnedObject)
                {


                    Destroy(spawnedObject);
                    spawnedObject = null; // Reiniciar la referencia
                    
                }
            }
        }
    }
}
