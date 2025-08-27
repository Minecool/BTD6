namespace Assets.Scripts.Models.Towers.Mutators;

public abstract class TowerMutatorModel : Model
{
	public string mutationId; //Field offset: 0x30
	public ConditionalModel conditionalId; //Field offset: 0x38

	protected TowerMutatorModel(string name) { }

}

