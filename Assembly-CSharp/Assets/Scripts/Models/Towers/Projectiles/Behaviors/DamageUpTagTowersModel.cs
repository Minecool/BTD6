namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(DamageUpTagTowers), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageUpTagTowersModel : ProjectileBehaviorModel
{
	internal class DamageUpTagMutator : BehaviorMutator
	{
		private DamageUpTagTowersModel damageUpTagTowersModel; //Field offset: 0x70

		public DamageUpTagMutator(DamageUpTagTowersModel damageUpTagTowersModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public int increase; //Field offset: 0x38
	public string bloonTag; //Field offset: 0x40
	public String[] bloonTags; //Field offset: 0x48
	[SerializeField]
	private float lifespan; //Field offset: 0x50
	public int lifespanFrames; //Field offset: 0x54
	public bool useClosest; //Field offset: 0x58
	public string mutatorId; //Field offset: 0x60
	public int priority; //Field offset: 0x68
	public bool useTowerPosition; //Field offset: 0x6C
	private DamageUpTagMutator mutator; //Field offset: 0x70
	public DamageModifierForTagModel damageModifierForTagModel; //Field offset: 0x78

	public DamageUpTagMutator Mutator
	{
		 get { } //Length: 209
	}

	public DamageUpTagTowersModel(string name, int increase, string bloonTag, float lifespan, bool useClosest, string mutatorId, int priority, bool useTowerPosition) { }

	public virtual Model Clone() { }

	public DamageUpTagMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

