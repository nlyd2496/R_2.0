using Database;
using HarmonyLib;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUNING;
using UnityEngine;

namespace R_家具系统_2._0
{
    public class R034GG1 : IBuildingConfig
    {
        public override BuildingDef CreateBuildingDef()
        {
            string id = "R034GG1";
            int width = 1;
            int height = 1;
            string anim = "R034GG1L1_kanim";
            int hitpoints = 10;
            float construction_time = 10f;
            float[] tier = BUILDINGS.CONSTRUCTION_MASS_KG.TIER1;
            string[] any_BUILDABLE = MATERIALS.ANY_BUILDABLE;
            float melting_point = 800f;
            BuildLocationRule build_location_rule = BuildLocationRule.Anywhere;
            EffectorValues none = NOISE_POLLUTION.NONE;
            BuildingDef buildingDef = BuildingTemplates.CreateBuildingDef
                (id, width, height, anim, hitpoints, construction_time, tier,
                any_BUILDABLE, melting_point, build_location_rule,
                BUILDINGS.DECOR.BONUS.TIER5, none, 0.2f);
            buildingDef.Floodable = false;
            buildingDef.Entombable = false;
            buildingDef.Overheatable = false;

            buildingDef.RequiresPowerInput = false;
            buildingDef.EnergyConsumptionWhenActive = 0f;
            buildingDef.SelfHeatKilowattsWhenActive = 0f;
            buildingDef.AudioCategory = "Metal";
            buildingDef.LogicInputPorts = LogicOperationalController.CreateSingleInputPortList(new CellOffset(0, 0));
            //--------------------------
            if (控制台.Instance.R034GG1) { buildingDef.Deprecated = false; } else { buildingDef.Deprecated = true; }
            //--------------------------
            return buildingDef;
        }
        public override void DoPostConfigurePreview(BuildingDef def, GameObject go)
        {

        }
        public override void ConfigureBuildingTemplate(GameObject go, Tag prefab_tag)
        {
            go.GetComponent<KPrefabID>().AddTag(GameTags.Decoration, false);
        }
        public override void DoPostConfigureComplete(GameObject go)
        {
            go.AddOrGet<LoopingSounds>();
            go.AddOrGet<LogicOperationalController>();//信号控制器
            go.AddOrGetDef<OperationalController.Def>();
        }
    }
    [HarmonyPatch(typeof(BuildingFacades), MethodType.Constructor, new Type[] { typeof(ResourceSet) })]
    public static class R034GG1L2
    {
        public static void Postfix(BuildingFacades __instance)
        {
            bool R012GG1 = SingletonOptions<控制台>.Instance.R012GG1;
            if (R012GG1)
            {
                __instance.Add("R034GG1L2",
                STRINGS.BUILDINGS.PREFABS.R034GG1L2.NAME, STRINGS.BUILDINGS.PREFABS.R034GG1L2.EFFECT, PermitRarity.Universal,
                "R034GG1", "R034GG1L2_kanim", DlcManager.AVAILABLE_ALL_VERSIONS);
            }
        }
    }
}
