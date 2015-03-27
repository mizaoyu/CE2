package ce2;


public class CardService
	extends android.nfc.cardemulation.HostApduService
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onDeactivated:(I)V:GetOnDeactivated_IHandler\n" +
			"n_processCommandApdu:([BLandroid/os/Bundle;)[B:GetProcessCommandApdu_arrayBLandroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("CE2.CardService, CE2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CardService.class, __md_methods);
	}


	public CardService () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CardService.class)
			mono.android.TypeManager.Activate ("CE2.CardService, CE2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onDeactivated (int p0)
	{
		n_onDeactivated (p0);
	}

	private native void n_onDeactivated (int p0);


	public byte[] processCommandApdu (byte[] p0, android.os.Bundle p1)
	{
		return n_processCommandApdu (p0, p1);
	}

	private native byte[] n_processCommandApdu (byte[] p0, android.os.Bundle p1);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
