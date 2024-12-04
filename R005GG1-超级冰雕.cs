using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_家具系统_2._0
{
    [HarmonyPatch(typeof(IceSculptureConfig))]
    [HarmonyPatch("CreateBuildingDef")]
    public static class 超级冰雕
    {
        private static BuildingDef Postfix(BuildingDef def)
        {
            bool R005GG1 = SingletonOptions<控制台>.Instance.R005GG1;
            if (R005GG1)
            {
                string[] construction_materials = new string[]
                {

                    "Plastic"
                };
                def.MaterialCategory = construction_materials;
            }
            return def;
        }
    }
}
