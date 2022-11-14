using System;
using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

[CreateAssetMenu(fileName = "New CreatureCard", menuName = "Cards/EntityCard")]
public class EntityPlayableCard : Card
{
    public int attack;
    public int defence;
    public int move;
    
    [SerializeField] private int hp;
    [SerializeField] private int hpmax;


    public override void Play(Manager manager) {
        
    }

    public override void Action(Manager manager) {
        
    }
    
    public void UpdateHealth() {
        hp = 10 + defence;
        
        if (hp <= 0) {
            Destroy(this.GameObject());
        }

    }
    
    public void TakeDamage(int damages) {
        damages = attack;
        hp -= damages;
        UpdateHealth();
    }

    public void Heal(int heal) {
        heal = 2;
        hp += heal;
        UpdateHealth();
    }
    
}