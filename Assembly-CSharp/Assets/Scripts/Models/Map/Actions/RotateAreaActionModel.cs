namespace Assets.Scripts.Models.Map.Actions;

[Implementation(typeof(RotateAreaAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RotateAreaActionModel : MapActionModel
{
	public string areaName; //Field offset: 0x38
	public float rotation; //Field offset: 0x40
	public float duration; //Field offset: 0x44
	public RotateModelAction[] rotationActions; //Field offset: 0x48
	public AudioClip startSound; //Field offset: 0x50
	public AudioClip stopSound; //Field offset: 0x58

	public RotateAreaActionModel(string name, string areaName, float rotation, float duration, RotateModelAction[] rotatingModels, AudioClip startSound, AudioClip stopSound) { }

}

