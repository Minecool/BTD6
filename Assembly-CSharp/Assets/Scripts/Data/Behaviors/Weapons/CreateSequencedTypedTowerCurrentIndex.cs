namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "CreateSequencedTypedTowerCurrentIndex", menuName = "BTD6/Behaviors/Weapons/CreateSequencedTypedTowerCurrentIndex")]
public class CreateSequencedTypedTowerCurrentIndex : WeaponBehavior
{
	public bool onlyAllowOneTowerPerType; //Field offset: 0x30
	public SequencedTower[] towers; //Field offset: 0x38

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 508
	}

	public CreateSequencedTypedTowerCurrentIndex() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

