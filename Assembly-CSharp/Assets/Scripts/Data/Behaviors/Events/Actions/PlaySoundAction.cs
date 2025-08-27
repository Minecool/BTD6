namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class PlaySoundAction : EntityAction
{
	[SerializeField]
	public Sound sound; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 121
	}

	public PlaySoundAction() { }

	public virtual Model get_Model() { }

}

