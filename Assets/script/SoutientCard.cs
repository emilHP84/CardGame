using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New SoutientCard", menuName = "Cards/SoutientCard")]
public class SoutientCard : Card
{

    public bool moveBonus;
    public int move;

    public bool defenceBonus;
    public int defence;

    public bool attackBonus;
    public int attack;

    public override void Play(Manager manager)
    {

    }

    public override void Action(Manager manager)
    {
        if (moveBonus == true)
        {
            //augmente la vitesse
        }
        if (defenceBonus == true)
        {
            // augmente la def
        }

        if (attackBonus == true)
        {
            //augmente l'attaque
        }
    }
}
