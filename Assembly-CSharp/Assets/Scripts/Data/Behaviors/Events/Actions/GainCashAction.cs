namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class GainCashAction : EntityAction
{
	public float amount; //Field offset: 0x28
	public bool showFloatingText; //Field offset: 0x2C
	public PrefabReference textAssetId; //Field offset: 0x30

	public virtual Model Model
	{
		 get { } //Length: 134
	}

	public GainCashAction() { }

	public virtual Model get_Model() { }

}

