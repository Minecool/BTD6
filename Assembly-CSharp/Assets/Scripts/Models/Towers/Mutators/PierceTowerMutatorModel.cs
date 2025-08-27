namespace Assets.Scripts.Models.Towers.Mutators;

[Implementation(typeof(PierceTowerMutator), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PierceTowerMutatorModel : TowerMutatorModel
{
	public int pierce; //Field offset: 0x40
	[SerializeField]
	private float lifespan; //Field offset: 0x44
	public int lifespanFrames; //Field offset: 0x48

	public PierceTowerMutatorModel(string name, ConditionalModel conditionalId, string mutationId, int pierce, float lifespan) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

