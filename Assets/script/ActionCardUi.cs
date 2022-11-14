using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ActionCardUi : MonoBehaviour
{
    public ActionCard actioncard;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI definitionText;

    public Image artWorkImage;

    public TextMeshProUGUI ressourceText;
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI moveText;
    public TextMeshProUGUI defenceText;
    void Start() {
        nameText.text = actioncard.name;
        definitionText.text = actioncard.definition;
        
        artWorkImage.sprite = actioncard.artwork;

        ressourceText.text = actioncard.ressource.ToString();
        attackText.text = actioncard.isDestroy.ToString();
        moveText.text = actioncard.isRestocking.ToString();
        defenceText.text = actioncard.isRevive.ToString();
    }
}
