using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInfo : MonoBehaviour
{
    [SerializeField] private List<InfoPackage> packages = new List<InfoPackage>();

    private Hashtable activePackage = new Hashtable();
    private bool active;
    private string id;

    private void Awake()
    {
        SetHashtable();
    }

    public void OnClick()
    {
        if(!activePackage.Contains(id)) return;

        InfoPackage package = (InfoPackage)activePackage[id];

        active = !active;
        
        if(active) package.TurnOnPopUps();
        else package.TurnOffPopUps();
    }

    public void SetId(string id)
    {
        this.id = id.ToLower();
        active = false;
    }

    private void SetHashtable()
    {
        foreach (InfoPackage item in packages)
        {
            activePackage.Add(item.ID.ToLower(), item);
        }
    }
}
