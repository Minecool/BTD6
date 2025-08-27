namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "AdoraTransformSound", menuName = "BTD6/Behaviors/Towers/AdoraTransformSound")]
public class AdoraTransformSound : TowerBehavior
{
	public Sound newSelectSound01; //Field offset: 0x30
	public Sound newSelectSound02; //Field offset: 0x38
	public Sound newSelectSound03; //Field offset: 0x40
	public Sound newSelectSound04; //Field offset: 0x48
	public Sound newSelectSound05; //Field offset: 0x50
	public Sound newSelectSound06; //Field offset: 0x58
	public Sound newSelectAltSound01; //Field offset: 0x60
	public Sound newSelectAltSound02; //Field offset: 0x68
	public Sound newLeakSound01; //Field offset: 0x70
	public Sound newLeakSound02; //Field offset: 0x78
	public Sound newMoabDestroyedSound01; //Field offset: 0x80
	public Sound newMoabDestroyedSound02; //Field offset: 0x88
	public Sound newMoabWarningSound; //Field offset: 0x90
	public Sound newBfbWarningSound; //Field offset: 0x98
	public Sound newZomgWarningSound; //Field offset: 0xA0
	public Sound newDdtWarningSound; //Field offset: 0xA8
	public Sound newBadWarningSound; //Field offset: 0xB0
	public Sound newUltimate3Sound; //Field offset: 0xB8
	public Sound newUltimate7Sound; //Field offset: 0xC0
	public Sound newUltimate10Sound; //Field offset: 0xC8
	public Sound transformSound; //Field offset: 0xD0

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 1310
	}

	public AdoraTransformSound() { }

	public virtual TowerBehaviorModel get_Def() { }

	public void OnEnable() { }

}

