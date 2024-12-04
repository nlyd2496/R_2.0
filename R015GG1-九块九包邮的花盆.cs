using Database;
using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_家具系统_2._0
{
    [HarmonyPatch(typeof(BuildingFacades), MethodType.Constructor, new Type[] { typeof(ResourceSet) })]
    public static class R015GG1L1_R015GG1L2_R015GG1L3_R015GG1L4_R015GG1L5_R015GG1L6_R015GG1L5_R015GG1L6_R015GG1L7_R015GG1L8
    {
        public static void Postfix(BuildingFacades __instance)
        {
            bool R015GG1 = SingletonOptions<控制台>.Instance.R015GG1;
            if (R015GG1)
            {
                __instance.Add("R015GG1L1",
                STRINGS.BUILDINGS.PREFABS.R015GG1.NAME, STRINGS.BUILDINGS.PREFABS.R015GG1.EFFECT, PermitRarity.Universal,
                "FLOWERVASE", "R015GG1L1_kanim", DlcManager.AVAILABLE_ALL_VERSIONS);

                __instance.Add("R015GG1L2",
               STRINGS.BUILDINGS.PREFABS.R015GG1L2.NAME, STRINGS.BUILDINGS.PREFABS.R015GG1.EFFECT, PermitRarity.Universal,
               "FLOWERVASE", "R015GG1L2_kanim", DlcManager.AVAILABLE_ALL_VERSIONS);

                __instance.Add("R015GG1L3",
               STRINGS.BUILDINGS.PREFABS.R015GG1L3.NAME, STRINGS.BUILDINGS.PREFABS.R015GG1.EFFECT, PermitRarity.Universal,
               "FLOWERVASE", "R015GG1L3_kanim", DlcManager.AVAILABLE_ALL_VERSIONS);

                __instance.Add("R015GG1L4",
               STRINGS.BUILDINGS.PREFABS.R015GG1L4.NAME, STRINGS.BUILDINGS.PREFABS.R015GG1.EFFECT, PermitRarity.Universal,
               "FLOWERVASE", "R015GG1L4_kanim", DlcManager.AVAILABLE_ALL_VERSIONS);

                __instance.Add("R015GG1L5",
               STRINGS.BUILDINGS.PREFABS.R015GG1L5.NAME, STRINGS.BUILDINGS.PREFABS.R015GG1.EFFECT, PermitRarity.Universal,
               "FLOWERVASE", "R015GG1L5_kanim", DlcManager.AVAILABLE_ALL_VERSIONS);

                __instance.Add("R015GG1L6",
               STRINGS.BUILDINGS.PREFABS.R015GG1L6.NAME, STRINGS.BUILDINGS.PREFABS.R015GG1.EFFECT, PermitRarity.Universal,
               "FLOWERVASE", "R015GG1L6_kanim", DlcManager.AVAILABLE_ALL_VERSIONS);

                __instance.Add("R015GG1L7",
               STRINGS.BUILDINGS.PREFABS.R015GG1L7.NAME, STRINGS.BUILDINGS.PREFABS.R015GG1.EFFECT, PermitRarity.Universal,
               "FLOWERVASE", "R015GG1L7_kanim", DlcManager.AVAILABLE_ALL_VERSIONS);

                __instance.Add("R015GG1L8",
               STRINGS.BUILDINGS.PREFABS.R015GG1L8.NAME, STRINGS.BUILDINGS.PREFABS.R015GG1.EFFECT, PermitRarity.Universal,
               "FLOWERVASE", "R015GG1L8_kanim", DlcManager.AVAILABLE_ALL_VERSIONS);
            }
        }
    }
}
