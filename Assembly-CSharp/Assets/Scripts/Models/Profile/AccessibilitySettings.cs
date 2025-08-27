namespace Assets.Scripts.Models.Profile;

public class AccessibilitySettings
{
	[JsonProperty]
	private DisplayCategory categoryFilter; //Field offset: 0x10
	[JsonProperty]
	private Dictionary<DisplayCategory, Single> categoryScales; //Field offset: 0x18
	[JsonProperty]
	private bool stereoEnabled; //Field offset: 0x20
	[JsonProperty]
	private float stereoScale; //Field offset: 0x24
	[JsonProperty]
	private TextureReference rangeCircleTexture; //Field offset: 0x28
	[JsonProperty]
	private TextureReference rangeCircleOutline; //Field offset: 0x30
	[JsonProperty]
	private bool ambientMapEffectsEnabled; //Field offset: 0x38
	[JsonProperty]
	private bool towerPlacementSnappingEnabled; //Field offset: 0x39

	[JsonIgnore]
	public bool AmbientMapEffectsEnabled
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	[JsonIgnore]
	public TextureReference RangeCircleOutline
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	[JsonIgnore]
	public TextureReference RangeCircleTexture
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	[JsonIgnore]
	public bool StereoEnabled
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	[JsonIgnore]
	public float StereoScale
	{
		 get { } //Length: 16
		 set { } //Length: 6
	}

	public AccessibilitySettings() { }

	public bool get_AmbientMapEffectsEnabled() { }

	public TextureReference get_RangeCircleOutline() { }

	public TextureReference get_RangeCircleTexture() { }

	public bool get_StereoEnabled() { }

	public float get_StereoScale() { }

	public float GetScaleForCategory(DisplayCategory category) { }

	public bool IsCategoryEnabled(DisplayCategory category) { }

	public bool IsTowerSnappingEnabled() { }

	public void set_AmbientMapEffectsEnabled(bool value) { }

	public void set_RangeCircleOutline(TextureReference value) { }

	public void set_RangeCircleTexture(TextureReference value) { }

	public void set_StereoEnabled(bool value) { }

	public void set_StereoScale(float value) { }

	public void SetScaleForCategory(DisplayCategory category, float scale) { }

	public void ToggleCategoryEnabled(DisplayCategory category) { }

	public void ToggleTowerPlacementSnapping(bool enabled) { }

}

