namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "EziliSupport", menuName = "BTD6/Behaviors/Towers/EziliSupport")]
public class EziliSupport : TowerBehavior
{
	public float necroPierceMult; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 124
	}

	public EziliSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

