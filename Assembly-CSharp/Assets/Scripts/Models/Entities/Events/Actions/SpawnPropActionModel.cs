namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(SpawnPropAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SpawnPropActionModel : EntityActionModel
{
	public string propName; //Field offset: 0x38

	public SpawnPropActionModel(string name, string propName) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

