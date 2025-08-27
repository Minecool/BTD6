namespace Assets.Scripts.Models.Towers.Mutators;

[Implementation(typeof(ProjectileSpeedTowerMutator), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ProjectileSpeedTowerMutatorModel : TowerMutatorModel
{
	public float speedModifier; //Field offset: 0x40
	[SerializeField]
	private float lifespan; //Field offset: 0x44
	public int lifespanFrames; //Field offset: 0x48

	public ProjectileSpeedTowerMutatorModel(string name, ConditionalModel conditionalId, string mutationId, float speedModifier, float lifespan) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

