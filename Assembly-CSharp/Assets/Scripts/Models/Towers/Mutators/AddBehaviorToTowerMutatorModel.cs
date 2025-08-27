namespace Assets.Scripts.Models.Towers.Mutators;

[Implementation(typeof(AddBehaviorToTowerMutator), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddBehaviorToTowerMutatorModel : TowerMutatorModel
{
	[SerializeField]
	private float lifespan; //Field offset: 0x40
	public int lifespanFrames; //Field offset: 0x44
	public TowerBehaviorModel[] behaviors; //Field offset: 0x48

	public AddBehaviorToTowerMutatorModel(string name, ConditionalModel conditionalId, string mutationId, float lifespan, TowerBehaviorModel[] behaviors) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

