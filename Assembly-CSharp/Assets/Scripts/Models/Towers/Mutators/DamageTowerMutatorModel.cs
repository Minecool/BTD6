namespace Assets.Scripts.Models.Towers.Mutators;

[Implementation(typeof(DamageTowerMutator), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageTowerMutatorModel : TowerMutatorModel
{
	public float damage; //Field offset: 0x40
	[SerializeField]
	private float lifespan; //Field offset: 0x44
	public int lifespanFrames; //Field offset: 0x48

	public DamageTowerMutatorModel(string name, ConditionalModel conditionalId, string mutationId, float damage, float lifespan) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

