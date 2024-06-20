using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class logic_managers : MonoBehaviour
{
   public TextMeshProUGUI uiscore;
   public int player_score=0;

    [ContextMenu("Increse score")]
    public void addscore()
    {
        player_score++;
        uiscore.text=player_score.ToString();

    }

}
