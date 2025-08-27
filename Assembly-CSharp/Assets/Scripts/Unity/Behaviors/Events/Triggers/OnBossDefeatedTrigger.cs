namespace Assets.Scripts.Unity.Behaviors.Events.Triggers;

public class OnBossDefeatedTrigger : EntityTrigger
{
	public int tier; //Field offset: 0x18

	public virtual Model Model
	{
		 get { } //Length: 89
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public OnBossDefeatedTrigger() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

