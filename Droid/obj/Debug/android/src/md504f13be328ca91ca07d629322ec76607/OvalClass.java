package md504f13be328ca91ca07d629322ec76607;


public class OvalClass
	extends android.graphics.drawable.shapes.OvalShape
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("LoginNavigation.OvalClass, LoginNavigation, Version=1.0.6044.27064, Culture=neutral, PublicKeyToken=null", OvalClass.class, __md_methods);
	}


	public OvalClass () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OvalClass.class)
			mono.android.TypeManager.Activate ("LoginNavigation.OvalClass, LoginNavigation, Version=1.0.6044.27064, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
