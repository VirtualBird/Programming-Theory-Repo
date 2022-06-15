using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayResourcesUI : MonoBehaviour
{
    //So need to be able to grab stuff from resource manager
    public GameObject ResourceManager;

    
    public Text StoneText;
    public Text WoodText;
    public Text WoodSpearText;

    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        //Update UI on each mouse click
        if (Input.GetButtonDown("Fire1"))
        {
            UpdateUI();
        }
    }

    //  Update's the UI whenever its called
    public void UpdateUI() // ABSTRACTION
    {
        StoneText.text = "Stone: " + ResourceManager.GetComponent<StoneResource>().amount;
        WoodText.text = "Wood: " + ResourceManager.GetComponent<WoodResource>().amount;
        WoodSpearText.text = "Wood Spear: " + ResourceManager.GetComponent<WoodSpearResource>().amount;
    }

}
