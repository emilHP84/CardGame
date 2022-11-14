using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardUI : MonoBehaviour
{
    public EntityPlayableCard entityPlayableCard;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI definitionText;

    public Image artWorkImage;

    public TextMeshProUGUI ressourceText;
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI moveText;
    public TextMeshProUGUI defenceText;
    void Start() {
        nameText.text = entityPlayableCard.name;
        definitionText.text = entityPlayableCard.definition;
        
        artWorkImage.sprite = entityPlayableCard.artwork;

        ressourceText.text = entityPlayableCard.ressource.ToString();
        attackText.text = entityPlayableCard.attack.ToString();
        moveText.text = entityPlayableCard.move.ToString();
        defenceText.text = entityPlayableCard.defence.ToString();
    }
}
