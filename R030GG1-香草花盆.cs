using Database;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUNING;
using UnityEngine;

namespace R_家具系统_2._0
{
    public class R030GG1 : IBuildingConfig
    {
        public override BuildingDef CreateBuildingDef()
        {
            string id = "R030GG1";
            int width = 1;
            int height = 1;
            string anim = "R030GG1L1_kanim";
            int hitpoints = 10;
            float construction_time = 10f;
            float[] tier = BUILDINGS.CONSTRUCTION_MASS_KG.TIER1;
            string[] any_BUILDABLE = MATERIALS.ANY_BUILDABLE;
            float melting_point = 800f;
            BuildLocationRule build_location_rule = BuildLocationRule.OnFloor;
            EffectorValues none = NOISE_POLLUTION.NONE;
            BuildingDef buildingDef = BuildingTemplates.CreateBuildingDef(id, width, height, anim, hitpoints, construction_time, tier, any_BUILDABLE, melting_point, build_location_rule, BUILDINGS.DECOR.BONUS.TIER2, none, 0.2f);
            buildingDef.Floodable = false;
            buildingDef.Overheatable = false;
            buildingDef.ViewMode = OverlayModes.Decor.ID;
            buildingDef.AudioCategory = "Glass";
            buildingDef.AudioSize = "large";
            //--------------------------
            if (控制台.Instance.R030GG1) { buildingDef.Deprecated = false; } else { buildingDef.Deprecated = true; }
            //--------------------------
            return buildingDef;
        }
        public override void ConfigureBuildingTemplate(GameObject go, Tag prefab_tag)
        {
            go.AddOrGet<Storage>();
            Prioritizable.AddRef(go);
            go.AddOrGet<PlantablePlot>().AddDepositTag(GameTags.DecorSeed);
            go.AddOrGet<FlowerVase>();
            go.GetComponent<KPrefabID>().AddTag(GameTags.Decoration, false);
        }
        public override void DoPostConfigureComplete(GameObject go)
        {
        }
        public const string ID = "A32GG1";
    }
    [HarmonyPatch(typeof(BuildingFacades), MethodType.Constructor, new Type[] { typeof(ResourceSet) })]
    public static class R030GG1L2_R030GG1L3_R030GG1L4
    {
        public static void Postfix(BuildingFacades __instance)
        {
            __instance.Add("R030GG1L2",
                STRINGS.BUILDINGS.PREFABS.R030GG1L2.NAME, STRINGS.BUILDINGS.PREFABS.R030GG1L2.EFFECT, PermitRarity.Universal,
                "R030GG1", "R030GG1L2_kanim", DlcManager.AVAILABLE_ALL_VERSIONS);
            __instance.Add("R030GG1L3",
                STRINGS.BUILDINGS.PREFABS.R030GG1L3.NAME, STRINGS.BUILDINGS.PREFABS.R030GG1L3.EFFECT, PermitRarity.Universal,
                "R030GG1", "R030GG1L3_kanim", DlcManager.AVAILABLE_ALL_VERSIONS);
            __instance.Add("R030GG1L4",
                STRINGS.BUILDINGS.PREFABS.R030GG1L4.NAME, STRINGS.BUILDINGS.PREFABS.R030GG1L4.EFFECT, PermitRarity.Universal,
                "R030GG1", "R030GG1L4_kanim", DlcManager.AVAILABLE_ALL_VERSIONS);
        }
    }
}
