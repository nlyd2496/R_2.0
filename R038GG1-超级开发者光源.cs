using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_家具系统_2._0
{
    [HarmonyPatch(typeof(DevLightGeneratorConfig))]
    [HarmonyPatch("CreateBuildingDef")]
    internal class 超级开发者光源
    {
        public static void Postfix(BuildingDef __result)
        {
            bool R038GG1 = SingletonOptions<控制台>.Instance.R038GG1;
            if (R038GG1)
            {
                __result.DebugOnly = false;//正常模式可使用
                __result.Floodable = false;//可被淹没
                __result.Overheatable = false;//不会过热
                __result.ThermalConductivity = 0f;//导热系数为0
                __result.UseStructureTemperature = false;//使用结构温度
            }
        }
    }
}
