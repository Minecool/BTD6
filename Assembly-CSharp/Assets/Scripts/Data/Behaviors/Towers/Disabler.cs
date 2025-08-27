namespace Assets.Scripts.Data.Behaviors.Towers;

public abstract class Disabler : Behavior<DisableContinueModModel>
{
	public ScriptableObject component; //Field offset: 0x28
	public bool isDisabled; //Field offset: 0x30

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	protected Disabler() { }

	public virtual Model get_Model() { }

}

