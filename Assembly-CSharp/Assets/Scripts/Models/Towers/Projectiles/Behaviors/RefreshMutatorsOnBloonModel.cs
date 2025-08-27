namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(RefreshMutatorsOnBloon), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RefreshMutatorsOnBloonModel : ProjectileBehaviorModel
{
	public string mutatorId; //Field offset: 0x38
	public String[] mutatorIds; //Field offset: 0x40
	public string mutatorKey; //Field offset: 0x48
	public String[] mutatorKeys; //Field offset: 0x50

	public RefreshMutatorsOnBloonModel(string name, string mutatorId, string mutatorKey) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

