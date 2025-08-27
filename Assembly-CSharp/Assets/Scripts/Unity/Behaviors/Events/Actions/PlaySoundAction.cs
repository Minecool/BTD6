namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class PlaySoundAction : EntityAction
{
	[SerializeField]
	public Sound sound; //Field offset: 0x18

	public virtual Model Model
	{
		 get { } //Length: 121
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public PlaySoundAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

