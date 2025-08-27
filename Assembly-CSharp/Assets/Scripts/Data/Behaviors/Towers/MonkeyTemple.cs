namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "MonkeyTemple", menuName = "BTD6/Behaviors/Towers/MonkeyTemple")]
public class MonkeyTemple : TowerBehavior
{
	public int towerGroupCount; //Field offset: 0x30
	public int placeAnimation; //Field offset: 0x34
	public int upgradeAnimation; //Field offset: 0x38
	public float weaponDelay; //Field offset: 0x3C
	public string templeId; //Field offset: 0x40
	public Effect effect; //Field offset: 0x48
	public Effect towerEffect; //Field offset: 0x50
	public Effect heroEffect; //Field offset: 0x58
	public Effect darkTransformationEffect; //Field offset: 0x60
	public Effect darkTheAntiBloonSacrificeEffect; //Field offset: 0x68
	public Effect darkLegendOfTheNightSacrificeEffect; //Field offset: 0x70
	public int darkTransformationAnimation; //Field offset: 0x78
	public float darkTransformationWeaponDelay; //Field offset: 0x7C
	public Sound darkTransformSound; //Field offset: 0x80
	public Sound darkAltTransformSound; //Field offset: 0x88
	public float heroOverlapYAdjustment; //Field offset: 0x90

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 1040
	}

	public MonkeyTemple() { }

	public virtual TowerBehaviorModel get_Def() { }

}

