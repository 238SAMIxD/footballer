using System.Linq;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity.Display;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;
using UnityEngine;

namespace Footballer.Displays
{
    public class FootballerBaseDisplay : ModTowerDisplay<Footballer>
    {
        // Copy the Boomerang Monkey display
        public override string BaseDisplay => GetDisplay(TowerType.DartMonkey);

        public override bool UseForTower(int[] tiers)
        {
            return tiers.Sum() == 0;
        }

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            // Print info about the node in order to edit it easier
# if DEBUG
            node.PrintInfo();
            node.SaveMeshTexture();
#endif

            // Set our custom texture
            SetMeshTexture(node, Name);
            SetMeshOutlineColor(node, new Color(0 / 255, 0 / 255, 255.0f / 255));

            // Make it not hold the Dart
            node.RemoveBone("DartMonkeyDart");
        }
    }
}