using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using STRINGS;
using KMod;
using PeterHan.PLib.Core;
using PeterHan.PLib.Database;
using Klei.AI;
using PeterHan.PLib.Options;

namespace R_家具系统_2._0
{

    public class STRINGS
    {
        public static void DoReplacement()
        {
            LocString.CreateLocStringKeys(typeof(STRINGS), "");
        }
        // 控制器
        
        // 建筑描述
        public class BUILDINGS
        {
            public class PREFABS
            {
                public class R_UI
                {
                    public static LocString R000GG0_KZT_0_UI = "模组功能启停";
                    public static LocString R003GG1_UI = "启用背景灯";
                    public static LocString R004GG1_UI = "启用冰梯子";
                    public static LocString R004GG2_UI = "启用木梯子";
                    public static LocString R004GG3_UI = "启用冰梯子";
                    public static LocString R005GG1_UI = "启用超级冰雕";
                    public static LocString R006GG1_UI = "启用吊床";
                    public static LocString R007GG1_UI = "启用叠叠床";
                    public static LocString R007GG1X1_UI = "上叠叠床的速度";
                    public static LocString R007GG1X2_UI = "下叠叠床的速度";
                    public static LocString R009GG1_UI = "启用粉红灯";
                    public static LocString R010GG1_UI = "启用DRX";
                    public static LocString R011GG1_UI = "启用恭喜faker拿下第四个S赛冠军";
                    public static LocString R012GG1_UI = "启用简单漂亮床";
                    public static LocString R013GG1_UI = "启用角顶饰条在建筑前方";
                    public static LocString R015GG1_UI = "启用九块九包邮的花盆";
                    public static LocString R016GG1_UI = "启用沥青滴漏实验";
                    public static LocString R018GG1_UI = "启用梦可床";
                    public static LocString R019GG1_UI = "启用喵喵床";
                    public static LocString R020GG1_UI = "启用南瓜灯";
                    public static LocString R021GG1_UI = "启用牛战士的面具";
                    public static LocString R022GG1_UI = "启用启动魔法少女";
                    public static LocString R023GG1_UI = "启用闪烁的雕塑";
                    public static LocString R026GG1_UI = "启用点唱机";
                    public static LocString R026GG1X1_UI = "点唱机功率修改";
                    public static LocString R029GG1_UI = "启用香草餐桌";
                    public static LocString R030GG1_UI = "启用香草花盆";
                    public static LocString R031GG1_UI = "启用香草梯子";
                    public static LocString R031GG1X1_UI = "爬香草梯子的速度";
                    public static LocString R032GG1_UI = "启用香草摇摇床";
                    public static LocString R034GG1_UI = "启用小电视";
                    public static LocString R035GG1_UI = "启用萤火虫灯";
                    public static LocString R036GG1_UI = "启用智能吸顶灯";
                    public static LocString R038GG1_UI = "启用超级开发者光源";
                }                
                public class R003GG1
                {
                    public static LocString NAME = "背景灯";
                    public static LocString EFFECT = "它可以建造在普通建筑后面，光亮没有那么的强，用来给雕塑增加一点点氛围感，足够了。";
                    public static LocString DESC = "一丝微光，一丝点缀。";
                }
                public class R004GG1
                {
                    public static LocString NAME = "冰梯子";
                    public static LocString EFFECT = "冰块做的梯子，龟速爬上，飞速滑落。";
                    public static LocString DESC = "西山白雪三城戍。";
                }
                public class R004GG2
                {
                    public static LocString NAME = "木头梯子";
                    public static LocString EFFECT = "木头做的梯子，快快爬上，快快爬下。";
                    public static LocString DESC = "树阴照水爱晴柔。";
                }
                public class R004GG3
                {
                    public static LocString NAME = "金梯子";
                    public static LocString EFFECT = "黄金做的梯子，飞速爬上，飞速爬下。";
                    public static LocString DESC = "黄金印绶悬腰底。";
                }
                public class R006GG1
                {
                    public static LocString NAME = "海湾吊床";
                    public static LocString EFFECT = "天蓝的色彩，轻巧的造型，圆润的曲线，五一不透露出它的美。小人睡在上面有点晃，是真的吗，并不是，那是调皮的小人在做着美梦。";
                    public static LocString DESC = "哪怕只是离地一尺，那也是天空的味道。";
                }
                public class R006GG1L2
                {
                    public static LocString NAME = "北欧吊床";
                    public static LocString EFFECT = "独具匠心，石质工艺。远古的岁月让人们遗忘了仰望星空的感觉，忘记了在大自然的微风吹拂下，安然入睡的美妙。粗糙的技巧，不及曾经的十分之一，在这个年代，却又显得弥足珍贵。";
                }
                public class R007GG1
                {
                    public static LocString NAME = "叠叠床";
                    public static LocString EFFECT = "人口数量太多，床不够，怎么办，叠叠床来凑数。能够相互重叠建造，一层一个小人，在荒郊野外，简直爽歪歪。";
                    public static LocString DESC = "有点挤，忍着点。";
                }
                public class R010GG1
                {
                    public static LocString NAME = "恭喜DRX夺得英雄联盟S12全球总决赛冠军";
                    public static LocString EFFECT = "恭喜DRX夺得英雄联盟S12全球总决赛冠军";
                    public static LocString DESC = "恭喜DRX夺得英雄联盟S12全球总决赛冠军";
                }
                public class R011GG1
                {
                    public static LocString NAME = "Faker！NB！";
                    public static LocString EFFECT = "没有人躲得过岁月，但大部分人选择逃避守着自己的半寸土地，而小部分人选择扛起自己的江山直面新时代的挑战。倘若faker S3夺冠退役，那么留给他的是史上最强刺客的名号。倘若faker S5退役，留给他的则是无与伦比的首个S双冠王。倘若faker S6退役，不败魔王至今也是最可望不可及的高峰。但他选择一直坚持到现在！十年依旧！";
                    public static LocString DESC = "恭喜faker拿下LOL全球总决赛S13冠军。";
                }
                public class R012GG1L2
                {
                    public static LocString NAME = "简单漂亮床";
                    public static LocString EFFECT = "三只气球，一只小熊猫，这又是哪位毛孩子的港湾。后面挂着的那“I LOVE YOU”，一定代表了那海枯石烂的爱情吧，不知，那梦中的情人，在何方。";
                }
                public class R015GG1
                {
                    public static LocString NAME = "一壹号花盆";
                    public static LocString EFFECT = "九块九包邮的花盆大甩卖了啊！";
                }
                public class R015GG1L2
                {
                    public static LocString NAME = "贰号花盆";
                }
                public class R015GG1L3
                {
                    public static LocString NAME = "叁号花盆";
                }
                public class R015GG1L4
                {
                    public static LocString NAME = "肆号花盆";
                }
                public class R015GG1L5
                {
                    public static LocString NAME = "伍号花盆";
                }
                public class R015GG1L6
                {
                    public static LocString NAME = "陆号花盆";
                }
                public class R015GG1L7
                {
                    public static LocString NAME = "柒号花盆";
                }
                public class R015GG1L8
                {
                    public static LocString NAME = "捌号花盆";
                }
                public class R016GG1
                {
                    public static LocString NAME = "沥青滴落实验";
                    public static LocString EFFECT = "还记得初中物理对于固体液体气体的描述吗，那么问题来了，沥青是固体还是液体。如果你看它比较硬硬的，就说它是固体，这是不对的。科学，需要事实的支撑，需要数据的支撑。一年，两年，三年，很多年。或许某一天你能观察到沥青滴落的那一瞬间。那个是时候，你或许会感叹，科学，神奇。";
                    public static LocString DESC = "沥青是一种液体哟。";
                }
                public class R019GG1
                {
                    public static LocString NAME = "黄色喵喵床";
                    public static LocString EFFECT = "软乎乎，毛绒绒，如果躺在她的怀里睡觉，一定很舒服的吧。真可爱，我最乖的小猫猫，喵喵喵。";
                    public static LocString DESC = "送给好友的礼物，愿你永远青春美丽，愿你永远开心快乐*-*";
                }
                public class R019GG1L2
                {
                    public static LocString NAME = "粉色喵喵床";
                    public static LocString EFFECT = "软乎乎，毛绒绒，如果躺在她的怀里睡觉，一定很舒服的吧。真可爱，我最乖的小猫猫，喵喵喵。";
                }
                public class R020GG1
                {
                    public static LocString NAME = "南瓜灯";
                    public static LocString EFFECT = "厌倦了白炽灯白色的光芒，增加了一点点的色彩，让世界不是那么非黑即白。如果某天，没有食物了，南瓜灯去掉灯，或许可以吃，在掉下一排牙齿的前提下。";
                    public static LocString DESC = "别吃，它不是真的南瓜！";
                }
                public class R021GG1
                {
                    public static LocString NAME = "牛战士的面具";
                    public static LocString EFFECT = "挖空的，就遮起来，看不见，就没有。你可以放大缩小它的大小，变大，变小，很方便哟。";
                    public static LocString DESC = "牛战士，从不取下他的面具。";
                }
                public class R022GG1
                {
                    public static LocString NAME = "启动魔法少女";
                    public static LocString EFFECT = "孩子，想要成为魔法少女吗？缔结契约，一起拯救世界。";
                    public static LocString DESC = "小心，学姐的头被拧下来了。";
                }
                public class R029GG1
                {
                    public static LocString NAME = "香草餐桌";
                    public static LocString EFFECT = "靡室靡家，玁狁之故。";
                    public static LocString DESC = "小雅·采薇。";
                }
                public class R030GG1
                {
                    public static LocString NAME = "香草蓝花盆";
                    public static LocString EFFECT = "蓝色的花盆，带着一点点点缀，高端大气上档次。";
                    public static LocString DESC = "不要怀疑，奢华风。";
                }
                public class R030GG1L2
                {
                    public static LocString NAME = "香草金花盆";
                    public static LocString EFFECT = "金色的花盆，带着一点点点缀，高端大气上档次。";
                    public static LocString DESC = "不要怀疑，奢华风。";
                }
                public class R030GG1L3
                {
                    public static LocString NAME = "香草粉花盆";
                    public static LocString EFFECT = "粉色的花盆，带着一点点点缀，高端大气上档次。";
                    public static LocString DESC = "不要怀疑，奢华风。";
                }
                public class R030GG1L4
                {
                    public static LocString NAME = "香草红花盆";
                    public static LocString EFFECT = "红色的花盆，带着一点点点缀，高端大气上档次。";
                    public static LocString DESC = "不要怀疑，奢华风。";
                }
                public class R031GG1
                {
                    public static LocString NAME = "香草梯子";
                    public static LocString EFFECT = "藤蔓编织，香草梯子。";
                    public static LocString DESC = "爱我就请踩我。";
                }
                public class R032GG1
                {
                    public static LocString NAME = "香草摇摇床";
                    public static LocString EFFECT = "睡惯了方的床，睡惯了圆的床。这里有不方不圆的床，可以考虑一下。带着青草的香味入眠，想来，也是极好的。";
                    public static LocString DESC = "不要想多了，它不会晃。";
                }
                public class R034GG1
                {
                    public static LocString NAME = "英雄联盟宣传片";
                    public static LocString EFFECT = "英雄联盟宣传片。";
                    public static LocString DESC = "游戏里，总要看点不一样的东西。";
                }
                public class R034GG1L2
                {
                    public static LocString NAME = "可爱的无牙仔";
                    public static LocString EFFECT = "可爱的无牙仔。";
                }
                public class R035GG1
                {
                    public static LocString NAME = "萤火虫灯";
                    public static LocString EFFECT = "酷似萤火虫的灯，你可以控制它的灯光范围和亮度，注意，范围越大能耗越高。";
                    public static LocString DESC = "可爱的萤火虫灯。";
                }
            }
        }
    }
}
