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
    public static class R012GG1L1
    {
        public static void Postfix(BuildingFacades __instance)
        {
            bool R012GG1 = SingletonOptions<控制台>.Instance.R012GG1;
            if (R012GG1)
            {
                __instance.Add("R012GG1L1",
                STRINGS.BUILDINGS.PREFABS.R012GG1L2.NAME, STRINGS.BUILDINGS.PREFABS.R012GG1L2.EFFECT, PermitRarity.Universal,
                "Bed", "R012GG1L1_kanim", DlcManager.AVAILABLE_ALL_VERSIONS);
            }
        }
    }
}
