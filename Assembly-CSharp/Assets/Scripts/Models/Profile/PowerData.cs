namespace Assets.Scripts.Models.Profile;

public class PowerData
{
	public KonFuze_NoShuffle quantity; //Field offset: 0x10
	public bool isNew; //Field offset: 0x18

	[JsonIgnore]
	public int Quantity
	{
		 get { } //Length: 159
		 set { } //Length: 220
	}

	public PowerData() { }

	public PowerData(int quantity) { }

	public int get_Quantity() { }

	public void set_Quantity(int value) { }

}

