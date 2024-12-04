using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Klei;
using R_家具系统_2._0;
using PeterHan.PLib.Options;


namespace R_家具系统_2._0
{
    [HarmonyPatch(typeof(MarbleSculptureConfig))]
    [HarmonyPatch("DoPostConfigureComplete")]
    internal class 闪烁的雕塑
    {
        private static void Postfix(GameObject go)
        {
            bool R023GG1 = SingletonOptions<控制台>.Instance.R023GG1;
            if (R023GG1)
            {
                
                go.AddOrGet<R023GG1K0>();
                
            }
        }
    }
}
