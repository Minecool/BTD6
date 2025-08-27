namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(Overclock), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OverclockModel : AbilityBehaviorModel
{
	internal class OverclockMutator : BehaviorMutator
	{
		private readonly OverclockModel overclockModel; //Field offset: 0x70

		public OverclockMutator(OverclockModel overclockModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public int lifespanFrames; //Field offset: 0x30
	public float rateModifier; //Field offset: 0x34
	public float villageRangeModifier; //Field offset: 0x38
	public string mutatorId; //Field offset: 0x40
	public string mutatorSaveId; //Field offset: 0x48
	public int maxStacks; //Field offset: 0x50
	public PrefabReference selectionObjectPath; //Field offset: 0x58
	public PrefabReference buffDisplayPath; //Field offset: 0x60
	public EffectModel initialEffect; //Field offset: 0x68
	private DisplayModel buffDisplayModel; //Field offset: 0x70
	public string buffLocsName; //Field offset: 0x78
	public string buffIconName; //Field offset: 0x80
	public Single[] tierBasedDurationMultiplier; //Field offset: 0x88
	public bool isParagonMode; //Field offset: 0x90
	public float paragonZoneRange; //Field offset: 0x94
	public int paragonZoneLifespanFrames; //Field offset: 0x98
	private OverclockMutator mutator; //Field offset: 0xA0

	public OverclockMutator Mutator
	{
		 get { } //Length: 301
	}

	public OverclockModel(string name, int lifespanFrames, float rateModifier, float villageRangeModifier, string mutatorId, string mutatorSaveId, int maxStacks, PrefabReference selectionObjectPath, PrefabReference buffDisplayPath, EffectModel initialEffect, Single[] tierBasedDurationMultiplier, string buffLocsName, string buffIconName, bool isParagonMode = false, float paragonZoneRange = 0, int paragonZoneLifespanFrames = 0) { }

	public virtual Model Clone() { }

	public OverclockMutator get_Mutator() { }

	public BuffIndicatorModel GetBuffIndicatorModel() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

