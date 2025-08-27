namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(AcidicMixtureCheck), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AcidicMixtureCheckModel : TowerBehaviorModel
{
	public int maxCount; //Field offset: 0x30
	public string mutationId; //Field offset: 0x38

	public AcidicMixtureCheckModel(string name, int maxCount, string mutationId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

