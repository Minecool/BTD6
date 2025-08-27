namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(SpawnChildren), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SpawnChildrenModel : BloonBehaviorModel
{
	public String[] children; //Field offset: 0x30

	public SpawnChildrenModel() { }

	public SpawnChildrenModel(string name, String[] children) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

