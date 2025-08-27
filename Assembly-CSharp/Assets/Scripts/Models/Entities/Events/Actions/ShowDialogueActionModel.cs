namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(ShowDialogueAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ShowDialogueActionModel : EntityActionModel
{
	public DialogueData dialogue; //Field offset: 0x38

	public ShowDialogueActionModel(string name, DialogueData dialogue) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

