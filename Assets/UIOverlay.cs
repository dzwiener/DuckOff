using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIOverlay : MonoBehaviour
{
  public TextMeshProUGUI HumanScore;
  public TextMeshProUGUI DuckScore;
  public string HumanScoreStr;
  public string DuckScoreStr;


  void Start()
  {
    UpdateScoreDisplay();
  }


  public void UpdateScoreDisplay()
  {
    HumanScore.text = HumanScoreStr;
    DuckScore.text = DuckScoreStr;
  }

  public void setHumanScore(string score)
  {
    HumanScoreStr = "Human: \n" + score;
    UpdateScoreDisplay();
  }

  public void setDuckScore(string score)
  {
    DuckScoreStr = "Duck: \n" + score;
    UpdateScoreDisplay();
  }
}
