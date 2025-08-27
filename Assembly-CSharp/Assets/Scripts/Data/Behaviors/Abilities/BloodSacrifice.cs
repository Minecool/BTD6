namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "BloodSacrifice", menuName = "BTD6/Behaviors/Abilities/BloodSacrifice")]
public class BloodSacrifice : AbilityBehavior
{
	public float xpMultiplier; //Field offset: 0x30
	public Sound activateSound; //Field offset: 0x38
	public Sound confirmSound; //Field offset: 0x40
	public PrefabReference selectionObject; //Field offset: 0x48
	public Effect effectAtSacrifice; //Field offset: 0x50
	public float rateBonusMultiplier; //Field offset: 0x58
	public float rangeBonusMultiplier; //Field offset: 0x5C
	public float buffDuration; //Field offset: 0x60
	public PrefabReference buffDisplay; //Field offset: 0x68
	public string buffLocsName; //Field offset: 0x70
	public string buffIconName; //Field offset: 0x78
	public float bonusMultiplierPerSacrifice; //Field offset: 0x80
	public float bonusSacrificeAmount; //Field offset: 0x84
	public int maxBonusCount; //Field offset: 0x88

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 592
	}

	public BloodSacrifice() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

