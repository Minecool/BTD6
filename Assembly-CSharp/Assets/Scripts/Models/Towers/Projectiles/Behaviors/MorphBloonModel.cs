namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(MorphBloon), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MorphBloonModel : ProjectileBehaviorModel
{
	public string bloonId; //Field offset: 0x38

	public MorphBloonModel(string name, string bloonId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

