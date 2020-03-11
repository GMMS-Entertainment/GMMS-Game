using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalentsScipt : MonoBehaviour
{
    public GameObject Talents;
    public Animator AniTalents;

    public void OpenTalents() //Öppnar talents 
    {
        if (Talents != null) 
        {
            bool isActive = Talents.activeSelf;
            Talents.SetActive(!isActive);
        }
    }
}
