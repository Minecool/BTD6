namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class ShowPopupHintAction : HudModifier
{
	public ToggleModdifier showOrDismissHint; //Field offset: 0x18
	public int hintIndex; //Field offset: 0x1C

	public virtual Model Model
	{
		 get { } //Length: 111
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public ShowPopupHintAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

	public virtual void ModifyHud(HookCondition condition, object metadata) { }

}

