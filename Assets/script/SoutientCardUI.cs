using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SoutientCardUI : MonoBehaviour
{
    public SoutientCard soutientCard;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI definitionText;

    public Image artWorkImage;

    public TextMeshProUGUI ressourceText;
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI moveText;
    public TextMeshProUGUI defenceText;
    void Start() {
        nameText.text = soutientCard.name;
        definitionText.text = soutientCard.definition;
        
        artWorkImage.sprite = soutientCard.artwork;

        ressourceText.text = soutientCard.ressource.ToString();
        attackText.text = soutientCard.attack.ToString();
        moveText.text = soutientCard.move.ToString();
        defenceText.text = soutientCard.defence.ToString();
    }
}
