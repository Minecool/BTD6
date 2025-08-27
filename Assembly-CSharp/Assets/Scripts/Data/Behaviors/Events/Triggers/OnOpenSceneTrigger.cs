namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class OnOpenSceneTrigger : EntityTrigger
{
	[SceneName]
	public string Scene; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 90
	}

	public OnOpenSceneTrigger() { }

	public virtual Model get_Model() { }

}

