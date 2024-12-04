using KSerialization;
using STRINGS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace R_家具系统_2._0
{
    public class R003GG1K1 : KMonoBehaviour, ISingleSliderControl, ISliderControl
    {
        public float GetSliderMin(int index) => 0;//最小值
        public float GetSliderMax(int index) => 1000;//最大值
        public int SliderDecimalPlaces(int index) => 0;//小数点
        public string SliderUnits => UI.UNITSUFFIXES.LIGHT.LUX; // 亮度
        public string SliderTitleKey => "STRINGS.BUILDINGS.PREFABS.R003GG1.NAME";//窗口名称
        public string GetSliderTooltip(int index) => "";//空
        //--------------------------
        [Serialize] public float AA = 100f;//AA参数默认值
        //--------------------------
        [MyCmpReq] public EnergyConsumer energyConsumer;//能量
        [MyCmpReq] public Light2D light2D;//灯
        internal void Update() { this.light2D.Lux = (int)this.AA; this.energyConsumer.BaseWattageRating = this.energyConsumer.WattsNeededWhenActive * 0.001f * AA; }//将AA的值赋予源功能组件
        //--------------------------
        //以下内容无需更改
        public float GetSliderValue(int index) => this.AA;
        public string GetSliderTooltipKey(int index) => "";//空
        [MyCmpAdd] public CopyBuildingSettings copyBuildingSettings;
        protected override void OnSpawn() { base.OnSpawn(); this.Update(); }
        public void SetSliderValue(float value, int index) { this.AA = value; this.Update(); }
        protected override void OnPrefabInit() { base.OnPrefabInit(); base.Subscribe(-905833192, new Action<object>(this.OnCopySettings)); }
        internal void OnCopySettings(object data) { var component = ((GameObject)data).GetComponent<R003GG1K1>(); if (component == null) return; AA = component.AA; Update(); }
        //--------------------------
    }
}
