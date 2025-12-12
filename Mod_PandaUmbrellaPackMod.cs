using System;
using System.IO;
using BepInEx;

namespace PandaUmbrellaMod
{
    [BepInPlugin("panda.umbrealla.mod", "Panda's Umbrella Mod", "1.0.0.0")]

    public class Mod_PandaUmbrellaPackMod : BaseUnityPlugin
    {
        private void OnStartCore()
        {
            string pathToExcelFile = Path.GetDirectoryName(((BaseUnityPlugin)this).Info.Location) + "/Umbrella.xlsx";
            SourceManager sources = Core.Instance.sources;
            ModUtil.ImportExcel(pathToExcelFile, "Thing", sources.things);
        }
    }
}
