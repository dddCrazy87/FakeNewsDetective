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
        "前往住家查看電腦裡第一則新聞",
        "前往A黨總統候選辦公室尋求本人說法",
        "調夜市的監視器看看Mr.柯是否有亂吐鹽酥雞",
        "前往住家查看電腦裡第二則新聞",
        "前往桃園市尋找專家確認影片真實性",
        "上網搜尋女王祖譜",
        "前往皇居訪問女王確認族譜真實性",
        "看電視搜尋女王行蹤",
        "秘密調查女王",
        "盜取Mr.X的屍體進行DNA分析",
        "回到住家分析結果",
        "到第35代女王紀念堂尋找線索",
        "回到住家分析結果",
    };
    
    [SerializeField] private string[] Missions = {
        "Mr.柯「言行不一致，裝模作樣」「覺得難吃亂吐鹽酥雞」",
        "Mr.柯亂吐鹹酥雞",
        "影片真實性",
        "確認皇室家庭組成",
        "確認女王是否為外星人"
    };
}
