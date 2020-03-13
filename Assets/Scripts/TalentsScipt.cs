using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalentsScipt : MonoBehaviour
{
    public GameObject Talents;
    public Animator Anim;
    public bool talent1Learnt = false;

    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    void Update()
    {
        
    }
    public void OpenTalents() //Öppnar talents 
    {
        if (Talents != null) 
        {
            bool isActive = Talents.activeSelf;
            Talents.SetActive(!isActive);
        }
    }

    public void SelectTalent1() //
    {
        talent1Learnt = true;
        Debug.Log("OK");
    }

}
