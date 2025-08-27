namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(AddFreeTowerAfterRounds), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddFreeTowerAfterRoundsModel : TowerBehaviorModel
{
	public string towerId; //Field offset: 0x30
	public int rounds; //Field offset: 0x38

	public AddFreeTowerAfterRoundsModel(string name, string towerId, int rounds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

