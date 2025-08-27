namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class OnCloseSceneTrigger : EntityTrigger
{
	[SceneName]
	public string Scene; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 90
	}

	public OnCloseSceneTrigger() { }

	public virtual Model get_Model() { }

}

