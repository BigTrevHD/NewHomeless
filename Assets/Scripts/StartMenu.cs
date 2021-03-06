﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    GraphicRaycaster m_Raycaster;
    PointerEventData m_PointerEventData;
    EventSystem m_EventSystem;
    private GameObject currText;
    public Image helpMenu;

    private int startSize;
    private int maxSize;

    void Start()
    {
        //Fetch the Raycaster from the GameObject (the Canvas)
        m_Raycaster = GetComponent<GraphicRaycaster>();
        //Fetch the Event System from the Scene
        m_EventSystem = GetComponent<EventSystem>();
    }

    void Update()
    {
        
        
            
            //Set up the new Pointer Event
            m_PointerEventData = new PointerEventData(m_EventSystem);
            //Set the Pointer Event Position to that of the mouse position
            m_PointerEventData.position = Input.mousePosition;

            //Create a list of Raycast Results
            List<RaycastResult> results = new List<RaycastResult>();

            //Raycast using the Graphics Raycaster and mouse click position
            m_Raycaster.Raycast(m_PointerEventData, results);
            
            {
                //For every result returned, output the name of the GameObject on the Canvas hit by the Ray
                foreach (RaycastResult result in results)
                {
                    if (result.gameObject.layer == LayerMask.NameToLayer("UIText"))
                    {
                        Debug.Log("Hit " + result.gameObject.name);
                        currText = result.gameObject;
                    
                }
                    else
                {
                    currText = null;
                }
                }
            }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (currText.gameObject.CompareTag("Start"))
            {
                SceneManager.LoadScene(1);
            }
            if (currText.gameObject.CompareTag("Help"))
            {
                helpMenu.gameObject.SetActive(true);
            }
        }
    }
   public void CloseMenu()
    {
        helpMenu.gameObject.SetActive(false);
    }

}

