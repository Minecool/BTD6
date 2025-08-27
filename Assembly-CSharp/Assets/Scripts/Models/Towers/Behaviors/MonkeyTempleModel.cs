namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(MonkeyTemple), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MonkeyTempleModel : TowerBehaviorModel
{
	internal class TCBOOMutator : BehaviorMutator
	{

		public TCBOOMutator(string mutationId) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public int towerGroupCount; //Field offset: 0x30
	public EffectModel effectModel; //Field offset: 0x38
	public EffectModel towerEffectModel; //Field offset: 0x40
	public EffectModel heroEffectModel; //Field offset: 0x48
	public SoundModel darkTransformSound; //Field offset: 0x50
	public SoundModel darkAltTransformSound; //Field offset: 0x58
	public int animation; //Field offset: 0x60
	public int upgradeAnimation; //Field offset: 0x64
	[SerializeField]
	private float weaponDelay; //Field offset: 0x68
	public int weaponDelayFrames; //Field offset: 0x6C
	public string templeId; //Field offset: 0x70
	public bool checkForThereCanOnlyBeOne; //Field offset: 0x78
	public EffectModel transformationEffect; //Field offset: 0x80
	public EffectModel theAntiBloonSacrificeEffect; //Field offset: 0x88
	public EffectModel legendOfTheNightSacrificeEffect; //Field offset: 0x90
	public int transformationAnimation; //Field offset: 0x98
	public float transformationWeaponDelay; //Field offset: 0x9C
	public float heroOverlapYAdjustment; //Field offset: 0xA0
	private TCBOOMutator tcbooMutator; //Field offset: 0xA8

	public TCBOOMutator TcbooMutator
	{
		 get { } //Length: 229
	}

	public MonkeyTempleModel(string name, int towerGroupCount, EffectModel effectModel, EffectModel towerEffectModel, EffectModel heroEffectModel, SoundModel darkTransformSound, SoundModel darkAltTransformSound, int animation, int upgradeAnimation, float weaponDelay, string templeId, EffectModel transformationEffect, EffectModel theAntiBloonSacrificeEffect, EffectModel legendOfTheNightSacrificeEffect, int transformationAnimation, float transformationWeaponDelay, float heroOverlapYAdjustment) { }

	public virtual Model Clone() { }

	public TCBOOMutator get_TcbooMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

