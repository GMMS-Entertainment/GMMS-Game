using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopScript : MonoBehaviour
{
    public GameObject Shop;
    public Animator Anim;

    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    void Update()
    {

    }
    public void OpenShop() //Öppnar Shoppen
    {
        if (Shop != null)
        {
            bool isActive = Shop.activeSelf;
            Shop.SetActive(!isActive);
        }
    }
}
