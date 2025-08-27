namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class SpawnEffectAction : EntityAction
{
	[SerializeField]
	public PrefabReference effect; //Field offset: 0x28
	[SerializeField]
	public float lifespan; //Field offset: 0x30

	public virtual Model Model
	{
		 get { } //Length: 114
	}

	public SpawnEffectAction() { }

	public virtual Model get_Model() { }

}

