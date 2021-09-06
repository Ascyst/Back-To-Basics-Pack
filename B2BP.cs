using Back_To_Basics_Pack.Cards;
using BepInEx;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;

namespace B2BPack
{
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInPlugin(ModID, ModName, ModVersion)]
    [BepInProcess("Rounds.exe")]
    public class B2BP : BaseUnityPlugin
    {
        private const string ModID = "com.ascyst.rounds.b2bpack";
        private const string ModName = "Back To Basics Pack";
        public const string ModVersion = "0.0.0";

        void Start()
        {

            //Add Credits
            Unbound.RegisterCredits(ModName,
                new string[] { "Ascyst" },
                new string[] { "GitHub" },
                new string[] { "https://github.com/Ascyst"});
            //Build Cards
            CustomCard.BuildCard<Extendo>();
            CustomCard.BuildCard<UnwieldyBumpStock>();
            CustomCard.BuildCard<GluttonsMeal>();
            CustomCard.BuildCard<PreGameMeal>();
            CustomCard.BuildCard<WellRoundedMeal>();
            CustomCard.BuildCard<BulletMultiplicator>();



        }
    }
}
