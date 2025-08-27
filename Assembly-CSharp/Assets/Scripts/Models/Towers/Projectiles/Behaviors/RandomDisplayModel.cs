namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(RandomDisplay), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RandomDisplayModel : ProjectileBehaviorModel
{
	public PrefabReference[] displayPaths; //Field offset: 0x38
	public bool applyRandomRotation; //Field offset: 0x40

	public RandomDisplayModel(string name, PrefabReference[] displayPaths, bool applyRandomRotation) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

