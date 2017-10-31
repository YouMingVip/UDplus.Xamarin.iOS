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
	[Register("MobClickGameAnalytics", true)]
	public unsafe partial class MobClickGameAnalytics : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobClickGameAnalytics");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobClickGameAnalytics () : base (NSObjectFlag.Empty)
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
		protected MobClickGameAnalytics (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobClickGameAnalytics (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("bonus:source:")]
		[CompilerGenerated]
		public static void Bonus (global::System.Double coin, int source)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_Double_int (class_ptr, Selector.GetHandle ("bonus:source:"), coin, source);
		}
		
		[Export ("bonus:amount:price:source:")]
		[CompilerGenerated]
		public static void Bonus (string item, int amount, global::System.Double price, int source)
		{
			if (item == null)
				throw new ArgumentNullException ("item");
			var nsitem = NSString.CreateNative (item);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int_Double_int (class_ptr, Selector.GetHandle ("bonus:amount:price:source:"), nsitem, amount, price, source);
			NSString.ReleaseNative (nsitem);
			
		}
		
		[Export ("buy:amount:price:")]
		[CompilerGenerated]
		public static void Buy (string item, int amount, global::System.Double price)
		{
			if (item == null)
				throw new ArgumentNullException ("item");
			var nsitem = NSString.CreateNative (item);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int_Double (class_ptr, Selector.GetHandle ("buy:amount:price:"), nsitem, amount, price);
			NSString.ReleaseNative (nsitem);
			
		}
		
		[Export ("exchange:currencyAmount:currencyType:virtualCurrencyAmount:paychannel:")]
		[CompilerGenerated]
		public static void Exchange (string orderId, global::System.Double currencyAmount, string currencyType, global::System.Double virtualAmount, int channel)
		{
			if (orderId == null)
				throw new ArgumentNullException ("orderId");
			if (currencyType == null)
				throw new ArgumentNullException ("currencyType");
			var nsorderId = NSString.CreateNative (orderId);
			var nscurrencyType = NSString.CreateNative (currencyType);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Double_IntPtr_Double_int (class_ptr, Selector.GetHandle ("exchange:currencyAmount:currencyType:virtualCurrencyAmount:paychannel:"), nsorderId, currencyAmount, nscurrencyType, virtualAmount, channel);
			NSString.ReleaseNative (nsorderId);
			NSString.ReleaseNative (nscurrencyType);
			
		}
		
		[Export ("failLevel:")]
		[CompilerGenerated]
		public static void FailLevel (string level)
		{
			if (level == null)
				throw new ArgumentNullException ("level");
			var nslevel = NSString.CreateNative (level);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("failLevel:"), nslevel);
			NSString.ReleaseNative (nslevel);
			
		}
		
		[Export ("finishLevel:")]
		[CompilerGenerated]
		public static void FinishLevel (string level)
		{
			if (level == null)
				throw new ArgumentNullException ("level");
			var nslevel = NSString.CreateNative (level);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("finishLevel:"), nslevel);
			NSString.ReleaseNative (nslevel);
			
		}
		
		[Export ("pay:source:coin:")]
		[CompilerGenerated]
		public static void Pay (global::System.Double cash, int source, global::System.Double coin)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_Double_int_Double (class_ptr, Selector.GetHandle ("pay:source:coin:"), cash, source, coin);
		}
		
		[Export ("pay:source:item:amount:price:")]
		[CompilerGenerated]
		public static void Pay (global::System.Double cash, int source, string item, int amount, global::System.Double price)
		{
			if (item == null)
				throw new ArgumentNullException ("item");
			var nsitem = NSString.CreateNative (item);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_Double_int_IntPtr_int_Double (class_ptr, Selector.GetHandle ("pay:source:item:amount:price:"), cash, source, nsitem, amount, price);
			NSString.ReleaseNative (nsitem);
			
		}
		
		[Export ("profileSignInWithPUID:")]
		[CompilerGenerated]
		public static void ProfileSignInWithPUID (string puid)
		{
			if (puid == null)
				throw new ArgumentNullException ("puid");
			var nspuid = NSString.CreateNative (puid);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("profileSignInWithPUID:"), nspuid);
			NSString.ReleaseNative (nspuid);
			
		}
		
		[Export ("profileSignInWithPUID:provider:")]
		[CompilerGenerated]
		public static void ProfileSignInWithPUID (string puid, string provider)
		{
			if (puid == null)
				throw new ArgumentNullException ("puid");
			if (provider == null)
				throw new ArgumentNullException ("provider");
			var nspuid = NSString.CreateNative (puid);
			var nsprovider = NSString.CreateNative (provider);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("profileSignInWithPUID:provider:"), nspuid, nsprovider);
			NSString.ReleaseNative (nspuid);
			NSString.ReleaseNative (nsprovider);
			
		}
		
		[Export ("profileSignOff")]
		[CompilerGenerated]
		public static void ProfileSignOff ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("profileSignOff"));
		}
		
		[Export ("setUserID:sex:age:platform:")]
		[CompilerGenerated]
		public static void SetUserID (string userId, int sex, int age, string platform)
		{
			if (userId == null)
				throw new ArgumentNullException ("userId");
			if (platform == null)
				throw new ArgumentNullException ("platform");
			var nsuserId = NSString.CreateNative (userId);
			var nsplatform = NSString.CreateNative (platform);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int_int_IntPtr (class_ptr, Selector.GetHandle ("setUserID:sex:age:platform:"), nsuserId, sex, age, nsplatform);
			NSString.ReleaseNative (nsuserId);
			NSString.ReleaseNative (nsplatform);
			
		}
		
		[Export ("setUserLevel:")]
		[CompilerGenerated]
		public static void SetUserLevel (string level)
		{
			if (level == null)
				throw new ArgumentNullException ("level");
			var nslevel = NSString.CreateNative (level);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setUserLevel:"), nslevel);
			NSString.ReleaseNative (nslevel);
			
		}
		
		[Export ("setUserLevelId:")]
		[CompilerGenerated]
		public static void SetUserLevelId (int level)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_int (class_ptr, Selector.GetHandle ("setUserLevelId:"), level);
		}
		
		[Export ("startLevel:")]
		[CompilerGenerated]
		public static void StartLevel (string level)
		{
			if (level == null)
				throw new ArgumentNullException ("level");
			var nslevel = NSString.CreateNative (level);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("startLevel:"), nslevel);
			NSString.ReleaseNative (nslevel);
			
		}
		
		[Export ("use:amount:price:")]
		[CompilerGenerated]
		public static void Use (string item, int amount, global::System.Double price)
		{
			if (item == null)
				throw new ArgumentNullException ("item");
			var nsitem = NSString.CreateNative (item);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int_Double (class_ptr, Selector.GetHandle ("use:amount:price:"), nsitem, amount, price);
			NSString.ReleaseNative (nsitem);
			
		}
		
	} /* class MobClickGameAnalytics */
}
