namespace Assets.Scripts.Models.ServerEvents;

public class FilterSettings
{
	public SliderSettings minRounds; //Field offset: 0x10
	public SliderSettings maxRounds; //Field offset: 0x18
	public SliderSettings minPaths; //Field offset: 0x20
	public SliderSettings maxPaths; //Field offset: 0x28

	public FilterSettings() { }

}

