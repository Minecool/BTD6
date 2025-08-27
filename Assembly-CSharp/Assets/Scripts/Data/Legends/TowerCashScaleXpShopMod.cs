namespace Assets.Scripts.Data.Legends;

public class TowerCashScaleXpShopMod : RogueXpShopMod
{
	public float cashScalePerLevel; //Field offset: 0x10

	public TowerCashScaleXpShopMod() { }

	public virtual void ApplyDCMEffect(int level, DailyChallengeModel dcm) { }

}

