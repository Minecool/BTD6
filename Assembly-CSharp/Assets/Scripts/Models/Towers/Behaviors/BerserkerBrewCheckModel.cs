namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(BerserkerBrewCheck), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BerserkerBrewCheckModel : TowerBehaviorModel
{
	public int maxCount; //Field offset: 0x30
	public string mutationId; //Field offset: 0x38

	public BerserkerBrewCheckModel(string name, int maxCount, string mutationId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

