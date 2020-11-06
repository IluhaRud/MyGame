using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTimeOfDayButton : MonoBehaviour
{
    public Text textOfButton;
    public GameObject _light;
    public List<GameObject> streetLights = new List<GameObject>();
    public bool IsEvening;

    private void Start()
    {
        IsEvening = false;
        textOfButton.text = "Afternoon";
        streetLights.AddRange(GameObject.FindGameObjectsWithTag("StreetLight"));
    }
    public void ChangeTimeOfDay()
    {
        if (IsEvening == false)
        {
            textOfButton.text = "Evening";
            _light.gameObject.SetActive(true);
            for (int i = 0; i < streetLights.Count; i++)
                streetLights[i].transform.GetChild(1).gameObject.SetActive(false);
            IsEvening = true;
            return;
        }

        if (IsEvening == true)
        {
            textOfButton.text = "Afternoon";
            _light.gameObject.SetActive(false);
            for (int i = 0; i < streetLights.Count; i++)
                streetLights[i].transform.GetChild(1).gameObject.SetActive(true);
            IsEvening = false;
            return;
        }
    }

}  


