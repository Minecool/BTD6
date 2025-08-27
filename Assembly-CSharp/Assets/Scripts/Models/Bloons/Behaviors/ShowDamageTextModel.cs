namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(ShowDamageText), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ShowDamageTextModel : BloonBehaviorModel
{
	public bool showText; //Field offset: 0x30

	public ShowDamageTextModel() { }

	public ShowDamageTextModel(string name, bool showText) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

