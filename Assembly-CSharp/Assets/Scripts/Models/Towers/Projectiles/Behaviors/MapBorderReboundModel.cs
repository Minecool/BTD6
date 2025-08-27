namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(MapBorderRebound), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MapBorderReboundModel : ProjectileBehaviorModel
{
	public bool changeRotation; //Field offset: 0x38

	public MapBorderReboundModel(string name, bool changeRotation) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

