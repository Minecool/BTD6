namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(EziliSupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EziliSupportModel : TowerBehaviorModel
{
	internal class NecromancerPierceMutator : BehaviorMutator
	{
		private readonly float multiplier; //Field offset: 0x70

		public NecromancerPierceMutator(bool isUnique, string mutatorId, float multiplier, int priority, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float necroPierceMultiplier; //Field offset: 0x30
	private NecromancerPierceMutator necroPierceMutator; //Field offset: 0x38

	public NecromancerPierceMutator NecroPierceMutator
	{
		 get { } //Length: 309
	}

	public EziliSupportModel(string name, float necroPierceMultiplier, NecromancerPierceMutator necroPierceMutator) { }

	public virtual Model Clone() { }

	public NecromancerPierceMutator get_NecroPierceMutator() { }

	public BuffIndicatorModel GetBuffIndicatorModel() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

