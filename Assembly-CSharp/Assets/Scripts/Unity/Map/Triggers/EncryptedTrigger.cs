namespace Assets.Scripts.Unity.Map.Triggers;

public class EncryptedTrigger : MapTrigger
{
	private EncryptedTriggerModel def; //Field offset: 0x20
	public Area primaryArea; //Field offset: 0x28
	public Area militaryArea; //Field offset: 0x30
	public Area militaryWaterArea; //Field offset: 0x38
	public Area magicArea; //Field offset: 0x40
	public Area supportArea; //Field offset: 0x48
	public Area middleArea; //Field offset: 0x50
	public Area primaryGrave; //Field offset: 0x58
	public Area militaryGrave; //Field offset: 0x60
	public Area magicGrave; //Field offset: 0x68
	public Area supportGrave; //Field offset: 0x70

	public virtual MapTriggerModel Def
	{
		 get { } //Length: 573
	}

	public EncryptedTrigger() { }

	public virtual MapTriggerModel get_Def() { }

}

