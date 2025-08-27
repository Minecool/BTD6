namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(RemoveMutatorsFromBloon), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RemoveMutatorsFromBloonModel : ProjectileBehaviorModel
{
	public string key; //Field offset: 0x38
	public String[] keys; //Field offset: 0x40
	public string mutatorIds; //Field offset: 0x48
	public String[] mutatorIdList; //Field offset: 0x50

	public RemoveMutatorsFromBloonModel(string name, string key, int collisionPass, string mutatorIds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

