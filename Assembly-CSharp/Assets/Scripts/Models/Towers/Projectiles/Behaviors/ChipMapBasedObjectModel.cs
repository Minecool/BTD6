namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(ChipMapBasedObject), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ChipMapBasedObjectModel : ProjectileBehaviorModel
{
	public string chipTag; //Field offset: 0x38

	public ChipMapBasedObjectModel(string name, string chipTag) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

