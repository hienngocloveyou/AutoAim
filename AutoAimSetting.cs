﻿using System.Windows.Forms;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;

namespace MadDog_AutoAim
{
    public class AutoAimSetting : ISettings
    {
        //public HotkeyNode AimKey { get; set; } = Keys.RButton;
        public HotkeyNode ActiveSKill { get; set; } = Keys.Q;
        public RangeNode<int> AimRange { get; set; } = new RangeNode<int>(100, 40, 1000);
        public RangeNode<int> AimLoopDelay { get; set; } = new RangeNode<int>(124, 1, 200);
        public ToggleNode DebugMonsterWeight { get; set; } = new ToggleNode(false);
        public ToggleNode ShowAimRange { get; set; } = new ToggleNode(false);
        public ToggleNode AFKMod { get; set; } = new ToggleNode(false);
        public RangeNode<int> HasContagionWeight { get; set; } = new RangeNode<int>(20, -200, 200);
        public RangeNode<int> UniqueRarityWeight { get; set; } = new RangeNode<int>(20, -200, 200);
        public RangeNode<int> RareRarityWeight { get; set; } = new RangeNode<int>(15, -200, 200);
        public RangeNode<int> MagicRarityWeight { get; set; } = new RangeNode<int>(10, -200, 200);
        public RangeNode<int> NormalRarityWeight { get; set; } = new RangeNode<int>(5, -200, 200);
        public RangeNode<int> CannotDieAura { get; set; } = new RangeNode<int>(100, -200, 200);
        public RangeNode<int> capture_monster_trapped { get; set; } = new RangeNode<int>(200, -200, 200);
        public RangeNode<int> capture_monster_enraged { get; set; } = new RangeNode<int>(-50, -200, 200);
        public RangeNode<int> BeastHearts { get; set; } = new RangeNode<int>(80, -200, 200);
        public RangeNode<int> TukohamaShieldTotem { get; set; } = new RangeNode<int>(70, -200, 200);
        public RangeNode<int> StrongBoxMonster { get; set; } = new RangeNode<int>(25, -200, 200);
        public RangeNode<int> RaisesUndead { get; set; } = new RangeNode<int>(30, -200, 200);
        public RangeNode<int> SummonedSkeoton { get; set; } = new RangeNode<int>(-30, -200, 200);
        public RangeNode<int> RaisedZombie { get; set; } = new RangeNode<int>(-30, -200, 200);
        public RangeNode<int> LightlessGrub { get; set; } = new RangeNode<int>(-30, -200, 200);
        public RangeNode<int> TaniwhaTail { get; set; } = new RangeNode<int>(-40, -200, 200);
        public RangeNode<int> DiesAfterTime { get; set; } = new RangeNode<int>(-50, -200, 200);
        public RangeNode<int> BreachMonsterWeight { get; set; } = new RangeNode<int>(50, -200, 200);
        public RangeNode<int> HarbingerMinionWeight { get; set; } = new RangeNode<int>(50, -200, 200);
        public ToggleNode Enable { get; set; } = new ToggleNode(false);
    }
}