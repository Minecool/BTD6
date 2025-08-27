namespace Assets.Scripts.Models.Map.Triggers;

[Implementation(typeof(EncryptedTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EncryptedTriggerModel : MapTriggerModel
{
	public AreaModel primaryArea; //Field offset: 0x38
	public AreaModel militaryArea; //Field offset: 0x40
	public AreaModel militaryWaterArea; //Field offset: 0x48
	public AreaModel magicArea; //Field offset: 0x50
	public AreaModel supportArea; //Field offset: 0x58
	public AreaModel middleArea; //Field offset: 0x60
	public AreaModel primaryGrave; //Field offset: 0x68
	public AreaModel militaryGrave; //Field offset: 0x70
	public AreaModel magicGrave; //Field offset: 0x78
	public AreaModel supportGrave; //Field offset: 0x80

	public EncryptedTriggerModel(string name, AreaModel primaryArea, AreaModel militaryArea, AreaModel militaryWaterArea, AreaModel magicArea, AreaModel supportArea, AreaModel middleArea, AreaModel primaryGrave, AreaModel militaryGrave, AreaModel magicGrave, AreaModel supportGrave) { }

}

