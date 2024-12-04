using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_家具系统_2._0
{
    [HarmonyPatch(typeof(PhonoboxConfig))]
    [HarmonyPatch("CreateBuildingDef")]
    public class 点唱机功率修改
    {
        public static void Postfix(PhonoboxConfig __instance, ref BuildingDef __result)
        {
            bool R026GG1 = SingletonOptions<控制台>.Instance.R026GG1;
            if (R026GG1)
            {
                __result.EnergyConsumptionWhenActive = SingletonOptions<控制台>.Instance.R026GG1X1;
            }
        }
    }
    [HarmonyPatch(typeof(PhonoboxConfig), "CreateBuildingDef")]
    public class 点唱机贴图更换
    {
        private static BuildingDef Postfix(BuildingDef def)
        {
            bool R026GG1 = SingletonOptions<控制台>.Instance.R026GG1;
            if (R026GG1)
            {
                int widthInCells = 3;
                def.WidthInCells = widthInCells;
                def.AnimFiles = new KAnimFile[]
                {
                    Assets.GetAnim("R026GG1_kanim")
                };
                def.GenerateOffsets();
            } 
            return def;
        }
    }
}
