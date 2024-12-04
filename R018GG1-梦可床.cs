using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_家具系统_2._0
{
    [HarmonyPatch(typeof(BedConfig))]
    [HarmonyPatch("CreateBuildingDef")]
    internal class 梦可床
    {
        private static BuildingDef Postfix(BuildingDef def)
        {
            bool R018GG1 = SingletonOptions<控制台>.Instance.R018GG1;
            if (R018GG1)
            {
                def.AnimFiles = new KAnimFile[]
                {
                    Assets.GetAnim("R018GG1_kanim")
                 };
            }
            return def;
        }
    }
}
