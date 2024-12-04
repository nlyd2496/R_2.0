using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using R_家具系统_2._0;

namespace R_家具系统_2._0
{
    [HarmonyPatch(typeof(CeilingLightConfig))]
    [HarmonyPatch("DoPostConfigureComplete")]
    public class 智能吸顶灯
    {
        public static void Postfix(GameObject go)
        {
            bool R036GG1 = SingletonOptions<控制台>.Instance.R036GG1;
            if (R036GG1)
            {
                go.AddOrGet<R036GG1K1>();
            }
        }
    }
}
