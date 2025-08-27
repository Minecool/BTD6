namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(AddBehaviorModifierForTag), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddBehaviorModifierForTagModel : ProjectileBehaviorModel
{
	public string tag; //Field offset: 0x38
	public string mutatorId; //Field offset: 0x40
	public float mutatorMultiplier; //Field offset: 0x48

	public AddBehaviorModifierForTagModel(string name, string tag, string slowId, float mutatorMultiplier) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

