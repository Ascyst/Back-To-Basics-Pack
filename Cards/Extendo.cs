using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;

namespace Back_To_Basics_Pack.Cards
{
    class Extendo : CustomCard
    {

        /*
         Adds 4 Ammo, increases reload time.
         */
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers)
        {
#if DEBUG
            UnityEngine.Debug.Log("B2BPack: Setting up Extendo");
#endif
            gun.reloadTime += .15f;

        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
#if DEBUG
            UnityEngine.Debug.Log("B2BPack: Adding Extendo");
#endif
            gunAmmo.maxAmmo += 4;
        }


        public override void OnRemoveCard()
        {
            return;
        }



        protected override GameObject GetCardArt()
        {
            return null;
        }

        protected override string GetDescription()
        {
            return null;
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Common;
        }

        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
           {
                new CardInfoStat
                {
                positive = true,
                stat = "Ammo",
                amount = "+4",
                simepleAmount = CardInfoStat.SimpleAmount.aLittleBitOf
                },
                new CardInfoStat
                {
                positive = false,
                stat = "Reload Speed",
                amount = "-15%",
                simepleAmount = CardInfoStat.SimpleAmount.slightlyLower
                },
           };
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.FirepowerYellow;
        }

        protected override string GetTitle()
        {
            return "Extendo";
        }

        public override string GetModName()
        {
            return "B2BP";
        }
    }
}
