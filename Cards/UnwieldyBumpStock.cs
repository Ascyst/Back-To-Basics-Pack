using UnboundLib.Cards;
using UnityEngine;

namespace Back_To_Basics_Pack.Cards
{
    internal class UnwieldyBumpStock : CustomCard
    {
        /*
         Demonic Pact, without the demon
         */

        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers)
        {
#if DEBUG
            UnityEngine.Debug.Log("B2BPack: Setting up UnwieldyBumpStock");
#endif
            gun.reloadTimeAdd = 1f;
            gun.dontAllowAutoFire = true;
            gun.attackSpeed = 0f;
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
#if DEBUG
            UnityEngine.Debug.Log("B2BPack: Adding UnwieldyBumpStock");
#endif
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
            return "Shoot as fast as you can pull the trigger";
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Uncommon;
        }

        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
           {
                               new CardInfoStat
                {
                positive = true,
                stat = "Fire Rate",
                amount = "Unlimited",
                simepleAmount = CardInfoStat.SimpleAmount.aLotOf
                },
                new CardInfoStat
                {
                positive = false,
                stat = "Reload Time",
                amount = "+1 Second",
                simepleAmount = CardInfoStat.SimpleAmount.aLotOf
                },
           };
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.FirepowerYellow;
        }

        protected override string GetTitle()
        {
            return "Unwieldy Bump Stock";
        }

        public override string GetModName()
        {
            return "B2BP";
        }
    }
}