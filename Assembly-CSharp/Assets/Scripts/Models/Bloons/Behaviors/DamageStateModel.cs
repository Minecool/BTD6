namespace Assets.Scripts.Models.Bloons.Behaviors;

public class DamageStateModel : BloonBehaviorModel
{
	public PrefabReference displayPath; //Field offset: 0x30
	public float healthPercent; //Field offset: 0x38

	public DamageStateModel() { }

	public DamageStateModel(string name, PrefabReference displayPath, float healthPercent) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

