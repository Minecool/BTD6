namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class Overclock : AbilityBehavior
{
	public Overclock parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public float rateModifier; //Field offset: 0xA0
	public string expRateModifier; //Field offset: 0xA8
	public float villageRangeModifier; //Field offset: 0xB0
	public string expVillageRangeModifier; //Field offset: 0xB8
	public string mutatorId; //Field offset: 0xC0
	public string expMutatorId; //Field offset: 0xC8
	public string mutatorSaveId; //Field offset: 0xD0
	public string expMutatorSaveId; //Field offset: 0xD8
	public int maxStacks; //Field offset: 0xE0
	public string expMaxStacks; //Field offset: 0xE8
	public bool isParagonMode; //Field offset: 0xF0
	public string expIsParagonMode; //Field offset: 0xF8
	public float paragonZoneRange; //Field offset: 0x100
	public string expParagonZoneRange; //Field offset: 0x108
	public float paragonZoneLifespan; //Field offset: 0x110
	public string expParagonZoneLifespan; //Field offset: 0x118
	public GameObject selectionObject; //Field offset: 0x120
	public GameObject expSelectionObject; //Field offset: 0x128
	public GameObject buffDisplay; //Field offset: 0x130
	public GameObject expBuffDisplay; //Field offset: 0x138
	public Effect initialEffect; //Field offset: 0x140
	public Effect expInitialEffect; //Field offset: 0x148
	public float tier0DurationMultiplier; //Field offset: 0x150
	public string expTier0DurationMultiplier; //Field offset: 0x158
	public float tier1DurationMultiplier; //Field offset: 0x160
	public string expTier1DurationMultiplier; //Field offset: 0x168
	public float tier2DurationMultiplier; //Field offset: 0x170
	public string expTier2DurationMultiplier; //Field offset: 0x178
	public float tier3DurationMultiplier; //Field offset: 0x180
	public string expTier3DurationMultiplier; //Field offset: 0x188
	public float tier4DurationMultiplier; //Field offset: 0x190
	public string expTier4DurationMultiplier; //Field offset: 0x198
	public float tier5DurationMultiplier; //Field offset: 0x1A0
	public string expTier5DurationMultiplier; //Field offset: 0x1A8
	public string buffLocsName; //Field offset: 0x1B0
	public string expBuffLocsName; //Field offset: 0x1B8
	public string buffIconName; //Field offset: 0x1C0
	public string expBuffIconName; //Field offset: 0x1C8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 837
	}

	public Overclock() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

