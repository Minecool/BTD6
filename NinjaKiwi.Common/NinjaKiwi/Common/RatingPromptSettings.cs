namespace NinjaKiwi.Common;

public class RatingPromptSettings
{
	public bool ratingpromptenabled; //Field offset: 0x10
	public int requiredeventcount; //Field offset: 0x14
	public int requiredusecount; //Field offset: 0x18
	public int retryhours; //Field offset: 0x1C
	public int maxpromptcount; //Field offset: 0x20
	public string ratingurl; //Field offset: 0x28

	public RatingPromptSettings() { }

}

