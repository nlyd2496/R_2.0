using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUNING;
using UnityEngine;

namespace R_家具系统_2._0
{
    public class R004GG2 : IBuildingConfig
	{
		public override BuildingDef CreateBuildingDef()
		{
			string id = "R004GG2";
			int width = 1;
			int height = 1;
			string anim = "R004GG2_kanim";
			int hitpoints = 10;
			float construction_time = 10f;
			float[] tier = BUILDINGS.CONSTRUCTION_MASS_KG.TIER2;

			string[] construction_materials = new string[]
			{
			"CarbonFibre"
			};
			float melting_point = 1600f;

			BuildLocationRule build_location_rule = BuildLocationRule.Anywhere;
			EffectorValues none = NOISE_POLLUTION.NONE;
			BuildingDef buildingDef = BuildingTemplates.CreateBuildingDef(id, width,height,
				anim, hitpoints, construction_time, tier, construction_materials, melting_point, 
				build_location_rule, new EffectorValues
			{
				amount = 10,
				radius = 4
			}, none, 0.2f);

			BuildingTemplates.CreateLadderDef(buildingDef);
			buildingDef.Floodable = false;
			buildingDef.Overheatable = false;
			buildingDef.Entombable = false;
			buildingDef.AudioCategory = "Metal";
			buildingDef.AudioSize = "small";
			buildingDef.BaseTimeUntilRepair = -1f;
			buildingDef.DragBuild = true;
            //--------------------------
            if (控制台.Instance.R004GG2) { buildingDef.Deprecated = false; } else { buildingDef.Deprecated = true; }
            //--------------------------
            return buildingDef;
		}

		public override void ConfigureBuildingTemplate(GameObject go, Tag prefab_tag)
		{
			GeneratedBuildings.MakeBuildingAlwaysOperational(go);
			Ladder ladder3 = go.AddOrGet<Ladder>();
			ladder3.upwardsMovementSpeedMultiplier = 4f;
			ladder3.downwardsMovementSpeedMultiplier = 4f;
			go.AddOrGet<AnimTileable>();
		}

		public override void DoPostConfigureComplete(GameObject go)
		{
		}

	}
}
