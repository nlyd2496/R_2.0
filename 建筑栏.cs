using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_家具系统_2._0
{
    [HarmonyPatch(typeof(GeneratedBuildings))]
    [HarmonyPatch("LoadGeneratedBuildings")]
    public class 建筑栏
    {
        public static void Prefix()
        {
            // 建筑栏描述
            ModUtil.AddBuildingToPlanScreen("Furniture", "R003GG1");
            ModUtil.AddBuildingToPlanScreen("Furniture", "R004GG1");
            ModUtil.AddBuildingToPlanScreen("Furniture", "R004GG2");
            ModUtil.AddBuildingToPlanScreen("Furniture", "R004GG3");
            ModUtil.AddBuildingToPlanScreen("Furniture", "R005GG1");
            ModUtil.AddBuildingToPlanScreen("Furniture", "R006GG1");
            ModUtil.AddBuildingToPlanScreen("Furniture", "R007GG1");
            ModUtil.AddBuildingToPlanScreen("Furniture", "R010GG1");
            ModUtil.AddBuildingToPlanScreen("Furniture", "R011GG1");
            ModUtil.AddBuildingToPlanScreen("Furniture", "R016GG1");
            ModUtil.AddBuildingToPlanScreen("Furniture", "R019GG1");
            ModUtil.AddBuildingToPlanScreen("Furniture", "R020GG1");
            ModUtil.AddBuildingToPlanScreen("Furniture", "R021GG1");
            ModUtil.AddBuildingToPlanScreen("Furniture", "R022GG1");
            ModUtil.AddBuildingToPlanScreen("Furniture", "R026GG1");
            ModUtil.AddBuildingToPlanScreen("Furniture", "R029GG1");
            ModUtil.AddBuildingToPlanScreen("Furniture", "R030GG1");
            ModUtil.AddBuildingToPlanScreen("Furniture", "R031GG1");
            ModUtil.AddBuildingToPlanScreen("Furniture", "R032GG1");
            ModUtil.AddBuildingToPlanScreen("Furniture", "R034GG1");
            ModUtil.AddBuildingToPlanScreen("Furniture", "R035GG1");
        }
    }
}
//  基地 氧气   电力  食物 液管     气管 精炼     医疗    家具      站台      实用      自动化     运输       火箭     辐射
//  Base Oxygen Power Food Plumbing HVAC Refining Medical Furniture Equipment Utilities Automation Conveyance Rocketry HEP
