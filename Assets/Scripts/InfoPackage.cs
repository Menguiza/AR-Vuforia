using System.Collections.Generic;
using UnityEngine;

public class InfoPackage : MonoBehaviour
{
    [SerializeField] private string id;
    [SerializeField] private GameObject principal;
    [SerializeField] private List<Animator> infoPopUps = new List<Animator>();

    public bool IsActive
    {
        get => principal.activeSelf;
    }
    
    public string ID
    {
        get => id.ToLower();
    }

    public void TurnOnPopUps()
    {
        foreach (Animator item in infoPopUps)
        {
            item.gameObject.SetActive(true);
        }
    }

    public void TurnOffPopUps()
    {
        foreach (Animator item in infoPopUps)
        {
            item.gameObject.SetActive(false);
        }
    }
}
