namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class ShowPopupHintAction : HudModifier
{
	public ToggleModdifier showOrDismissHint; //Field offset: 0x28
	public int hintIndex; //Field offset: 0x2C

	public virtual Model Model
	{
		 get { } //Length: 111
	}

	public ShowPopupHintAction() { }

	public virtual Model get_Model() { }

}

