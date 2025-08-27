namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(HeatItUpDamageBuff), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class HeatItUpDamageBuffModel : ProjectileBehaviorModel
{
	internal class HeatItUpDamageMutator : BehaviorMutator
	{

		public HeatItUpDamageMutator(string mutatorId, BuffIndicatorModel buffIndicatorModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	[SerializeField]
	private float lifespan; //Field offset: 0x38
	public int lifespanFrames; //Field offset: 0x3C
	public string mutatorId; //Field offset: 0x40
	public bool useTowerPosition; //Field offset: 0x48
	public string buffLocsName; //Field offset: 0x50
	public string buffIconName; //Field offset: 0x58
	private HeatItUpDamageMutator mutator; //Field offset: 0x60

	public HeatItUpDamageMutator Mutator
	{
		 get { } //Length: 266
	}

	public HeatItUpDamageBuffModel(string name, float lifespan, string mutatorId, bool useTowerPosition, string buffLocsName, string buffIconName) { }

	public virtual Model Clone() { }

	public HeatItUpDamageMutator get_Mutator() { }

	public BuffIndicatorModel GetBuffIndicatorModel() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

