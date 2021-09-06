using UnboundLib.Cards;
using UnityEngine;

namespace Back_To_Basics_Pack.Cards
{
    internal class PreGameMeal : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers)
        {
            statModifiers.health = 1.25f;
            gun.reloadTime = .8f;
            gun.attackSpeed = .8f;
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {

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
                stat = "HP",
                amount = "+25%",
                simepleAmount = CardInfoStat.SimpleAmount.aLittleBitOf
                },
                new CardInfoStat
                {
                positive = true,
                stat = "Reload Speed",
                amount = "+20%",
                simepleAmount = CardInfoStat.SimpleAmount.aLittleBitOf
                },
                                new CardInfoStat
                {
                positive = true,
                stat = "Attack Speed",
                amount = "+20%",
                simepleAmount = CardInfoStat.SimpleAmount.aLittleBitOf
                },
};
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.DefensiveBlue;
        }

        protected override string GetTitle()
        {
            return "PreGame Meal";
        }

        public override string GetModName()
        {
            return "B2BP";
        }
    }
}