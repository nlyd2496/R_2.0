using HarmonyLib;
using KMod;
using System;
using System.IO;
using System.Reflection;
using TUNING;

namespace R_家具系统_2._0
{
    public class 翻译组件
    {
        [HarmonyPatch(typeof(Localization), "Initialize")] public class 翻译组件1 { public static void Postfix() { Utils.Localize(typeof(STRINGS)); } }
        public static class Utils
        {
            private static Utils.ModInfo _modinfo;
            public static Utils.ModInfo modInfo { get { if (_modinfo == null) { _modinfo = new Utils.ModInfo(); } return _modinfo; } }
            public static void Localize(Type root) { ModUtil.RegisterForTranslation(root); Assembly executingAssembly = Assembly.GetExecutingAssembly(); string name = executingAssembly.GetName().Name; string path = Path.Combine(Path.GetDirectoryName(executingAssembly.Location), "translations"); Localization.Locale locale = Localization.GetLocale(); string localeCode = locale != null ? locale.Code : "en"; try { string text = Path.Combine(path, localeCode + ".po"); Debug.LogWarning(name + " lang file: " + text); if (File.Exists(text)) { Debug.Log(name + ": Localize file found " + text); Localization.OverloadStrings(Localization.LoadStringsFile(text, false)); } } catch (Exception ex) { Debug.LogWarning(name + " Failed to load localization. Exception: " + ex.Message); } LocString.CreateLocStringKeys(root, ""); }
            public class ModInfo { public ModInfo() { Assembly executingAssembly = Assembly.GetExecutingAssembly(); assemblyName = executingAssembly.GetName().Name; rootDirectory = Path.GetDirectoryName(executingAssembly.Location); langDirectory = Path.Combine(rootDirectory, "translations"); spritesDirectory = Path.Combine(rootDirectory, "sprites"); version = executingAssembly.GetName().Version.ToString(); } public readonly string assemblyName; public readonly string rootDirectory; public readonly string langDirectory; public readonly string spritesDirectory; public readonly string version; }
        }
    }
}
