namespace Assets.Scripts.Data.Legends;

public class BloonSpeedXpShopMod : RogueXpShopMod
{
	public float bloonSpeedPerLevel; //Field offset: 0x10

	public BloonSpeedXpShopMod() { }

	public virtual void ApplyDCMEffect(int level, DailyChallengeModel dcm) { }

}

