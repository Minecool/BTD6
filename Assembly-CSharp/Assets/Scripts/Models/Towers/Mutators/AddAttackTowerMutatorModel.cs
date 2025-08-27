namespace Assets.Scripts.Models.Towers.Mutators;

[Implementation(typeof(AddAttackTowerMutator), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddAttackTowerMutatorModel : TowerMutatorModel
{
	public TowerBehaviorModel attackModel; //Field offset: 0x40
	[SerializeField]
	private float lifespan; //Field offset: 0x48
	public int lifespanFrames; //Field offset: 0x4C

	public AddAttackTowerMutatorModel(string name, ConditionalModel conditionalId, string mutationId, TowerBehaviorModel attackModel, float lifespan) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

