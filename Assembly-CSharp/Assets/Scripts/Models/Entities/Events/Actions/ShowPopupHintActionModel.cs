namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(ShowPopupHintAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ShowPopupHintActionModel : EntityActionModel
{
	public ToggleModdifier showOrDismissHint; //Field offset: 0x38
	public int hintIndex; //Field offset: 0x3C

	public ShowPopupHintActionModel(string name, ToggleModdifier showOrDismissHint, int hintIndex) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

