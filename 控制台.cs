using Newtonsoft.Json;
using PeterHan.PLib.Options;


namespace R_家具系统_2._0
{
    [RestartRequired]
    [JsonObject(MemberSerialization.OptIn)]
    [ConfigFile("R000GG0.json", true, false)]
    // [ModInfo("https://space.bilibili.com/30725645", "mmm.png", true)]

    public class 控制台 : SingletonOptions<控制台>
    {
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R003GG1_UI", null, "家具")][JsonProperty] public bool R003GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R004GG1_UI", null, "家具")][JsonProperty] public bool R004GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R004GG2_UI", null, "家具")][JsonProperty] public bool R004GG2 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R004GG3_UI", null, "家具")][JsonProperty] public bool R004GG3 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R005GG1_UI", null, "家具")][JsonProperty] public bool R005GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R006GG1_UI", null, "家具")][JsonProperty] public bool R006GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R007GG1_UI", null, "家具")][JsonProperty] public bool R007GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R007GG1X1_UI", null, "家具", Format = "F0")][Limit(1, 10)][JsonProperty] public float R007GG1X1 { get; set; } = 2f;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R007GG1X2_UI", null, "家具", Format = "F0")][Limit(1, 10)][JsonProperty] public float R007GG1X2 { get; set; } = 2f;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R009GG1_UI", null, "家具")][JsonProperty] public bool R009GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R010GG1_UI", null, "家具")][JsonProperty] public bool R010GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R011GG1_UI", null, "家具")][JsonProperty] public bool R011GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R012GG1_UI", null, "家具")][JsonProperty] public bool R012GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R013GG1_UI", null, "家具")][JsonProperty] public bool R013GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R015GG1_UI", null, "家具")][JsonProperty] public bool R015GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R016GG1_UI", null, "家具")][JsonProperty] public bool R016GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R018GG1_UI", null, "家具")][JsonProperty] public bool R018GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R019GG1_UI", null, "家具")][JsonProperty] public bool R019GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R020GG1_UI", null, "家具")][JsonProperty] public bool R020GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R021GG1_UI", null, "家具")][JsonProperty] public bool R021GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R022GG1_UI", null, "家具")][JsonProperty] public bool R022GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R023GG1_UI", null, "家具")][JsonProperty] public bool R023GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R026GG1_UI", null, "家具")][JsonProperty] public bool R026GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R026GG1X1_UI", null, "家具", Format = "F0")][Limit(1, 1000)][JsonProperty] public float R026GG1X1 { get; set; } = 300f;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R029GG1_UI", null, "家具")][JsonProperty] public bool R029GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R030GG1_UI", null, "家具")][JsonProperty] public bool R030GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R031GG1_UI", null, "家具")][JsonProperty] public bool R031GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R031GG1X1_UI", null, "家具", Format = "F0")][Limit(1, 10)][JsonProperty] public float R031GG1X1 { get; set; } = 2f;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R032GG1_UI", null, "家具")][JsonProperty] public bool R032GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R034GG1_UI", null, "家具")][JsonProperty] public bool R034GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R035GG1_UI", null, "家具")][JsonProperty] public bool R035GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R036GG1_UI", null, "家具")][JsonProperty] public bool R036GG1 { get; set; } = false;
        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R038GG1_UI", null, "家具")][JsonProperty] public bool R038GG1 { get; set; } = false;
        // 模组功能启停控制
        public enum OptionMode { 全部启用, 全部停止, 自由设定 }
        private OptionMode mode;

        [Option("STRINGS.BUILDINGS.PREFABS.R_UI.R000GG0_KZT_0_UI", null, null)]
        [JsonProperty]
        public OptionMode Mode
        {
            get => mode;
            set
            {
                mode = value;
                switch (mode)
                {
                    case OptionMode.全部启用:
                        R003GG1 = true;
                        R004GG1 = true;
                        R004GG2 = true;
                        R004GG3 = true;
                        R005GG1 = true;
                        R006GG1 = true;
                        R007GG1 = true;
                        R009GG1 = true;
                        R010GG1 = true;
                        R011GG1 = true;
                        R012GG1 = true;
                        R013GG1 = true;
                        R015GG1 = true;
                        R016GG1 = true;
                        R018GG1 = true;
                        R019GG1 = true;
                        R020GG1 = true;
                        R021GG1 = true;
                        R022GG1 = true;
                        R023GG1 = true;
                        R026GG1 = true;
                        R029GG1 = true;
                        R030GG1 = true;
                        R031GG1 = true;
                        R032GG1 = true;
                        R034GG1 = true;
                        R035GG1 = true;
                        R036GG1 = true;
                        R038GG1 = true;
                        break;
                    case OptionMode.全部停止:
                        R003GG1 = false;
                        R004GG1 = false;
                        R004GG2 = false;
                        R004GG3 = false;
                        R005GG1 = false;
                        R006GG1 = false;
                        R007GG1 = false;
                        R009GG1 = false;
                        R010GG1 = false;
                        R011GG1 = false;
                        R012GG1 = false;
                        R013GG1 = false;
                        R015GG1 = false;
                        R016GG1 = false;
                        R018GG1 = false;
                        R019GG1 = false;
                        R020GG1 = false;
                        R021GG1 = false;
                        R022GG1 = false;
                        R023GG1 = false;
                        R026GG1 = false;
                        R029GG1 = false;
                        R030GG1 = false;
                        R031GG1 = false;
                        R032GG1 = false;
                        R034GG1 = false;
                        R035GG1 = false;
                        R036GG1 = false;
                        R038GG1 = false;
                        break;
                    case OptionMode.自由设定:
                        break;
                }
            }
        }
        public 控制台()
        {
            R003GG1 = false;
            R004GG1 = false;
            R004GG2 = false;
            R004GG3 = false;
            R005GG1 = false;
            R006GG1 = false;
            R007GG1 = false;
            R009GG1 = false;
            R010GG1 = false;
            R011GG1 = false;
            R012GG1 = false;
            R013GG1 = false;
            R015GG1 = false;
            R016GG1 = false;
            R018GG1 = false;
            R019GG1 = false;
            R020GG1 = false;
            R021GG1 = false;
            R022GG1 = false;
            R023GG1 = false;
            R026GG1 = false;
            R029GG1 = false;
            R030GG1 = false;
            R031GG1 = false;
            R032GG1 = false;
            R034GG1 = false;
            R035GG1 = false;
            R036GG1 = false;
            R038GG1 = false;
            mode = OptionMode.自由设定;
        }

    }
}
