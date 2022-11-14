using UnityEngine;

public abstract class Card : ScriptableObject
{
    public string name;
    public string definition;

    public Sprite artwork;

    public int ressource;

    
    public abstract void Play(Manager manager);
    public abstract void Action(Manager manager);
    

}