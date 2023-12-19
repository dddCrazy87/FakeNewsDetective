using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "InstructionAndMission", menuName = "ScriptableObj/InstructionAndMission")]
public class InstructionAndMission : ScriptableObject {
    public int instructionID = 0;
    public int missionLV = 0;
    public int gameLvId = 1;
    
    public string[] Instructions = {
        "前往住家查看電腦裡第一則新聞",
        "前往A黨總統候選辦公室尋求本人說法",
        "調夜市的監視器看看Mr.柯是否有亂吐鹽酥雞",
        "前往住家查看電腦裡第二則新聞",
        "前往桃園市尋找專家確認影片真實性",
        "回家上網搜尋相關資料",
        "回去找影片專家再次確認影片真實性",
        "前往皇居訪問女王確認族譜真實性",
        "回家搜尋女王行蹤的線索",
        "前往七星山秘密調查女王和Mr.X",
        "盜取Mr.X的屍體進行DNA分析",
        "回到住家分析結果",
        "到第35代女王紀念堂尋找線索",
        "回到住家分析結果"
    };
    
    public string[] Missions = {
        "確認Mr.柯是否「言行不一致，裝模作樣」",
        "確認Mr.柯是否覺得鹽酥雞難吃",
        "確認Mr.柯是否亂吐鹹酥雞",
        "確認影片真實性",
        "確認女王是否為外星人",
        "確認皇室家庭組成"
    };

    public string[] SetMission() {
        if(missionLV == 0) {
            string[] mission = { "" };
            return mission;
        }
        else if(missionLV == 1) {
            string[] mission = {
                Missions[0],Missions[1],Missions[2]
            };
            return mission;
        }
        else if(missionLV == 2) {
            string[] mission = {
                Missions[3],Missions[4]
            };
            return mission;
        }
        else if(missionLV == 3) {
            string[] mission = {
                Missions[3],Missions[4],Missions[5]
            };
            return mission;
        }
        else{
            string[] mission = { "loading missions error" };
            return mission;
        }
    }

    public string SetInstruction() {
        return Instructions[instructionID];
        // return "123";
    }

    public bool[] finshedMission = {false, false, false};
}
