using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_家具系统_2._0
{
    [HarmonyPatch(typeof(CrownMouldingConfig))]
    [HarmonyPatch("CreateBuildingDef")]
    public class 角饰条在建筑前方
    {
        public static void Postfix(ref BuildingDef __result)
        {
            bool R013GG1 = SingletonOptions<控制台>.Instance.R013GG1;
            if (R013GG1)
            {
                __result.SceneLayer = Grid.SceneLayer.BuildingFront;
                __result.ObjectLayer = ObjectLayer.Plants;
            }
        }
    }
    [HarmonyPatch(typeof(CornerMouldingConfig))]
    [HarmonyPatch("CreateBuildingDef")]
    public class 顶饰条在建筑前方
    {
        public static void Postfix(ref BuildingDef __result)
        {
            bool R013GG1 = SingletonOptions<控制台>.Instance.R013GG1;
            if (R013GG1)
            {
                __result.SceneLayer = Grid.SceneLayer.BuildingFront;
            __result.ObjectLayer = ObjectLayer.Plants;
        } 
    }
    }
}
