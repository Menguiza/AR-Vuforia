using System.Collections.Generic;
using UnityEngine;

public class InfoPackage : MonoBehaviour
{
    [SerializeField] private string id;
    [SerializeField] private List<Animator> infoPopUps = new List<Animator>();

    private Coroutine startedTask;

    public string ID
    {
        get => id.ToLower();
    }

    public void TurnOnPopUps()
    {
        if(startedTask != null) return;
        
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
