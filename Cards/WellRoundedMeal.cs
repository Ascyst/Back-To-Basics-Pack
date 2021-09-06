using UnboundLib.Cards;
using UnityEngine;
using PlayerJumpPatch;

namespace Back_To_Basics_Pack.Cards
{
    internal class CardTemplate : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers)
        {
            statModifiers.health = 2f;
            statModifiers.jump += 1;
            statModifiers.movementSpeed = 1.1f;
            
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
                amount = "+100%",
                simepleAmount = CardInfoStat.SimpleAmount.aLotOf
                },
                new CardInfoStat
                {
                positive = true,
                stat = "Movement Speed",
                amount = "+10%",
                simepleAmount = CardInfoStat.SimpleAmount.aLittleBitOf
                },
                new CardInfoStat
                {
                positive = true,
                stat = "Jumps",
                amount = "+1",
                simepleAmount = CardInfoStat.SimpleAmount.notAssigned
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