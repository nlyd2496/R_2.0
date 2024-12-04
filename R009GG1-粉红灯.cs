using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace R_家具系统_2._0
{
    [HarmonyPatch(typeof(FloorLampConfig))]
    [HarmonyPatch("DoPostConfigureComplete")]
    internal class 粉红灯
    {
        private static void Postfix(GameObject go)
        {
            bool R009GG1 = SingletonOptions<控制台>.Instance.R009GG1;
            if (R009GG1)
            {
                Light2D light2D = go.AddOrGet<Light2D>();
                light2D.Color = new Color(5f, 0f, 4f, 1f);//灯光颜色为浅粉色
                light2D.Angle = 10f;//灯光颜色渲染为圆形
            }
        }
    }
}