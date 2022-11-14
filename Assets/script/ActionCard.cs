using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New ActionCard", menuName = "Cards/ActionCard")]
public class ActionCard : Card
{
    public bool isDestroy = true;
    public bool isRevive;
    public bool isRestocking;

    public override void Play(Manager manager) {
       
        
    }

    public override void Action(Manager manager) { 
        if (isDestroy == true) {
            Destroy(GameObject.Find("Content J2"));
            Instantiate(GameObject.Find("Content J2"));
        }

        if (isRevive == true)
        {
            // instancie une carte aléatoire
        }

        if (isRestocking == true)
        {
            //restaure les pts de mana
        }
    }
}
    