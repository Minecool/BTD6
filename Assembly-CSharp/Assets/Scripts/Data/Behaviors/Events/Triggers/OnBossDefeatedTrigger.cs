namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class OnBossDefeatedTrigger : EntityTrigger
{
	public int tier; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 89
	}

	public OnBossDefeatedTrigger() { }

	public virtual Model get_Model() { }

}

