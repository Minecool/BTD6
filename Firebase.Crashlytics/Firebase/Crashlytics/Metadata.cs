namespace Firebase.Crashlytics;

internal class Metadata
{
	public string uv; //Field offset: 0x10
	public bool idb; //Field offset: 0x18
	public string pt; //Field offset: 0x20
	public int pc; //Field offset: 0x28
	public int pf; //Field offset: 0x2C
	public int sms; //Field offset: 0x30
	public int gms; //Field offset: 0x34
	public int gdid; //Field offset: 0x38
	public int gdvid; //Field offset: 0x3C
	public string gdn; //Field offset: 0x40
	public string gdv; //Field offset: 0x48
	public string gdver; //Field offset: 0x50
	public GraphicsDeviceType gdt; //Field offset: 0x58
	public int gsl; //Field offset: 0x5C
	public int grtc; //Field offset: 0x60
	public CopyTextureSupport gcts; //Field offset: 0x64
	public int gmts; //Field offset: 0x68
	public string ss; //Field offset: 0x70
	public float sdpi; //Field offset: 0x78
	public int srr; //Field offset: 0x7C

	public Metadata() { }

}

