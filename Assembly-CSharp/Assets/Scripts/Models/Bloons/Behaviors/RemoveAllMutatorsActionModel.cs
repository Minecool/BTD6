namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(RemoveAllMutatorsAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RemoveAllMutatorsActionModel : BloonBehaviorActionModel
{
	public String[] mutatorsToIgnoreList; //Field offset: 0x38

	public RemoveAllMutatorsActionModel() { }

	public RemoveAllMutatorsActionModel(string name, string actionId, String[] mutatorsToIgnoreList) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

