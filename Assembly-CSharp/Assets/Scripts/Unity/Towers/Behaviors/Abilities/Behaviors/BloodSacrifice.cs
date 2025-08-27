namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class BloodSacrifice : AbilityBehavior
{
	public BloodSacrifice parent; //Field offset: 0x88
	public float xpMultiplier; //Field offset: 0x90
	public string expXpMultiplier; //Field offset: 0x98
	public AudioClip activateSound; //Field offset: 0xA0
	public AudioClip expActivateSound; //Field offset: 0xA8
	public AudioClip confirmSound; //Field offset: 0xB0
	public AudioClip expConfirmSound; //Field offset: 0xB8
	public GameObject selectionObject; //Field offset: 0xC0
	public GameObject expSelectionObject; //Field offset: 0xC8
	public Effect effectAtSacrifice; //Field offset: 0xD0
	public Effect expEffectAtSacrifice; //Field offset: 0xD8
	public float rateBonusMultiplier; //Field offset: 0xE0
	public string expRateBonusMultiplier; //Field offset: 0xE8
	public float rangeBonusMultiplier; //Field offset: 0xF0
	public string expRangeBonusMultiplier; //Field offset: 0xF8
	public float buffDuration; //Field offset: 0x100
	public string expBuffDuration; //Field offset: 0x108
	public GameObject buffDisplay; //Field offset: 0x110
	public GameObject expBuffDisplay; //Field offset: 0x118
	public string buffLocsName; //Field offset: 0x120
	public string expBuffLocsName; //Field offset: 0x128
	public string buffIconName; //Field offset: 0x130
	public string expBuffIconName; //Field offset: 0x138
	public float bonusMultiplierPerSacrifice; //Field offset: 0x140
	public string expBonusMultiplierPerSacrifice; //Field offset: 0x148
	public float bonusSacrificeAmount; //Field offset: 0x150
	public string expBonusSacrificeAmount; //Field offset: 0x158
	public int maxBonusCount; //Field offset: 0x160
	public string expMaxBonusCount; //Field offset: 0x168

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 690
	}

	public BloodSacrifice() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

