namespace Assets.Scripts.Models.Towers.Mutators;

[Implementation(typeof(ReloadTimeTowerMutator), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ReloadTimeTowerMutatorModel : TowerMutatorModel
{
	public float multiplier; //Field offset: 0x40
	[SerializeField]
	private float lifespan; //Field offset: 0x44
	public int lifespanFrames; //Field offset: 0x48

	public ReloadTimeTowerMutatorModel(string name, ConditionalModel conditionalId, string mutationId, float multiplier, float lifespan) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

