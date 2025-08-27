namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(ChangeProjectileDisplay), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ChangeProjectileDisplayModel : AbilityBehaviorModel
{
	internal class ChangeProjectileDisplayMutator : BehaviorMutator
	{
		private ChangeProjectileDisplayModel changeDamageTypeModel; //Field offset: 0x70

		public ChangeProjectileDisplayMutator(ChangeProjectileDisplayModel changeDamageTypeModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	[SerializeField]
	private float lifespan; //Field offset: 0x30
	public int lifespanFrames; //Field offset: 0x34
	public ProjectileModel projectileModel; //Field offset: 0x38
	public AssetPathModel displayPath; //Field offset: 0x40
	public string mutatorId; //Field offset: 0x48
	private ChangeProjectileDisplayMutator mutator; //Field offset: 0x50

	public ChangeProjectileDisplayMutator Mutator
	{
		 get { } //Length: 213
	}

	public ChangeProjectileDisplayModel(string name, float lifespan, AssetPathModel displayPath, ProjectileModel projectileModel, string mutatorId) { }

	public virtual Model Clone() { }

	public ChangeProjectileDisplayMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

