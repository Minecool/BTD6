namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "DisablerTower", menuName = "BTD6/Behaviors/Towers/DisablerTower")]
public class DisablerTower : Behavior<DisablerTowerModel>
{
	public string disableComponentById; //Field offset: 0x28

	public virtual DisablerTowerModel Def
	{
		 get { } //Length: 149
	}

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	public DisablerTower() { }

	public virtual DisablerTowerModel get_Def() { }

	public virtual Model get_Model() { }

}

