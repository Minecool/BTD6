namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "SequencedTower", menuName = "BTD6/Behaviors/Weapons/SequencedTower")]
public class SequencedTower : WeaponBehavior
{
	public Tower tower; //Field offset: 0x30
	public PrefabReference display; //Field offset: 0x38

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 62
	}

	public SequencedTower() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

