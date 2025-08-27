namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(VigilanteTowerBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class VigilanteTowerBehaviorModel : TowerBehaviorModel
{
	internal class VigilanteMutator : BehaviorMutator
	{
		private readonly VigilanteTowerBehaviorModel vigilanteTowerBehaviorModel; //Field offset: 0x70

		public VigilanteMutator(bool isUnique, string mutatorId, VigilanteTowerBehaviorModel vigilanteTowerBehaviorModel, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float loseLifeAttackSpeedBuff; //Field offset: 0x30
	public float loseLifeRangeBuff; //Field offset: 0x34
	public int loseLifeBuffDurationFrames; //Field offset: 0x38
	public int loseLifeBuffCooldownFrames; //Field offset: 0x3C
	public string buffLocsName; //Field offset: 0x40
	public PrefabReference buffDisplay; //Field offset: 0x48
	public string oneHealthHighestBloon; //Field offset: 0x50
	public float bloonLeakValueModifier; //Field offset: 0x58
	private DisplayModel buffDisplayModel; //Field offset: 0x60
	private VigilanteMutator mutator; //Field offset: 0x68

	public VigilanteMutator Mutator
	{
		 get { } //Length: 294
	}

	public VigilanteTowerBehaviorModel(string name, float loseLifeAttackSpeedBuff, float loseLifeRangeBuff, int loseLifeBuffDurationFrames, int loseLifeBuffCooldownFrames, string buffLocsName, PrefabReference buffDisplay, string oneHealthHighestBloon, float bloonLeakValueModifier) { }

	public virtual Model Clone() { }

	public VigilanteMutator get_Mutator() { }

	public BuffIndicatorModel GetBuffIndicatorModel() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

