using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Dialog", menuName = "ScriptableObj/Dialog")]
public class Dialog : ScriptableObject {
    public Dictionary<string, List<KeyValuePair<int, string>>> dialogContent = new(){
        { "KP", new List<KeyValuePair<int, string>> {
            { new KeyValuePair<int, string>(1, "Mr.柯，你不是說不可以魚肉鄉民嗎，那為什麼還接受攤商的贈禮呢？")}, 
            { new KeyValuePair<int, string>(2, "不是啊，我想是這樣啦，") },
            { new KeyValuePair<int, string>(2, "人家很熱心要送你，我拒絕再拒絕，這樣不太好，所以就收下了。") },
            { new KeyValuePair<int, string>(2, "有人說我言行不一致，咳，我想是這樣啦，做人有時候也要懂得謙讓，") },
            { new KeyValuePair<int, string>(2, "總不可能人家一送過來，我就說喔好好好，我剛好肚子餓想吃吧。") },
            { new KeyValuePair<int, string>(2, "所以我想這題是這樣啦，") },
            { new KeyValuePair<int, string>(2, "人家好意我們會收下，但是我不是要到處騙吃騙喝，") },
            { new KeyValuePair<int, string>(2, "所以我才說我們不可以魚肉鄉民。") },
            { new KeyValuePair<int, string>(1, "那關於吐鹽酥雞的事？") },
            { new KeyValuePair<int, string>(2, "咳，我這個人對吃從不挑食，") },
            { new KeyValuePair<int, string>(2, "我以前是外科加護病房醫師，根本沒什麼時間吃午餐，") },
            { new KeyValuePair<int, string>(2, "時間緊迫，那個病患快死了，哪有可能等你吃完便當後再來照顧，") },
            { new KeyValuePair<int, string>(2, "所以我都很快速的把便當往嘴裡塞，反正吃進都是營養，蛋白質。") },
            { new KeyValuePair<int, string>(2, "我常說一個故事，") },
            { new KeyValuePair<int, string>(2, "就是有一次我和以前台大的朋友一起參加一個聚會，一個人一餐要一萬塊，") },
            { new KeyValuePair<int, string>(2, "然後第二天早上我上廁所，我看著馬桶，這就是我昨天吃的一萬塊，") },
            { new KeyValuePair<int, string>(2, "跟我平常吃的拉出來一樣。") },
            { new KeyValuePair<int, string>(2, "所以這題是這樣啦，不管吃什麼，反正拉出來都一樣，所以我基本不挑食，") },
            { new KeyValuePair<int, string>(2, "至於因為難吃吐鹽酥雞，我想是不可能啦。") },
            { new KeyValuePair<int, string>(1, "了解，謝謝Mr.柯！") },
            { new KeyValuePair<int, string>(1, "......") },
            { new KeyValuePair<int, string>(1, "不過，在這個假消息滿天飛的年代，我也不能相信一時的片面說詞") },
            { new KeyValuePair<int, string>(1, "我決定去看一下夜市的監視器，再確認Mr.柯是不是真的沒有亂丟鹹酥雞") },
            { new KeyValuePair<int, string>(2, "好啦，有你這樣的年輕人齁，很好啦。") },
            { new KeyValuePair<int, string>(2, "不要被現在的媒體騙了，要多多查證證據，這樣台灣才會進步啦") },
            { new KeyValuePair<int, string>(1, "好的，謝謝Mr.柯！") }
        }},
        { "MainSelf", new List<KeyValuePair<int, string>> {
            { new KeyValuePair<int, string>(1, "原來Mr.柯沒有亂丟鹹酥雞") },
            { new KeyValuePair<int, string>(1, "所以，這是一個假新聞！") }
        }},
        { "VideoProfesser1", new List<KeyValuePair<int, string>> {
            { new KeyValuePair<int, string>(1, "你好，請你幫我鑑定一下這部影片是否為真？") },
            { new KeyValuePair<int, string>(2, "好的，沒問題") },
            { new KeyValuePair<int, string>(2, "我看一下喔...") },
            { new KeyValuePair<int, string>(2, "呃，你這個可能有點複雜喔，可能要給我一些時間") },
            { new KeyValuePair<int, string>(1, "好的，沒問題") },
            { new KeyValuePair<int, string>(1, ".......") },
            { new KeyValuePair<int, string>(1, "那趁這個時間，我先回家找一些相關線索好了") }
        }},
        { "VideoProfesser2", new List<KeyValuePair<int, string>> {
            { new KeyValuePair<int, string>(2, "鑑定結束了，影片是真的。") },
            { new KeyValuePair<int, string>(2, "本次交易為6000萬元，這是我的帳戶，請盡早匯給我。") },
            { new KeyValuePair<int, string>(1, "...") },
            { new KeyValuePair<int, string>(1, "太貴了吧") },
            { new KeyValuePair<int, string>(2, "好了啦，做做效果！祝你破解順利。") },
            { new KeyValuePair<int, string>(1, "......這是一個整人的影片鑑定嗎？") },
            { new KeyValuePair<int, string>(1, "算了，先不說這個了") },
            { new KeyValuePair<int, string>(1, "原來影片是真的嗎？那不就代表女王真的不是人類嗎？") },
            { new KeyValuePair<int, string>(1, "不對不對，在這個充斥著假消息的年代，現在下定論還太早了") },
            { new KeyValuePair<int, string>(1, "我應該先去確認族譜是不是真的才對") },
        }},
        { "MainSelf1", new List<KeyValuePair<int, string>> {
            { new KeyValuePair<int, string>(1, "...") },
            { new KeyValuePair<int, string>(1, ".......") },
            { new KeyValuePair<int, string>(1, "...........") },
            { new KeyValuePair<int, string>(1, "..............!!!") },
            { new KeyValuePair<int, string>(1, "第一代的身分確實是天照女神，") },
            { new KeyValuePair<int, string>(1, "但是36代的女王與一名Mr.X結婚，目前的女王卻是第38代？") },
            { new KeyValuePair<int, string>(1, "關於Mr.X的身份沒有任何結果，只知道他是唯一來自外國的皇室成員？") },
            { new KeyValuePair<int, string>(1, "這邊只知道Mr.X才智過人，然後死因是病死，現葬在七星山上...") },
            { new KeyValuePair<int, string>(1, ".....這到底是怎麼回事？") },
            { new KeyValuePair<int, string>(1, "...") },
            { new KeyValuePair<int, string>(1, "算了，這個之後再說，我應該先回去確認新聞的影片是不是真的") }
        }},
        { "Soldier1", new List<KeyValuePair<int, string>> {
            { new KeyValuePair<int, string>(2, "你想幹嘛，這邊禁止進入喔。") },
            { new KeyValuePair<int, string>(2, "要是未經許可從這邊通過，只有死路一條！") },
            { new KeyValuePair<int, string>(1, "啊！非常不好意思，我這就離開！！") },
            { new KeyValuePair<int, string>(1, "呼...看來這邊應該是沒辦法讓我進去了") },
            { new KeyValuePair<int, string>(1, "不過我想也是，總不會讓我在皇居裡面調查吧") },
            { new KeyValuePair<int, string>(1, "沒辦法了，只好回家看能不能蒐集其他線索了") }
        }},
        { "Soldier2", new List<KeyValuePair<int, string>> {
            { new KeyValuePair<int, string>(2, "快點離開，不然我宰了你喔！") },
            { new KeyValuePair<int, string>(1, "非常抱歉！") }
        }},
        { "MainSelf2", new List<KeyValuePair<int, string>> {
            { new KeyValuePair<int, string>(1, "...") },
            { new KeyValuePair<int, string>(1, "真的完全沒有頭緒，來看個電視冷靜一下好了") },
            { new KeyValuePair<int, string>(2, "...") },
            { new KeyValuePair<int, string>(2, "......所以，今天就是女王一年一度前往七星山的日子了！") },
            { new KeyValuePair<int, string>(1, "咦？") },
            { new KeyValuePair<int, string>(2, "每年的清明節，女王都會前往七星山為已逝的祖父掃墓") },
            { new KeyValuePair<int, string>(2, "而等等，就是女王進行掃墓的日子，所以七星山的墓園會封鎖一天") },
            { new KeyValuePair<int, string>(2, "接著下一則新聞....") },
            { new KeyValuePair<int, string>(1, "女王的祖父？那不就是Mr.X嗎？") },
            { new KeyValuePair<int, string>(1, "如果能夠偷偷跟在女王去掃墓的時候，偷偷地跟在他後面後面，") },
            { new KeyValuePair<int, string>(1, "這樣，也許就能得到Mr.X的線索了") },
            { new KeyValuePair<int, string>(1, "好，我決定了，馬上就準備出發！！") }
        }},
        { "MainSelf3", new List<KeyValuePair<int, string>> {
            { new KeyValuePair<int, string>(1, "...") },
            { new KeyValuePair<int, string>(1, "這就是...女王的祖父...Mr.X的墓碑...") },
            { new KeyValuePair<int, string>(1, "...（仔細端詳墓碑上的文字）") },
            { new KeyValuePair<int, string>(1, "上面寫著Mr.X，這的確是他的墓碑沒錯...") },
            { new KeyValuePair<int, string>(1, "...") },
            { new KeyValuePair<int, string>(1, "......") },
            { new KeyValuePair<int, string>(1, "...唉，為了知道真相....") },
            { new KeyValuePair<int, string>(1, "為了知道Mr.X是不是人類，我也只能這樣做了。") }
        }},
        { "MainSelf4", new List<KeyValuePair<int, string>> {
            { new KeyValuePair<int, string>(1, "...既然下定決心就趕快開始吧") },
            { new KeyValuePair<int, string>(1, "（挖掘）...（挖掘）...") },
            { new KeyValuePair<int, string>(1, "...") },
            { new KeyValuePair<int, string>(1, "......") },
            { new KeyValuePair<int, string>(1, "...帶回家吧") }
        }},
        { "MainSelf5", new List<KeyValuePair<int, string>> {
            { new KeyValuePair<int, string>(1, "那就開始吧") },
            { new KeyValuePair<int, string>(1, "...") },
            { new KeyValuePair<int, string>(1, "......") },
            { new KeyValuePair<int, string>(1, ".........！！！") },
            { new KeyValuePair<int, string>(1, "等等，這個人的身體...") },
            { new KeyValuePair<int, string>(1, "成分竟然充滿了二氧化矽？！") },
            { new KeyValuePair<int, string>(1, "這可不是地球人的身體構造啊...") },
            { new KeyValuePair<int, string>(1, "這表示，Mr.X不是地球人也不是蜥蜴人，而是矽基生命...") },
            { new KeyValuePair<int, string>(1, "也就是外星人啊...") },
            { new KeyValuePair<int, string>(1, "真不得了，沒想到外星生命竟然真的存在") },
            { new KeyValuePair<int, string>(1, "也就是說，具有Mr.X血統的人，包括女王，也是一部分的外星人嗎？") },
            { new KeyValuePair<int, string>(1, "看來女王的身分已經水落石出了呢。") },
            { new KeyValuePair<int, string>(1, "...") },
            { new KeyValuePair<int, string>(1, "等等，難道更之前的35代以前的皇室，也全部都是外星人嗎") },
            { new KeyValuePair<int, string>(1, "...") },
            { new KeyValuePair<int, string>(1, "看來有必要調查一下。") }
        }},
        { "MainSelf6", new List<KeyValuePair<int, string>> {
            { new KeyValuePair<int, string>(1, "真是費了我好多的時間才潛入這裡，這就是第35代女王的遺體嗎") },
            { new KeyValuePair<int, string>(1, "...") },
            { new KeyValuePair<int, string>(1, "雖然這樣做的感覺得真的很糟"+"\n"+"但是為了真相...") },
            { new KeyValuePair<int, string>(1, "（刮取一部份的女王遺體碎片）") },
            { new KeyValuePair<int, string>(1, "好了，就把這個...呃...東西，拿回去研究吧") }
        }},
        { "MainSelf7", new List<KeyValuePair<int, string>> {
            { new KeyValuePair<int, string>(1, "開始分析吧") },
            { new KeyValuePair<int, string>(1, "...") },
            { new KeyValuePair<int, string>(1, "咦？是普通的炭基生命啊") },
            { new KeyValuePair<int, string>(1, "這代表第35代前的皇室並不是外星人，而是地球人") },
            { new KeyValuePair<int, string>(1, "原來如此，這樣就證實了這部分是真實新聞，女王確實是外星人") }
        }}
    };

    public string nowNPC;
    public List<KeyValuePair<int, string>> SetDialogContent() {
        return dialogContent[nowNPC];
    }
    
}
