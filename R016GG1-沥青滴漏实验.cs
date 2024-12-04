using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUNING;
using UnityEngine;

namespace R_家具系统_2._0
{
    public class R016GG1 : IBuildingConfig
    {
        public override BuildingDef CreateBuildingDef()
        {
            string id = "R016GG1";
            int width = 1;
            int height = 2;
            string anim = "R016GG1_kanim";
            int hitpoints = 10;
            float construction_time = 10f;
            float[] construction_mass = new float[]
            {
                50f,
                10f
            };
            string[] construction_materials = new string[]
            {
                "Glass",
                "Bitumen"
            };
            float melting_point = 600f;
            BuildLocationRule build_location_rule = BuildLocationRule.OnFloor;
            EffectorValues none = NOISE_POLLUTION.NONE;
            BuildingDef buildingDef = BuildingTemplates.CreateBuildingDef
                (id, width, height, anim, hitpoints, construction_time, construction_mass, construction_materials,
                melting_point, build_location_rule,
                BUILDINGS.DECOR.BONUS.TIER1, none, 0.2f);
            buildingDef.Floodable = false;
            buildingDef.Entombable = false;
            buildingDef.Overheatable = false;
            buildingDef.RequiresPowerInput = false;
            buildingDef.EnergyConsumptionWhenActive = 0f;
            buildingDef.SelfHeatKilowattsWhenActive = 0f;
            buildingDef.AudioCategory = "Metal";
            buildingDef.LogicInputPorts = LogicOperationalController.CreateSingleInputPortList(new CellOffset(0, 0));
            //--------------------------
            if (控制台.Instance.R016GG1) { buildingDef.Deprecated = false; } else { buildingDef.Deprecated = true; }
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
}
