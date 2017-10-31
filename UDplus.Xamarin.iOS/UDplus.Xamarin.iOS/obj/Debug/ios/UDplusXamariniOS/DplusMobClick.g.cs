//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;

namespace UDplus.Xamarin.iOS {
	[Register("DplusMobClick", true)]
	public unsafe partial class DplusMobClick : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("DplusMobClick");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public DplusMobClick () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected DplusMobClick (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal DplusMobClick (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("clearSuperProperties")]
		[CompilerGenerated]
		public static void ClearSuperProperties ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("clearSuperProperties"));
		}
		
		[Export ("getSuperProperty:")]
		[CompilerGenerated]
		public static string GetSuperProperty (string propertyName)
		{
			if (propertyName == null)
				throw new ArgumentNullException ("propertyName");
			var nspropertyName = NSString.CreateNative (propertyName);
			
			string ret;
			ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("getSuperProperty:"), nspropertyName));
			NSString.ReleaseNative (nspropertyName);
			
			return ret;
		}
		
		[Export ("registerSuperProperty:")]
		[CompilerGenerated]
		public static void RegisterSuperProperty (NSDictionary property)
		{
			if (property == null)
				throw new ArgumentNullException ("property");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("registerSuperProperty:"), property.Handle);
		}
		
		[Export ("setFirstLaunchEvent:")]
		[CompilerGenerated]
		public static void SetFirstLaunchEvent (NSObject[] eventList)
		{
			if (eventList == null)
				throw new ArgumentNullException ("eventList");
			var nsa_eventList = NSArray.FromNSObjects (eventList);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setFirstLaunchEvent:"), nsa_eventList.Handle);
			nsa_eventList.Dispose ();
			
		}
		
		[Export ("track:")]
		[CompilerGenerated]
		public static void Track (string eventName)
		{
			if (eventName == null)
				throw new ArgumentNullException ("eventName");
			var nseventName = NSString.CreateNative (eventName);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("track:"), nseventName);
			NSString.ReleaseNative (nseventName);
			
		}
		
		[Export ("track:property:")]
		[CompilerGenerated]
		public static void Track (string eventName, NSDictionary property)
		{
			if (eventName == null)
				throw new ArgumentNullException ("eventName");
			if (property == null)
				throw new ArgumentNullException ("property");
			var nseventName = NSString.CreateNative (eventName);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("track:property:"), nseventName, property.Handle);
			NSString.ReleaseNative (nseventName);
			
		}
		
		[Export ("unregisterSuperProperty:")]
		[CompilerGenerated]
		public static void UnregisterSuperProperty (string propertyName)
		{
			if (propertyName == null)
				throw new ArgumentNullException ("propertyName");
			var nspropertyName = NSString.CreateNative (propertyName);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("unregisterSuperProperty:"), nspropertyName);
			NSString.ReleaseNative (nspropertyName);
			
		}
		
		[CompilerGenerated]
		public static NSDictionary SuperProperties {
			[Export ("getSuperProperties")]
			get {
				NSDictionary ret;
				ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getSuperProperties")));
				return ret;
			}
			
		}
		
	} /* class DplusMobClick */
}
