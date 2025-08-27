namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(LoseLivesAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class LoseLivesActionModel : EntityActionModel
{
	public float amount; //Field offset: 0x38

	public LoseLivesActionModel(string name, float amount) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

