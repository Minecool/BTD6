namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(TakeAim), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TakeAimModel : AbilityBehaviorModel
{
	internal class TakeAimMutator : BehaviorMutator
	{
		private readonly TakeAimModel takeAimModel; //Field offset: 0x70

		public TakeAimMutator(TakeAimModel takeAimModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string MutatorId = "TakeAim"; //Field offset: 0x0
	public int lifespanFrames; //Field offset: 0x30
	public float rangeModifier; //Field offset: 0x34
	public float spreadModifier; //Field offset: 0x38
	public PrefabReference selectionObjectPath; //Field offset: 0x40
	public PrefabReference buffDisplayPath; //Field offset: 0x48
	public EffectModel initialEffect; //Field offset: 0x50
	private DisplayModel buffDisplayModel; //Field offset: 0x58
	public string buffLocsName; //Field offset: 0x60
	public string buffIconName; //Field offset: 0x68
	public string immunitiesGranted; //Field offset: 0x70
	public int mutatorPriority; //Field offset: 0x78
	public String[] immunitiesGrantedList; //Field offset: 0x80
	private TakeAimMutator mutator; //Field offset: 0x88

	public TakeAimMutator Mutator
	{
		 get { } //Length: 292
	}

	public TakeAimModel(string name, int lifespanFrames, float rangeModifier, float spreadModifier, PrefabReference selectionObjectPath, PrefabReference buffDisplayPath, EffectModel initialEffect, string buffLocsName, string buffIconName, string immunitiesGranted, int mutatorPriority) { }

	public virtual Model Clone() { }

	public TakeAimMutator get_Mutator() { }

	public BuffIndicatorModel GetBuffIndicatorModel() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

