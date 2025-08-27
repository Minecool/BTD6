namespace UnityEngine;

[NativeHeader("Modules/Wind/Public/Wind.h")]
public class WindZone : Component
{

	public WindZoneMode mode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public float radius
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public float windMain
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public float windPulseFrequency
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public float windPulseMagnitude
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public float windTurbulence
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public WindZone() { }

	public WindZoneMode get_mode() { }

	public float get_radius() { }

	public float get_windMain() { }

	public float get_windPulseFrequency() { }

	public float get_windPulseMagnitude() { }

	public float get_windTurbulence() { }

	public void set_mode(WindZoneMode value) { }

	public void set_radius(float value) { }

	public void set_windMain(float value) { }

	public void set_windPulseFrequency(float value) { }

	public void set_windPulseMagnitude(float value) { }

	public void set_windTurbulence(float value) { }

}

