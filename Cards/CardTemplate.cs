using UnboundLib.Cards;
using UnityEngine;

namespace Back_To_Basics_Pack.Cards
{
    internal class WellRoundedMeal : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers)
        {
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
            return CardInfo.Rarity.Rare;
        }

        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
{
                new CardInfoStat
                {
                positive = true,
                stat = "HP",
                amount = "+200%",
                simepleAmount = CardInfoStat.SimpleAmount.aHugeAmountOf
                },
                new CardInfoStat
                {
                positive = false,
                stat = "Movement Speed",
                amount = "-40%",
                simepleAmount = CardInfoStat.SimpleAmount.aLotLower
                },
};
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.DefensiveBlue;
        }

        protected override string GetTitle()
        {
            return "Well ROUNDed Meal";
        }

        public override string GetModName()
        {
            return "B2BP";
        }
    }
}