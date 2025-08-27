namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(GainLivesAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class GainLivesActionModel : EntityActionModel
{
	public float amount; //Field offset: 0x38

	public GainLivesActionModel(string name, float amount) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

