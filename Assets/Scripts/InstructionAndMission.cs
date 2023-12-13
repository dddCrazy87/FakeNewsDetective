using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionAndMission : MonoBehaviour
{
    [SerializeField] private GameObject missionCanva, instructionCanva;
    [SerializeField] private Text missions, instructions;
    [SerializeField] private string[] Instructions = {
        "尋找電腦查看新聞",
        "前往A黨總統候選辦公室尋求本人說法",
        "調夜市的監視器看看Mr.柯是否有亂吐鹽酥雞",
        "",
    };
    
    [SerializeField] private string[] Missions = {
        "Mr.柯「言行不一致，裝模作樣」「覺得難吃亂吐鹽酥雞」",
        "Mr.柯亂吐鹹酥雞"
    };
}
