namespace Assets.Scripts.Models.Profile;

public class TowerDiscountSaveDataModel
{
	public string discountName; //Field offset: 0x10
	public int charges; //Field offset: 0x18
	public String[] towers; //Field offset: 0x20
	public float multiplier; //Field offset: 0x28
	public float subtraction; //Field offset: 0x2C

	public TowerDiscountSaveDataModel() { }

}

