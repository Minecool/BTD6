namespace Assets.Scripts.Models.Towers.Mutators;

[Implementation(typeof(AddTowerToTowerMutator), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddTowerToTowerMutatorModel : TowerMutatorModel
{
	public TowerModel towerModel; //Field offset: 0x40
	[SerializeField]
	private float lifespan; //Field offset: 0x48
	public int lifespanFrames; //Field offset: 0x4C

	public AddTowerToTowerMutatorModel(string name, ConditionalModel conditionalId, string mutationId, TowerModel towerModel, float lifespan) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

