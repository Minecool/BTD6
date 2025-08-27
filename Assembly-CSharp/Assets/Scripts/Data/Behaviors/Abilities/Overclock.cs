namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "Overclock", menuName = "BTD6/Behaviors/Abilities/Overclock")]
public class Overclock : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30
	public float rateModifier; //Field offset: 0x34
	public float villageRangeModifier; //Field offset: 0x38
	public string mutatorId; //Field offset: 0x40
	public string mutatorSaveId; //Field offset: 0x48
	public int maxStacks; //Field offset: 0x50
	public PrefabReference selectionObject; //Field offset: 0x58
	public PrefabReference buffDisplay; //Field offset: 0x60
	public Effect initialEffect; //Field offset: 0x68
	public float tier0DurationMultiplier; //Field offset: 0x70
	public float tier1DurationMultiplier; //Field offset: 0x74
	public float tier2DurationMultiplier; //Field offset: 0x78
	public float tier3DurationMultiplier; //Field offset: 0x7C
	public float tier4DurationMultiplier; //Field offset: 0x80
	public float tier5DurationMultiplier; //Field offset: 0x84
	public string buffLocsName; //Field offset: 0x88
	public string buffIconName; //Field offset: 0x90

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 642
	}

	public Overclock() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

