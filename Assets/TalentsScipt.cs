using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalentsScipt : MonoBehaviour
{
    public GameObject Talents;
    public Animator Anim;

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
            Anim.Play("Talents_End");
        }
    }
}
