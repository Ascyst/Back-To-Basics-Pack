using UnboundLib.Cards;
using UnityEngine;

namespace Back_To_Basics_Pack.Cards
{
    internal class BulletMultiplicator : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers)
        {
            gun.reloadTime = 1.25f;
            gun.multiplySpread = 2f;
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            gun.numberOfProjectiles *= 2;
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
            return "Doubles your bullets as they leave the barrel, may cause increased spread/misfires";
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
                stat = "Bullets",
                amount = "x2",
                simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat
                {
                positive = false,
                stat = "Reload Speed",
                amount = "-25%",
                simepleAmount = CardInfoStat.SimpleAmount.slightlyLower
                },
};
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.DestructiveRed;
        }

        protected override string GetTitle()
        {
            return "Bullet Multiplicator";
        }

        public override string GetModName()
        {
            return "B2BP";
        }
    }
}