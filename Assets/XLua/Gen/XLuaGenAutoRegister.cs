﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;
using System.Collections.Generic;
using System.Reflection;


namespace XLua.CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
        
        
        static void wrapInit0(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(DG.Tweening.AutoPlay), DGTweeningAutoPlayWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.AxisConstraint), DGTweeningAxisConstraintWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.Ease), DGTweeningEaseWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.LogBehaviour), DGTweeningLogBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.LoopType), DGTweeningLoopTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.PathMode), DGTweeningPathModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.PathType), DGTweeningPathTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.RotateMode), DGTweeningRotateModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.ScrambleMode), DGTweeningScrambleModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.TweenType), DGTweeningTweenTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.UpdateType), DGTweeningUpdateTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.DOTween), DGTweeningDOTweenWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.DOVirtual), DGTweeningDOVirtualWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.EaseFactory), DGTweeningEaseFactoryWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.Tweener), DGTweeningTweenerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.Tween), DGTweeningTweenWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.Sequence), DGTweeningSequenceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.TweenParams), DGTweeningTweenParamsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.Core.ABSSequentiable), DGTweeningCoreABSSequentiableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.Core.TweenerCore<System.Numerics.Vector3, System.Numerics.Vector3, DG.Tweening.Plugins.Options.VectorOptions>), DGTweeningCoreTweenerCore_3_SystemNumericsVector3SystemNumericsVector3DGTweeningPluginsOptionsVectorOptions_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.Core.TweenerCore<System.Drawing.Color, System.Drawing.Color, DG.Tweening.Plugins.Options.ColorOptions>), DGTweeningCoreTweenerCore_3_SystemDrawingColorSystemDrawingColorDGTweeningPluginsOptionsColorOptions_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions>), DGTweeningCoreTweenerCore_3_SystemSingleSystemSingleDGTweeningPluginsOptionsFloatOptions_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.TweenExtensions), DGTweeningTweenExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.TweenSettingsExtensions), DGTweeningTweenSettingsExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.ShortcutExtensions), DGTweeningShortcutExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.DOTweenModuleUI), DGTweeningDOTweenModuleUIWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.DOTweenModuleSprite), DGTweeningDOTweenModuleSpriteWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.DOTweenModuleAudio), DGTweeningDOTweenModuleAudioWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.DOTweenModulePhysics), DGTweeningDOTweenModulePhysicsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.DOTweenModulePhysics2D), DGTweeningDOTweenModulePhysics2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.BaseClass), TutorialBaseClassWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.TestEnum), TutorialTestEnumWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.DerivedClass), TutorialDerivedClassWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.ICalc), TutorialICalcWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.DerivedClassExtensions), TutorialDerivedClassExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.LuaBehaviour), XLuaTestLuaBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Pedding), XLuaTestPeddingWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.MyStruct), XLuaTestMyStructWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.MyEnum), XLuaTestMyEnumWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.NoGc), XLuaTestNoGcWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WaitForSeconds), UnityEngineWaitForSecondsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.BaseTest), XLuaTestBaseTestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo1Parent), XLuaTestFoo1ParentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo2Parent), XLuaTestFoo2ParentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo1Child), XLuaTestFoo1ChildWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo2Child), XLuaTestFoo2ChildWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo), XLuaTestFooWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.FooExtension), XLuaTestFooExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.DerivedClass.TestEnumInner), TutorialDerivedClassTestEnumInnerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(object), SystemObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Object), UnityEngineObjectWrap.__Register);
        
        }
        
        static void wrapInit1(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector2), UnityEngineVector2Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector3), UnityEngineVector3Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector4), UnityEngineVector4Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Quaternion), UnityEngineQuaternionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Color), UnityEngineColorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray), UnityEngineRayWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Bounds), UnityEngineBoundsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray2D), UnityEngineRay2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Time), UnityEngineTimeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.GameObject), UnityEngineGameObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Component), UnityEngineComponentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Behaviour), UnityEngineBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Transform), UnityEngineTransformWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Resources), UnityEngineResourcesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.TextAsset), UnityEngineTextAssetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Keyframe), UnityEngineKeyframeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationCurve), UnityEngineAnimationCurveWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationClip), UnityEngineAnimationClipWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.MonoBehaviour), UnityEngineMonoBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem), UnityEngineParticleSystemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SkinnedMeshRenderer), UnityEngineSkinnedMeshRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Renderer), UnityEngineRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Light), UnityEngineLightWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Mathf), UnityEngineMathfWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Collections.Generic.List<int>), SystemCollectionsGenericList_1_SystemInt32_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Debug), UnityEngineDebugWrap.__Register);
        
        
        
        }
        
        static void Init(LuaEnv luaenv, ObjectTranslator translator)
        {
            
            wrapInit0(luaenv, translator);
            
            wrapInit1(luaenv, translator);
            
            
            translator.AddInterfaceBridgeCreator(typeof(XLuaTest.IExchanger), XLuaTestIExchangerBridge.__Create);
            
            translator.AddInterfaceBridgeCreator(typeof(Tutorial.CSCallLua.ItfD), TutorialCSCallLuaItfDBridge.__Create);
            
            translator.AddInterfaceBridgeCreator(typeof(XLuaTest.InvokeLua.ICalc), XLuaTestInvokeLuaICalcBridge.__Create);
            
            translator.AddInterfaceBridgeCreator(typeof(System.Collections.IEnumerator), SystemCollectionsIEnumeratorBridge.__Create);
            
        }
        
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter(Init);
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua.CSObjectWrap.XLua_Gen_Initer_Register__();
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	internal partial class InternalGlobals
    {
	    
		delegate void __GEN_DELEGATE0( DG.Tweening.Tween t);
		
		delegate void __GEN_DELEGATE1( DG.Tweening.Tween t,  bool withCallbacks);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE2( DG.Tweening.Tween t);
		
		delegate void __GEN_DELEGATE3( DG.Tweening.Tween t);
		
		delegate void __GEN_DELEGATE4( DG.Tweening.Tween t);
		
		delegate void __GEN_DELEGATE5( DG.Tweening.Tween t,  float to,  bool andPlay);
		
		delegate void __GEN_DELEGATE6( DG.Tweening.Tween t,  float to,  bool andPlay);
		
		delegate void __GEN_DELEGATE7( DG.Tweening.Tween t,  bool complete);
		
		delegate void __GEN_DELEGATE8( DG.Tweening.Tween t,  float deltaTime,  float unscaledDeltaTime);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE9( DG.Tweening.Tween t);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE10( DG.Tweening.Tween t);
		
		delegate void __GEN_DELEGATE11( DG.Tweening.Tween t);
		
		delegate void __GEN_DELEGATE12( DG.Tweening.Tween t);
		
		delegate void __GEN_DELEGATE13( DG.Tweening.Tween t,  bool includeDelay,  float changeDelayTo);
		
		delegate void __GEN_DELEGATE14( DG.Tweening.Tween t,  bool includeDelay);
		
		delegate void __GEN_DELEGATE15( DG.Tweening.Tween t);
		
		delegate void __GEN_DELEGATE16( DG.Tweening.Tween t);
		
		delegate void __GEN_DELEGATE17( DG.Tweening.Tween t,  int waypointIndex,  bool andPlay);
		
		delegate UnityEngine.YieldInstruction __GEN_DELEGATE18( DG.Tweening.Tween t);
		
		delegate UnityEngine.YieldInstruction __GEN_DELEGATE19( DG.Tweening.Tween t);
		
		delegate UnityEngine.YieldInstruction __GEN_DELEGATE20( DG.Tweening.Tween t);
		
		delegate UnityEngine.YieldInstruction __GEN_DELEGATE21( DG.Tweening.Tween t,  int elapsedLoops);
		
		delegate UnityEngine.YieldInstruction __GEN_DELEGATE22( DG.Tweening.Tween t,  float position);
		
		delegate UnityEngine.Coroutine __GEN_DELEGATE23( DG.Tweening.Tween t);
		
		delegate int __GEN_DELEGATE24( DG.Tweening.Tween t);
		
		delegate float __GEN_DELEGATE25( DG.Tweening.Tween t);
		
		delegate float __GEN_DELEGATE26( DG.Tweening.Tween t);
		
		delegate float __GEN_DELEGATE27( DG.Tweening.Tween t,  bool includeLoops);
		
		delegate float __GEN_DELEGATE28( DG.Tweening.Tween t,  bool includeLoops);
		
		delegate float __GEN_DELEGATE29( DG.Tweening.Tween t,  bool includeLoops);
		
		delegate float __GEN_DELEGATE30( DG.Tweening.Tween t);
		
		delegate bool __GEN_DELEGATE31( DG.Tweening.Tween t);
		
		delegate bool __GEN_DELEGATE32( DG.Tweening.Tween t);
		
		delegate bool __GEN_DELEGATE33( DG.Tweening.Tween t);
		
		delegate bool __GEN_DELEGATE34( DG.Tweening.Tween t);
		
		delegate bool __GEN_DELEGATE35( DG.Tweening.Tween t);
		
		delegate bool __GEN_DELEGATE36( DG.Tweening.Tween t);
		
		delegate int __GEN_DELEGATE37( DG.Tweening.Tween t);
		
		delegate UnityEngine.Vector3 __GEN_DELEGATE38( DG.Tweening.Tween t,  float pathPercentage);
		
		delegate UnityEngine.Vector3[] __GEN_DELEGATE39( DG.Tweening.Tween t,  int subdivisionsXSegment);
		
		delegate float __GEN_DELEGATE40( DG.Tweening.Tween t);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE41( DG.Tweening.Tween t);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE42( DG.Tweening.Tween t,  bool autoKillOnCompletion);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE43( DG.Tweening.Tween t,  object objectId);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE44( DG.Tweening.Tween t,  string stringId);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE45( DG.Tweening.Tween t,  int intId);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE46( DG.Tweening.Tween t,  UnityEngine.GameObject gameObject);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE47( DG.Tweening.Tween t,  UnityEngine.GameObject gameObject,  DG.Tweening.LinkBehaviour behaviour);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE48( DG.Tweening.Tween t,  object target);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE49( DG.Tweening.Tween t,  int loops);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE50( DG.Tweening.Tween t,  int loops,  DG.Tweening.LoopType loopType);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE51( DG.Tweening.Tween t,  DG.Tweening.Ease ease);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE52( DG.Tweening.Tween t,  DG.Tweening.Ease ease,  float overshoot);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE53( DG.Tweening.Tween t,  DG.Tweening.Ease ease,  float amplitude,  float period);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE54( DG.Tweening.Tween t,  UnityEngine.AnimationCurve animCurve);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE55( DG.Tweening.Tween t,  DG.Tweening.EaseFunction customEase);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE56( DG.Tweening.Tween t);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE57( DG.Tweening.Tween t,  bool recyclable);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE58( DG.Tweening.Tween t,  bool isIndependentUpdate);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE59( DG.Tweening.Tween t,  DG.Tweening.UpdateType updateType);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE60( DG.Tweening.Tween t,  DG.Tweening.UpdateType updateType,  bool isIndependentUpdate);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE61( DG.Tweening.Tween t);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE62( DG.Tweening.Tween t,  bool inverted);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE63( DG.Tweening.Tween t,  DG.Tweening.TweenCallback action);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE64( DG.Tweening.Tween t,  DG.Tweening.TweenCallback action);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE65( DG.Tweening.Tween t,  DG.Tweening.TweenCallback action);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE66( DG.Tweening.Tween t,  DG.Tweening.TweenCallback action);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE67( DG.Tweening.Tween t,  DG.Tweening.TweenCallback action);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE68( DG.Tweening.Tween t,  DG.Tweening.TweenCallback action);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE69( DG.Tweening.Tween t,  DG.Tweening.TweenCallback action);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE70( DG.Tweening.Tween t,  DG.Tweening.TweenCallback action);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE71( DG.Tweening.Tween t,  DG.Tweening.TweenCallback<int> action);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE72( DG.Tweening.Tween t,  DG.Tweening.Tween asTween);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE73( DG.Tweening.Tween t,  DG.Tweening.TweenParams tweenParams);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE74( DG.Tweening.Sequence s,  DG.Tweening.Tween t);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE75( DG.Tweening.Sequence s,  DG.Tweening.Tween t);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE76( DG.Tweening.Sequence s,  DG.Tweening.Tween t);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE77( DG.Tweening.Sequence s,  float atPosition,  DG.Tweening.Tween t);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE78( DG.Tweening.Sequence s,  float interval);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE79( DG.Tweening.Sequence s,  float interval);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE80( DG.Tweening.Sequence s,  DG.Tweening.TweenCallback callback);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE81( DG.Tweening.Sequence s,  DG.Tweening.TweenCallback callback);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE82( DG.Tweening.Sequence s,  DG.Tweening.TweenCallback callback);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE83( DG.Tweening.Sequence s,  float atPosition,  DG.Tweening.TweenCallback callback);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE84( DG.Tweening.Tweener t);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE85( DG.Tweening.Tweener t,  bool isRelative);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE86( DG.Tweening.Tweener t,  bool setImmediately,  bool isRelative);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE87( DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t,  float fromAlphaValue,  bool setImmediately,  bool isRelative);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE88( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t,  float fromValue,  bool setImmediately,  bool isRelative);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> __GEN_DELEGATE89( DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t,  float fromValueDegrees,  bool setImmediately,  bool isRelative);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE90( DG.Tweening.Tween t,  float delay);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE91( DG.Tweening.Tween t,  float delay,  bool asPrependedIntervalIfSequence);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE92( DG.Tweening.Tween t);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE93( DG.Tweening.Tween t,  bool isRelative);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE94( DG.Tweening.Tween t);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE95( DG.Tweening.Tween t,  bool isSpeedBased);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE96( DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE97( DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE98( DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t,  DG.Tweening.AxisConstraint axisConstraint,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE99( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE100( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t,  DG.Tweening.AxisConstraint axisConstraint,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE101( DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE102( DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t,  DG.Tweening.AxisConstraint axisConstraint,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE103( DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t,  bool useShortest360Route);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE104( DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t,  bool alphaOnly);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE105( DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE106( DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t,  bool richTextEnabled,  DG.Tweening.ScrambleMode scrambleMode,  string scrambleChars);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE107( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE108( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t,  DG.Tweening.AxisConstraint axisConstraint,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE109( DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t,  float endValueDegrees,  bool relativeCenter,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE110( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  DG.Tweening.AxisConstraint lockPosition,  DG.Tweening.AxisConstraint lockRotation);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE111( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  bool closePath,  DG.Tweening.AxisConstraint lockPosition,  DG.Tweening.AxisConstraint lockRotation);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE112( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  UnityEngine.Vector3 lookAtPosition,  System.Nullable<UnityEngine.Vector3> forwardDirection,  System.Nullable<UnityEngine.Vector3> up);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE113( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  UnityEngine.Vector3 lookAtPosition,  bool stableZRotation);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE114( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  UnityEngine.Transform lookAtTransform,  System.Nullable<UnityEngine.Vector3> forwardDirection,  System.Nullable<UnityEngine.Vector3> up);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE115( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  UnityEngine.Transform lookAtTransform,  bool stableZRotation);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE116( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  float lookAhead,  System.Nullable<UnityEngine.Vector3> forwardDirection,  System.Nullable<UnityEngine.Vector3> up);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE117( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  float lookAhead,  bool stableZRotation);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE118( UnityEngine.Camera target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE119( UnityEngine.Camera target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE120( UnityEngine.Camera target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE121( UnityEngine.Camera target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE122( UnityEngine.Camera target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE123( UnityEngine.Camera target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> __GEN_DELEGATE124( UnityEngine.Camera target,  UnityEngine.Rect endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> __GEN_DELEGATE125( UnityEngine.Camera target,  UnityEngine.Rect endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE126( UnityEngine.Camera target,  float duration,  float strength,  int vibrato,  float randomness,  bool fadeOut,  DG.Tweening.ShakeRandomnessMode randomnessMode);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE127( UnityEngine.Camera target,  float duration,  UnityEngine.Vector3 strength,  int vibrato,  float randomness,  bool fadeOut,  DG.Tweening.ShakeRandomnessMode randomnessMode);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE128( UnityEngine.Camera target,  float duration,  float strength,  int vibrato,  float randomness,  bool fadeOut,  DG.Tweening.ShakeRandomnessMode randomnessMode);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE129( UnityEngine.Camera target,  float duration,  UnityEngine.Vector3 strength,  int vibrato,  float randomness,  bool fadeOut,  DG.Tweening.ShakeRandomnessMode randomnessMode);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE130( UnityEngine.Light target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE131( UnityEngine.Light target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE132( UnityEngine.Light target,  float endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE133( UnityEngine.LineRenderer target,  DG.Tweening.Color2 startValue,  DG.Tweening.Color2 endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE134( UnityEngine.Material target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE135( UnityEngine.Material target,  UnityEngine.Color endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE136( UnityEngine.Material target,  UnityEngine.Color endValue,  int propertyID,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE137( UnityEngine.Material target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE138( UnityEngine.Material target,  float endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE139( UnityEngine.Material target,  float endValue,  int propertyID,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE140( UnityEngine.Material target,  float endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE141( UnityEngine.Material target,  float endValue,  int propertyID,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE142( UnityEngine.Material target,  UnityEngine.Vector2 endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE143( UnityEngine.Material target,  UnityEngine.Vector2 endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE144( UnityEngine.Material target,  UnityEngine.Vector2 endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE145( UnityEngine.Material target,  UnityEngine.Vector2 endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE146( UnityEngine.Material target,  UnityEngine.Vector4 endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE147( UnityEngine.Material target,  UnityEngine.Vector4 endValue,  int propertyID,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE148( UnityEngine.TrailRenderer target,  float toStartWidth,  float toEndWidth,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE149( UnityEngine.TrailRenderer target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE150( UnityEngine.Transform target,  UnityEngine.Vector3 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE151( UnityEngine.Transform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE152( UnityEngine.Transform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE153( UnityEngine.Transform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE154( UnityEngine.Transform target,  UnityEngine.Vector3 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE155( UnityEngine.Transform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE156( UnityEngine.Transform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE157( UnityEngine.Transform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> __GEN_DELEGATE158( UnityEngine.Transform target,  UnityEngine.Vector3 endValue,  float duration,  DG.Tweening.RotateMode mode);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> __GEN_DELEGATE159( UnityEngine.Transform target,  UnityEngine.Quaternion endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> __GEN_DELEGATE160( UnityEngine.Transform target,  UnityEngine.Vector3 endValue,  float duration,  DG.Tweening.RotateMode mode);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> __GEN_DELEGATE161( UnityEngine.Transform target,  UnityEngine.Quaternion endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE162( UnityEngine.Transform target,  UnityEngine.Vector3 endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE163( UnityEngine.Transform target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE164( UnityEngine.Transform target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE165( UnityEngine.Transform target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE166( UnityEngine.Transform target,  float endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE167( UnityEngine.Transform target,  UnityEngine.Vector3 towards,  float duration,  DG.Tweening.AxisConstraint axisConstraint,  System.Nullable<UnityEngine.Vector3> up);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE168( UnityEngine.Transform target,  UnityEngine.Vector3 towards,  float duration,  DG.Tweening.AxisConstraint axisConstraint,  System.Nullable<UnityEngine.Vector3> up);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE169( UnityEngine.Transform target,  UnityEngine.Vector3 punch,  float duration,  int vibrato,  float elasticity,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE170( UnityEngine.Transform target,  UnityEngine.Vector3 punch,  float duration,  int vibrato,  float elasticity);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE171( UnityEngine.Transform target,  UnityEngine.Vector3 punch,  float duration,  int vibrato,  float elasticity);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE172( UnityEngine.Transform target,  float duration,  float strength,  int vibrato,  float randomness,  bool snapping,  bool fadeOut,  DG.Tweening.ShakeRandomnessMode randomnessMode);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE173( UnityEngine.Transform target,  float duration,  UnityEngine.Vector3 strength,  int vibrato,  float randomness,  bool snapping,  bool fadeOut,  DG.Tweening.ShakeRandomnessMode randomnessMode);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE174( UnityEngine.Transform target,  float duration,  float strength,  int vibrato,  float randomness,  bool fadeOut,  DG.Tweening.ShakeRandomnessMode randomnessMode);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE175( UnityEngine.Transform target,  float duration,  UnityEngine.Vector3 strength,  int vibrato,  float randomness,  bool fadeOut,  DG.Tweening.ShakeRandomnessMode randomnessMode);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE176( UnityEngine.Transform target,  float duration,  float strength,  int vibrato,  float randomness,  bool fadeOut,  DG.Tweening.ShakeRandomnessMode randomnessMode);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE177( UnityEngine.Transform target,  float duration,  UnityEngine.Vector3 strength,  int vibrato,  float randomness,  bool fadeOut,  DG.Tweening.ShakeRandomnessMode randomnessMode);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE178( UnityEngine.Transform target,  UnityEngine.Vector3 endValue,  float jumpPower,  int numJumps,  float duration,  bool snapping);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE179( UnityEngine.Transform target,  UnityEngine.Vector3 endValue,  float jumpPower,  int numJumps,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE180( UnityEngine.Transform target,  UnityEngine.Vector3[] path,  float duration,  DG.Tweening.PathType pathType,  DG.Tweening.PathMode pathMode,  int resolution,  System.Nullable<UnityEngine.Color> gizmoColor);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE181( UnityEngine.Transform target,  UnityEngine.Vector3[] path,  float duration,  DG.Tweening.PathType pathType,  DG.Tweening.PathMode pathMode,  int resolution,  System.Nullable<UnityEngine.Color> gizmoColor);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE182( UnityEngine.Transform target,  DG.Tweening.Plugins.Core.PathCore.Path path,  float duration,  DG.Tweening.PathMode pathMode);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE183( UnityEngine.Transform target,  DG.Tweening.Plugins.Core.PathCore.Path path,  float duration,  DG.Tweening.PathMode pathMode);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE184( DG.Tweening.Tween target,  float endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE185( UnityEngine.Light target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE186( UnityEngine.Material target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE187( UnityEngine.Material target,  UnityEngine.Color endValue,  string property,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE188( UnityEngine.Material target,  UnityEngine.Color endValue,  int propertyID,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE189( UnityEngine.Transform target,  UnityEngine.Vector3 byValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE190( UnityEngine.Transform target,  UnityEngine.Vector3 byValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE191( UnityEngine.Transform target,  UnityEngine.Vector3 byValue,  float duration,  DG.Tweening.RotateMode mode);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE192( UnityEngine.Transform target,  UnityEngine.Vector3 byValue,  float duration,  DG.Tweening.RotateMode mode);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE193( UnityEngine.Transform target,  UnityEngine.Vector3 punch,  float duration,  int vibrato,  float elasticity);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE194( UnityEngine.Transform target,  UnityEngine.Vector3 byValue,  float duration);
		
		delegate int __GEN_DELEGATE195( UnityEngine.Component target,  bool withCallbacks);
		
		delegate int __GEN_DELEGATE196( UnityEngine.Material target,  bool withCallbacks);
		
		delegate int __GEN_DELEGATE197( UnityEngine.Component target,  bool complete);
		
		delegate int __GEN_DELEGATE198( UnityEngine.Material target,  bool complete);
		
		delegate int __GEN_DELEGATE199( UnityEngine.Component target);
		
		delegate int __GEN_DELEGATE200( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE201( UnityEngine.Component target,  float to,  bool andPlay);
		
		delegate int __GEN_DELEGATE202( UnityEngine.Material target,  float to,  bool andPlay);
		
		delegate int __GEN_DELEGATE203( UnityEngine.Component target);
		
		delegate int __GEN_DELEGATE204( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE205( UnityEngine.Component target);
		
		delegate int __GEN_DELEGATE206( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE207( UnityEngine.Component target);
		
		delegate int __GEN_DELEGATE208( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE209( UnityEngine.Component target);
		
		delegate int __GEN_DELEGATE210( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE211( UnityEngine.Component target,  bool includeDelay);
		
		delegate int __GEN_DELEGATE212( UnityEngine.Material target,  bool includeDelay);
		
		delegate int __GEN_DELEGATE213( UnityEngine.Component target,  bool includeDelay);
		
		delegate int __GEN_DELEGATE214( UnityEngine.Material target,  bool includeDelay);
		
		delegate int __GEN_DELEGATE215( UnityEngine.Component target);
		
		delegate int __GEN_DELEGATE216( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE217( UnityEngine.Component target);
		
		delegate int __GEN_DELEGATE218( UnityEngine.Material target);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE219( UnityEngine.CanvasGroup target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE220( UnityEngine.UI.Graphic target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE221( UnityEngine.UI.Graphic target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE222( UnityEngine.UI.Image target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE223( UnityEngine.UI.Image target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE224( UnityEngine.UI.Image target,  float endValue,  float duration);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE225( UnityEngine.UI.Image target,  UnityEngine.Gradient gradient,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE226( UnityEngine.UI.LayoutElement target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE227( UnityEngine.UI.LayoutElement target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE228( UnityEngine.UI.LayoutElement target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE229( UnityEngine.UI.Outline target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE230( UnityEngine.UI.Outline target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE231( UnityEngine.UI.Outline target,  UnityEngine.Vector2 endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE232( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE233( UnityEngine.RectTransform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE234( UnityEngine.RectTransform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE235( UnityEngine.RectTransform target,  UnityEngine.Vector3 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE236( UnityEngine.RectTransform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE237( UnityEngine.RectTransform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE238( UnityEngine.RectTransform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE239( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE240( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE241( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE242( UnityEngine.RectTransform target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE243( UnityEngine.RectTransform target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE244( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE245( UnityEngine.RectTransform target,  UnityEngine.Vector2 punch,  float duration,  int vibrato,  float elasticity,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE246( UnityEngine.RectTransform target,  float duration,  float strength,  int vibrato,  float randomness,  bool snapping,  bool fadeOut,  DG.Tweening.ShakeRandomnessMode randomnessMode);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE247( UnityEngine.RectTransform target,  float duration,  UnityEngine.Vector2 strength,  int vibrato,  float randomness,  bool snapping,  bool fadeOut,  DG.Tweening.ShakeRandomnessMode randomnessMode);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE248( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float jumpPower,  int numJumps,  float duration,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE249( UnityEngine.UI.ScrollRect target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE250( UnityEngine.UI.ScrollRect target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE251( UnityEngine.UI.ScrollRect target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE252( UnityEngine.UI.Slider target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE253( UnityEngine.UI.Text target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> __GEN_DELEGATE254( UnityEngine.UI.Text target,  int fromValue,  int endValue,  float duration,  bool addThousandsSeparator,  System.Globalization.CultureInfo culture);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE255( UnityEngine.UI.Text target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> __GEN_DELEGATE256( UnityEngine.UI.Text target,  string endValue,  float duration,  bool richTextEnabled,  DG.Tweening.ScrambleMode scrambleMode,  string scrambleChars);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE257( UnityEngine.UI.Graphic target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE258( UnityEngine.UI.Image target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE259( UnityEngine.UI.Text target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> __GEN_DELEGATE260( UnityEngine.RectTransform target,  UnityEngine.Vector2 center,  float endValueDegrees,  float duration,  bool relativeCenter,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE261( UnityEngine.SpriteRenderer target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE262( UnityEngine.SpriteRenderer target,  float endValue,  float duration);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE263( UnityEngine.SpriteRenderer target,  UnityEngine.Gradient gradient,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE264( UnityEngine.SpriteRenderer target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE265( UnityEngine.AudioSource target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE266( UnityEngine.AudioSource target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE267( UnityEngine.Audio.AudioMixer target,  string floatName,  float endValue,  float duration);
		
		delegate int __GEN_DELEGATE268( UnityEngine.Audio.AudioMixer target,  bool withCallbacks);
		
		delegate int __GEN_DELEGATE269( UnityEngine.Audio.AudioMixer target,  bool complete);
		
		delegate int __GEN_DELEGATE270( UnityEngine.Audio.AudioMixer target);
		
		delegate int __GEN_DELEGATE271( UnityEngine.Audio.AudioMixer target,  float to,  bool andPlay);
		
		delegate int __GEN_DELEGATE272( UnityEngine.Audio.AudioMixer target);
		
		delegate int __GEN_DELEGATE273( UnityEngine.Audio.AudioMixer target);
		
		delegate int __GEN_DELEGATE274( UnityEngine.Audio.AudioMixer target);
		
		delegate int __GEN_DELEGATE275( UnityEngine.Audio.AudioMixer target);
		
		delegate int __GEN_DELEGATE276( UnityEngine.Audio.AudioMixer target);
		
		delegate int __GEN_DELEGATE277( UnityEngine.Audio.AudioMixer target);
		
		delegate int __GEN_DELEGATE278( UnityEngine.Audio.AudioMixer target);
		
		delegate int __GEN_DELEGATE279( UnityEngine.Audio.AudioMixer target);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE280( UnityEngine.Rigidbody target,  UnityEngine.Vector3 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE281( UnityEngine.Rigidbody target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE282( UnityEngine.Rigidbody target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE283( UnityEngine.Rigidbody target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> __GEN_DELEGATE284( UnityEngine.Rigidbody target,  UnityEngine.Vector3 endValue,  float duration,  DG.Tweening.RotateMode mode);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> __GEN_DELEGATE285( UnityEngine.Rigidbody target,  UnityEngine.Vector3 towards,  float duration,  DG.Tweening.AxisConstraint axisConstraint,  System.Nullable<UnityEngine.Vector3> up);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE286( UnityEngine.Rigidbody target,  UnityEngine.Vector3 endValue,  float jumpPower,  int numJumps,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE287( UnityEngine.Rigidbody target,  UnityEngine.Vector3[] path,  float duration,  DG.Tweening.PathType pathType,  DG.Tweening.PathMode pathMode,  int resolution,  System.Nullable<UnityEngine.Color> gizmoColor);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE288( UnityEngine.Rigidbody target,  UnityEngine.Vector3[] path,  float duration,  DG.Tweening.PathType pathType,  DG.Tweening.PathMode pathMode,  int resolution,  System.Nullable<UnityEngine.Color> gizmoColor);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE289( UnityEngine.Rigidbody2D target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE290( UnityEngine.Rigidbody2D target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE291( UnityEngine.Rigidbody2D target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE292( UnityEngine.Rigidbody2D target,  float endValue,  float duration);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE293( UnityEngine.Rigidbody2D target,  UnityEngine.Vector2 endValue,  float jumpPower,  int numJumps,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE294( UnityEngine.Rigidbody2D target,  UnityEngine.Vector2[] path,  float duration,  DG.Tweening.PathType pathType,  DG.Tweening.PathMode pathMode,  int resolution,  System.Nullable<UnityEngine.Color> gizmoColor);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE295( UnityEngine.Rigidbody2D target,  UnityEngine.Vector2[] path,  float duration,  DG.Tweening.PathType pathType,  DG.Tweening.PathMode pathMode,  int resolution,  System.Nullable<UnityEngine.Color> gizmoColor);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE296( DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t,  float fromAlphaValue,  bool setImmediately,  bool isRelative);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE297( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t,  float fromValue,  bool setImmediately,  bool isRelative);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> __GEN_DELEGATE298( DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t,  float fromValueDegrees,  bool setImmediately,  bool isRelative);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE299( DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE300( DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t,  DG.Tweening.AxisConstraint axisConstraint,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE301( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE302( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t,  DG.Tweening.AxisConstraint axisConstraint,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE303( DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE304( DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t,  DG.Tweening.AxisConstraint axisConstraint,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE305( DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t,  bool useShortest360Route);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE306( DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t,  bool alphaOnly);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE307( DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE308( DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t,  bool richTextEnabled,  DG.Tweening.ScrambleMode scrambleMode,  string scrambleChars);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE309( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE310( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t,  DG.Tweening.AxisConstraint axisConstraint,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE311( DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t,  float endValueDegrees,  bool relativeCenter,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE312( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  DG.Tweening.AxisConstraint lockPosition,  DG.Tweening.AxisConstraint lockRotation);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE313( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  bool closePath,  DG.Tweening.AxisConstraint lockPosition,  DG.Tweening.AxisConstraint lockRotation);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE314( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  UnityEngine.Vector3 lookAtPosition,  System.Nullable<UnityEngine.Vector3> forwardDirection,  System.Nullable<UnityEngine.Vector3> up);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE315( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  UnityEngine.Vector3 lookAtPosition,  bool stableZRotation);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE316( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  UnityEngine.Transform lookAtTransform,  System.Nullable<UnityEngine.Vector3> forwardDirection,  System.Nullable<UnityEngine.Vector3> up);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE317( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  UnityEngine.Transform lookAtTransform,  bool stableZRotation);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE318( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  float lookAhead,  System.Nullable<UnityEngine.Vector3> forwardDirection,  System.Nullable<UnityEngine.Vector3> up);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE319( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  float lookAhead,  bool stableZRotation);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE320( UnityEngine.Camera target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE321( UnityEngine.Camera target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE322( UnityEngine.Camera target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE323( UnityEngine.Camera target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE324( UnityEngine.Camera target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE325( UnityEngine.Camera target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> __GEN_DELEGATE326( UnityEngine.Camera target,  UnityEngine.Rect endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> __GEN_DELEGATE327( UnityEngine.Camera target,  UnityEngine.Rect endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE328( UnityEngine.Camera target,  float duration,  float strength,  int vibrato,  float randomness,  bool fadeOut,  DG.Tweening.ShakeRandomnessMode randomnessMode);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE329( UnityEngine.Camera target,  float duration,  UnityEngine.Vector3 strength,  int vibrato,  float randomness,  bool fadeOut,  DG.Tweening.ShakeRandomnessMode randomnessMode);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE330( UnityEngine.Camera target,  float duration,  float strength,  int vibrato,  float randomness,  bool fadeOut,  DG.Tweening.ShakeRandomnessMode randomnessMode);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE331( UnityEngine.Camera target,  float duration,  UnityEngine.Vector3 strength,  int vibrato,  float randomness,  bool fadeOut,  DG.Tweening.ShakeRandomnessMode randomnessMode);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE332( UnityEngine.LineRenderer target,  DG.Tweening.Color2 startValue,  DG.Tweening.Color2 endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE333( UnityEngine.Material target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE334( UnityEngine.Material target,  UnityEngine.Color endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE335( UnityEngine.Material target,  UnityEngine.Color endValue,  int propertyID,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE336( UnityEngine.Material target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE337( UnityEngine.Material target,  float endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE338( UnityEngine.Material target,  float endValue,  int propertyID,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE339( UnityEngine.Material target,  float endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE340( UnityEngine.Material target,  float endValue,  int propertyID,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE341( UnityEngine.Material target,  UnityEngine.Vector2 endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE342( UnityEngine.Material target,  UnityEngine.Vector2 endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE343( UnityEngine.Material target,  UnityEngine.Vector2 endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE344( UnityEngine.Material target,  UnityEngine.Vector2 endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE345( UnityEngine.Material target,  UnityEngine.Vector4 endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE346( UnityEngine.Material target,  UnityEngine.Vector4 endValue,  int propertyID,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE347( UnityEngine.TrailRenderer target,  float toStartWidth,  float toEndWidth,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE348( UnityEngine.TrailRenderer target,  float endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE349( UnityEngine.Material target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE350( UnityEngine.Material target,  UnityEngine.Color endValue,  string property,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE351( UnityEngine.Material target,  UnityEngine.Color endValue,  int propertyID,  float duration);
		
		delegate int __GEN_DELEGATE352( UnityEngine.Material target,  bool withCallbacks);
		
		delegate int __GEN_DELEGATE353( UnityEngine.Material target,  bool complete);
		
		delegate int __GEN_DELEGATE354( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE355( UnityEngine.Material target,  float to,  bool andPlay);
		
		delegate int __GEN_DELEGATE356( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE357( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE358( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE359( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE360( UnityEngine.Material target,  bool includeDelay);
		
		delegate int __GEN_DELEGATE361( UnityEngine.Material target,  bool includeDelay);
		
		delegate int __GEN_DELEGATE362( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE363( UnityEngine.Material target);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE364( UnityEngine.CanvasGroup target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE365( UnityEngine.UI.Graphic target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE366( UnityEngine.UI.Graphic target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE367( UnityEngine.UI.Image target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE368( UnityEngine.UI.Image target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE369( UnityEngine.UI.Image target,  float endValue,  float duration);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE370( UnityEngine.UI.Image target,  UnityEngine.Gradient gradient,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE371( UnityEngine.UI.LayoutElement target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE372( UnityEngine.UI.LayoutElement target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE373( UnityEngine.UI.LayoutElement target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE374( UnityEngine.UI.Outline target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE375( UnityEngine.UI.Outline target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE376( UnityEngine.UI.Outline target,  UnityEngine.Vector2 endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE377( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE378( UnityEngine.RectTransform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE379( UnityEngine.RectTransform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE380( UnityEngine.RectTransform target,  UnityEngine.Vector3 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE381( UnityEngine.RectTransform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE382( UnityEngine.RectTransform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE383( UnityEngine.RectTransform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE384( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE385( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE386( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE387( UnityEngine.RectTransform target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE388( UnityEngine.RectTransform target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE389( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE390( UnityEngine.RectTransform target,  UnityEngine.Vector2 punch,  float duration,  int vibrato,  float elasticity,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE391( UnityEngine.RectTransform target,  float duration,  float strength,  int vibrato,  float randomness,  bool snapping,  bool fadeOut,  DG.Tweening.ShakeRandomnessMode randomnessMode);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE392( UnityEngine.RectTransform target,  float duration,  UnityEngine.Vector2 strength,  int vibrato,  float randomness,  bool snapping,  bool fadeOut,  DG.Tweening.ShakeRandomnessMode randomnessMode);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE393( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float jumpPower,  int numJumps,  float duration,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE394( UnityEngine.UI.ScrollRect target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE395( UnityEngine.UI.ScrollRect target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE396( UnityEngine.UI.ScrollRect target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE397( UnityEngine.UI.Slider target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE398( UnityEngine.UI.Text target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> __GEN_DELEGATE399( UnityEngine.UI.Text target,  int fromValue,  int endValue,  float duration,  bool addThousandsSeparator,  System.Globalization.CultureInfo culture);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE400( UnityEngine.UI.Text target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> __GEN_DELEGATE401( UnityEngine.UI.Text target,  string endValue,  float duration,  bool richTextEnabled,  DG.Tweening.ScrambleMode scrambleMode,  string scrambleChars);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE402( UnityEngine.UI.Graphic target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE403( UnityEngine.UI.Image target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE404( UnityEngine.UI.Text target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> __GEN_DELEGATE405( UnityEngine.RectTransform target,  UnityEngine.Vector2 center,  float endValueDegrees,  float duration,  bool relativeCenter,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE406( UnityEngine.SpriteRenderer target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE407( UnityEngine.SpriteRenderer target,  float endValue,  float duration);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE408( UnityEngine.SpriteRenderer target,  UnityEngine.Gradient gradient,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE409( UnityEngine.SpriteRenderer target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE410( UnityEngine.AudioSource target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE411( UnityEngine.AudioSource target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE412( UnityEngine.Audio.AudioMixer target,  string floatName,  float endValue,  float duration);
		
		delegate int __GEN_DELEGATE413( UnityEngine.Audio.AudioMixer target,  bool withCallbacks);
		
		delegate int __GEN_DELEGATE414( UnityEngine.Audio.AudioMixer target,  bool complete);
		
		delegate int __GEN_DELEGATE415( UnityEngine.Audio.AudioMixer target);
		
		delegate int __GEN_DELEGATE416( UnityEngine.Audio.AudioMixer target,  float to,  bool andPlay);
		
		delegate int __GEN_DELEGATE417( UnityEngine.Audio.AudioMixer target);
		
		delegate int __GEN_DELEGATE418( UnityEngine.Audio.AudioMixer target);
		
		delegate int __GEN_DELEGATE419( UnityEngine.Audio.AudioMixer target);
		
		delegate int __GEN_DELEGATE420( UnityEngine.Audio.AudioMixer target);
		
		delegate int __GEN_DELEGATE421( UnityEngine.Audio.AudioMixer target);
		
		delegate int __GEN_DELEGATE422( UnityEngine.Audio.AudioMixer target);
		
		delegate int __GEN_DELEGATE423( UnityEngine.Audio.AudioMixer target);
		
		delegate int __GEN_DELEGATE424( UnityEngine.Audio.AudioMixer target);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE425( UnityEngine.Rigidbody target,  UnityEngine.Vector3 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE426( UnityEngine.Rigidbody target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE427( UnityEngine.Rigidbody target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE428( UnityEngine.Rigidbody target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> __GEN_DELEGATE429( UnityEngine.Rigidbody target,  UnityEngine.Vector3 endValue,  float duration,  DG.Tweening.RotateMode mode);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> __GEN_DELEGATE430( UnityEngine.Rigidbody target,  UnityEngine.Vector3 towards,  float duration,  DG.Tweening.AxisConstraint axisConstraint,  System.Nullable<UnityEngine.Vector3> up);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE431( UnityEngine.Rigidbody target,  UnityEngine.Vector3 endValue,  float jumpPower,  int numJumps,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE432( UnityEngine.Rigidbody target,  UnityEngine.Vector3[] path,  float duration,  DG.Tweening.PathType pathType,  DG.Tweening.PathMode pathMode,  int resolution,  System.Nullable<UnityEngine.Color> gizmoColor);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE433( UnityEngine.Rigidbody target,  UnityEngine.Vector3[] path,  float duration,  DG.Tweening.PathType pathType,  DG.Tweening.PathMode pathMode,  int resolution,  System.Nullable<UnityEngine.Color> gizmoColor);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE434( UnityEngine.Rigidbody2D target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE435( UnityEngine.Rigidbody2D target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE436( UnityEngine.Rigidbody2D target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE437( UnityEngine.Rigidbody2D target,  float endValue,  float duration);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE438( UnityEngine.Rigidbody2D target,  UnityEngine.Vector2 endValue,  float jumpPower,  int numJumps,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE439( UnityEngine.Rigidbody2D target,  UnityEngine.Vector2[] path,  float duration,  DG.Tweening.PathType pathType,  DG.Tweening.PathMode pathMode,  int resolution,  System.Nullable<UnityEngine.Color> gizmoColor);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE440( UnityEngine.Rigidbody2D target,  UnityEngine.Vector2[] path,  float duration,  DG.Tweening.PathType pathType,  DG.Tweening.PathMode pathMode,  int resolution,  System.Nullable<UnityEngine.Color> gizmoColor);
		
	    static InternalGlobals()
		{
		    extensionMethodMap = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
				{typeof(DG.Tweening.Tween), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE0(DG.Tweening.TweenExtensions.Complete)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE1(DG.Tweening.TweenExtensions.Complete)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE2(DG.Tweening.TweenExtensions.Done)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE3(DG.Tweening.TweenExtensions.Flip)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE4(DG.Tweening.TweenExtensions.ForceInit)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE5(DG.Tweening.TweenExtensions.Goto)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE6(DG.Tweening.TweenExtensions.GotoWithCallbacks)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE7(DG.Tweening.TweenExtensions.Kill)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE8(DG.Tweening.TweenExtensions.ManualUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE9(DG.Tweening.TweenExtensions.Pause)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE10(DG.Tweening.TweenExtensions.Play)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE11(DG.Tweening.TweenExtensions.PlayBackwards)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE12(DG.Tweening.TweenExtensions.PlayForward)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE13(DG.Tweening.TweenExtensions.Restart)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE14(DG.Tweening.TweenExtensions.Rewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE15(DG.Tweening.TweenExtensions.SmoothRewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE16(DG.Tweening.TweenExtensions.TogglePause)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE17(DG.Tweening.TweenExtensions.GotoWaypoint)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE18(DG.Tweening.TweenExtensions.WaitForCompletion)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE19(DG.Tweening.TweenExtensions.WaitForRewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE20(DG.Tweening.TweenExtensions.WaitForKill)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE21(DG.Tweening.TweenExtensions.WaitForElapsedLoops)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE22(DG.Tweening.TweenExtensions.WaitForPosition)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE23(DG.Tweening.TweenExtensions.WaitForStart)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE24(DG.Tweening.TweenExtensions.CompletedLoops)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE25(DG.Tweening.TweenExtensions.Delay)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE26(DG.Tweening.TweenExtensions.ElapsedDelay)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE27(DG.Tweening.TweenExtensions.Duration)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE28(DG.Tweening.TweenExtensions.Elapsed)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE29(DG.Tweening.TweenExtensions.ElapsedPercentage)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE30(DG.Tweening.TweenExtensions.ElapsedDirectionalPercentage)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE31(DG.Tweening.TweenExtensions.IsActive)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE32(DG.Tweening.TweenExtensions.IsBackwards)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE33(DG.Tweening.TweenExtensions.IsLoopingOrExecutingBackwards)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE34(DG.Tweening.TweenExtensions.IsComplete)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE35(DG.Tweening.TweenExtensions.IsInitialized)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE36(DG.Tweening.TweenExtensions.IsPlaying)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE37(DG.Tweening.TweenExtensions.Loops)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE38(DG.Tweening.TweenExtensions.PathGetPoint)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE39(DG.Tweening.TweenExtensions.PathGetDrawPoints)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE40(DG.Tweening.TweenExtensions.PathLength)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE41(DG.Tweening.TweenSettingsExtensions.SetAutoKill)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE42(DG.Tweening.TweenSettingsExtensions.SetAutoKill)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE43(DG.Tweening.TweenSettingsExtensions.SetId)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE44(DG.Tweening.TweenSettingsExtensions.SetId)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE45(DG.Tweening.TweenSettingsExtensions.SetId)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE46(DG.Tweening.TweenSettingsExtensions.SetLink)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE47(DG.Tweening.TweenSettingsExtensions.SetLink)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE48(DG.Tweening.TweenSettingsExtensions.SetTarget)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE49(DG.Tweening.TweenSettingsExtensions.SetLoops)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE50(DG.Tweening.TweenSettingsExtensions.SetLoops)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE51(DG.Tweening.TweenSettingsExtensions.SetEase)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE52(DG.Tweening.TweenSettingsExtensions.SetEase)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE53(DG.Tweening.TweenSettingsExtensions.SetEase)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE54(DG.Tweening.TweenSettingsExtensions.SetEase)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE55(DG.Tweening.TweenSettingsExtensions.SetEase)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE56(DG.Tweening.TweenSettingsExtensions.SetRecyclable)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE57(DG.Tweening.TweenSettingsExtensions.SetRecyclable)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE58(DG.Tweening.TweenSettingsExtensions.SetUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE59(DG.Tweening.TweenSettingsExtensions.SetUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE60(DG.Tweening.TweenSettingsExtensions.SetUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE61(DG.Tweening.TweenSettingsExtensions.SetInverted)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE62(DG.Tweening.TweenSettingsExtensions.SetInverted)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE63(DG.Tweening.TweenSettingsExtensions.OnStart)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE64(DG.Tweening.TweenSettingsExtensions.OnPlay)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE65(DG.Tweening.TweenSettingsExtensions.OnPause)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE66(DG.Tweening.TweenSettingsExtensions.OnRewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE67(DG.Tweening.TweenSettingsExtensions.OnUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE68(DG.Tweening.TweenSettingsExtensions.OnStepComplete)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE69(DG.Tweening.TweenSettingsExtensions.OnComplete)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE70(DG.Tweening.TweenSettingsExtensions.OnKill)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE71(DG.Tweening.TweenSettingsExtensions.OnWaypointChange)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE72(DG.Tweening.TweenSettingsExtensions.SetAs)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE73(DG.Tweening.TweenSettingsExtensions.SetAs)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE90(DG.Tweening.TweenSettingsExtensions.SetDelay)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE91(DG.Tweening.TweenSettingsExtensions.SetDelay)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE92(DG.Tweening.TweenSettingsExtensions.SetRelative)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE93(DG.Tweening.TweenSettingsExtensions.SetRelative)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE94(DG.Tweening.TweenSettingsExtensions.SetSpeedBased)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE95(DG.Tweening.TweenSettingsExtensions.SetSpeedBased)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE184(DG.Tweening.ShortcutExtensions.DOTimeScale)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Sequence), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE74(DG.Tweening.TweenSettingsExtensions.Append)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE75(DG.Tweening.TweenSettingsExtensions.Prepend)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE76(DG.Tweening.TweenSettingsExtensions.Join)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE77(DG.Tweening.TweenSettingsExtensions.Insert)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE78(DG.Tweening.TweenSettingsExtensions.AppendInterval)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE79(DG.Tweening.TweenSettingsExtensions.PrependInterval)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE80(DG.Tweening.TweenSettingsExtensions.AppendCallback)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE81(DG.Tweening.TweenSettingsExtensions.PrependCallback)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE82(DG.Tweening.TweenSettingsExtensions.JoinCallback)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE83(DG.Tweening.TweenSettingsExtensions.InsertCallback)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Tweener), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE84(DG.Tweening.TweenSettingsExtensions.From)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE85(DG.Tweening.TweenSettingsExtensions.From)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE86(DG.Tweening.TweenSettingsExtensions.From)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE87(DG.Tweening.TweenSettingsExtensions.From)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE104(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE296(DG.Tweening.TweenSettingsExtensions.From)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE306(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE88(DG.Tweening.TweenSettingsExtensions.From)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE99(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE100(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE297(DG.Tweening.TweenSettingsExtensions.From)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE301(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE302(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE89(DG.Tweening.TweenSettingsExtensions.From)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE109(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE298(DG.Tweening.TweenSettingsExtensions.From)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE311(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE96(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE97(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE98(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE299(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE300(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE101(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE102(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE303(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE304(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE103(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE305(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE105(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE307(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE106(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE308(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE107(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE108(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE309(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE310(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE110(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE111(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE112(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE113(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE114(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE115(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE116(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE117(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE312(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE313(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE314(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE315(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE316(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE317(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE318(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE319(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.Camera), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE118(DG.Tweening.ShortcutExtensions.DOAspect)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE119(DG.Tweening.ShortcutExtensions.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE120(DG.Tweening.ShortcutExtensions.DOFarClipPlane)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE121(DG.Tweening.ShortcutExtensions.DOFieldOfView)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE122(DG.Tweening.ShortcutExtensions.DONearClipPlane)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE123(DG.Tweening.ShortcutExtensions.DOOrthoSize)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE124(DG.Tweening.ShortcutExtensions.DOPixelRect)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE125(DG.Tweening.ShortcutExtensions.DORect)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE126(DG.Tweening.ShortcutExtensions.DOShakePosition)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE127(DG.Tweening.ShortcutExtensions.DOShakePosition)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE128(DG.Tweening.ShortcutExtensions.DOShakeRotation)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE129(DG.Tweening.ShortcutExtensions.DOShakeRotation)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE320(DG.Tweening.ShortcutExtensions.DOAspect)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE321(DG.Tweening.ShortcutExtensions.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE322(DG.Tweening.ShortcutExtensions.DOFarClipPlane)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE323(DG.Tweening.ShortcutExtensions.DOFieldOfView)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE324(DG.Tweening.ShortcutExtensions.DONearClipPlane)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE325(DG.Tweening.ShortcutExtensions.DOOrthoSize)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE326(DG.Tweening.ShortcutExtensions.DOPixelRect)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE327(DG.Tweening.ShortcutExtensions.DORect)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE328(DG.Tweening.ShortcutExtensions.DOShakePosition)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE329(DG.Tweening.ShortcutExtensions.DOShakePosition)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE330(DG.Tweening.ShortcutExtensions.DOShakeRotation)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE331(DG.Tweening.ShortcutExtensions.DOShakeRotation)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.Light), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE130(DG.Tweening.ShortcutExtensions.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE131(DG.Tweening.ShortcutExtensions.DOIntensity)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE132(DG.Tweening.ShortcutExtensions.DOShadowStrength)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE185(DG.Tweening.ShortcutExtensions.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.LineRenderer), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE133(DG.Tweening.ShortcutExtensions.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE332(DG.Tweening.ShortcutExtensions.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.Material), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE134(DG.Tweening.ShortcutExtensions.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE135(DG.Tweening.ShortcutExtensions.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE136(DG.Tweening.ShortcutExtensions.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE137(DG.Tweening.ShortcutExtensions.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE138(DG.Tweening.ShortcutExtensions.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE139(DG.Tweening.ShortcutExtensions.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE140(DG.Tweening.ShortcutExtensions.DOFloat)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE141(DG.Tweening.ShortcutExtensions.DOFloat)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE142(DG.Tweening.ShortcutExtensions.DOOffset)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE143(DG.Tweening.ShortcutExtensions.DOOffset)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE144(DG.Tweening.ShortcutExtensions.DOTiling)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE145(DG.Tweening.ShortcutExtensions.DOTiling)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE146(DG.Tweening.ShortcutExtensions.DOVector)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE147(DG.Tweening.ShortcutExtensions.DOVector)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE186(DG.Tweening.ShortcutExtensions.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE187(DG.Tweening.ShortcutExtensions.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE188(DG.Tweening.ShortcutExtensions.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE196(DG.Tweening.ShortcutExtensions.DOComplete)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE198(DG.Tweening.ShortcutExtensions.DOKill)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE200(DG.Tweening.ShortcutExtensions.DOFlip)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE202(DG.Tweening.ShortcutExtensions.DOGoto)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE204(DG.Tweening.ShortcutExtensions.DOPause)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE206(DG.Tweening.ShortcutExtensions.DOPlay)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE208(DG.Tweening.ShortcutExtensions.DOPlayBackwards)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE210(DG.Tweening.ShortcutExtensions.DOPlayForward)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE212(DG.Tweening.ShortcutExtensions.DORestart)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE214(DG.Tweening.ShortcutExtensions.DORewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE216(DG.Tweening.ShortcutExtensions.DOSmoothRewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE218(DG.Tweening.ShortcutExtensions.DOTogglePause)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE333(DG.Tweening.ShortcutExtensions.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE334(DG.Tweening.ShortcutExtensions.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE335(DG.Tweening.ShortcutExtensions.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE336(DG.Tweening.ShortcutExtensions.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE337(DG.Tweening.ShortcutExtensions.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE338(DG.Tweening.ShortcutExtensions.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE339(DG.Tweening.ShortcutExtensions.DOFloat)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE340(DG.Tweening.ShortcutExtensions.DOFloat)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE341(DG.Tweening.ShortcutExtensions.DOOffset)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE342(DG.Tweening.ShortcutExtensions.DOOffset)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE343(DG.Tweening.ShortcutExtensions.DOTiling)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE344(DG.Tweening.ShortcutExtensions.DOTiling)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE345(DG.Tweening.ShortcutExtensions.DOVector)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE346(DG.Tweening.ShortcutExtensions.DOVector)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE349(DG.Tweening.ShortcutExtensions.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE350(DG.Tweening.ShortcutExtensions.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE351(DG.Tweening.ShortcutExtensions.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE352(DG.Tweening.ShortcutExtensions.DOComplete)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE353(DG.Tweening.ShortcutExtensions.DOKill)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE354(DG.Tweening.ShortcutExtensions.DOFlip)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE355(DG.Tweening.ShortcutExtensions.DOGoto)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE356(DG.Tweening.ShortcutExtensions.DOPause)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE357(DG.Tweening.ShortcutExtensions.DOPlay)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE358(DG.Tweening.ShortcutExtensions.DOPlayBackwards)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE359(DG.Tweening.ShortcutExtensions.DOPlayForward)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE360(DG.Tweening.ShortcutExtensions.DORestart)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE361(DG.Tweening.ShortcutExtensions.DORewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE362(DG.Tweening.ShortcutExtensions.DOSmoothRewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE363(DG.Tweening.ShortcutExtensions.DOTogglePause)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.TrailRenderer), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE148(DG.Tweening.ShortcutExtensions.DOResize)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE149(DG.Tweening.ShortcutExtensions.DOTime)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE347(DG.Tweening.ShortcutExtensions.DOResize)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE348(DG.Tweening.ShortcutExtensions.DOTime)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.Transform), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE150(DG.Tweening.ShortcutExtensions.DOMove)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE151(DG.Tweening.ShortcutExtensions.DOMoveX)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE152(DG.Tweening.ShortcutExtensions.DOMoveY)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE153(DG.Tweening.ShortcutExtensions.DOMoveZ)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE154(DG.Tweening.ShortcutExtensions.DOLocalMove)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE155(DG.Tweening.ShortcutExtensions.DOLocalMoveX)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE156(DG.Tweening.ShortcutExtensions.DOLocalMoveY)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE157(DG.Tweening.ShortcutExtensions.DOLocalMoveZ)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE158(DG.Tweening.ShortcutExtensions.DORotate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE159(DG.Tweening.ShortcutExtensions.DORotateQuaternion)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE160(DG.Tweening.ShortcutExtensions.DOLocalRotate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE161(DG.Tweening.ShortcutExtensions.DOLocalRotateQuaternion)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE162(DG.Tweening.ShortcutExtensions.DOScale)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE163(DG.Tweening.ShortcutExtensions.DOScale)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE164(DG.Tweening.ShortcutExtensions.DOScaleX)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE165(DG.Tweening.ShortcutExtensions.DOScaleY)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE166(DG.Tweening.ShortcutExtensions.DOScaleZ)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE167(DG.Tweening.ShortcutExtensions.DOLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE168(DG.Tweening.ShortcutExtensions.DODynamicLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE169(DG.Tweening.ShortcutExtensions.DOPunchPosition)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE170(DG.Tweening.ShortcutExtensions.DOPunchScale)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE171(DG.Tweening.ShortcutExtensions.DOPunchRotation)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE172(DG.Tweening.ShortcutExtensions.DOShakePosition)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE173(DG.Tweening.ShortcutExtensions.DOShakePosition)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE174(DG.Tweening.ShortcutExtensions.DOShakeRotation)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE175(DG.Tweening.ShortcutExtensions.DOShakeRotation)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE176(DG.Tweening.ShortcutExtensions.DOShakeScale)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE177(DG.Tweening.ShortcutExtensions.DOShakeScale)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE178(DG.Tweening.ShortcutExtensions.DOJump)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE179(DG.Tweening.ShortcutExtensions.DOLocalJump)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE180(DG.Tweening.ShortcutExtensions.DOPath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE181(DG.Tweening.ShortcutExtensions.DOLocalPath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE182(DG.Tweening.ShortcutExtensions.DOPath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE183(DG.Tweening.ShortcutExtensions.DOLocalPath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE189(DG.Tweening.ShortcutExtensions.DOBlendableMoveBy)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE190(DG.Tweening.ShortcutExtensions.DOBlendableLocalMoveBy)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE191(DG.Tweening.ShortcutExtensions.DOBlendableRotateBy)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE192(DG.Tweening.ShortcutExtensions.DOBlendableLocalRotateBy)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE193(DG.Tweening.ShortcutExtensions.DOBlendablePunchRotation)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE194(DG.Tweening.ShortcutExtensions.DOBlendableScaleBy)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.Component), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE195(DG.Tweening.ShortcutExtensions.DOComplete)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE197(DG.Tweening.ShortcutExtensions.DOKill)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE199(DG.Tweening.ShortcutExtensions.DOFlip)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE201(DG.Tweening.ShortcutExtensions.DOGoto)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE203(DG.Tweening.ShortcutExtensions.DOPause)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE205(DG.Tweening.ShortcutExtensions.DOPlay)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE207(DG.Tweening.ShortcutExtensions.DOPlayBackwards)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE209(DG.Tweening.ShortcutExtensions.DOPlayForward)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE211(DG.Tweening.ShortcutExtensions.DORestart)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE213(DG.Tweening.ShortcutExtensions.DORewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE215(DG.Tweening.ShortcutExtensions.DOSmoothRewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE217(DG.Tweening.ShortcutExtensions.DOTogglePause)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.CanvasGroup), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE219(DG.Tweening.DOTweenModuleUI.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE364(DG.Tweening.DOTweenModuleUI.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.UI.Graphic), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE220(DG.Tweening.DOTweenModuleUI.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE221(DG.Tweening.DOTweenModuleUI.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE257(DG.Tweening.DOTweenModuleUI.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE365(DG.Tweening.DOTweenModuleUI.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE366(DG.Tweening.DOTweenModuleUI.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE402(DG.Tweening.DOTweenModuleUI.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.UI.Image), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE222(DG.Tweening.DOTweenModuleUI.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE223(DG.Tweening.DOTweenModuleUI.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE224(DG.Tweening.DOTweenModuleUI.DOFillAmount)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE225(DG.Tweening.DOTweenModuleUI.DOGradientColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE258(DG.Tweening.DOTweenModuleUI.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE367(DG.Tweening.DOTweenModuleUI.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE368(DG.Tweening.DOTweenModuleUI.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE369(DG.Tweening.DOTweenModuleUI.DOFillAmount)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE370(DG.Tweening.DOTweenModuleUI.DOGradientColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE403(DG.Tweening.DOTweenModuleUI.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.UI.LayoutElement), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE226(DG.Tweening.DOTweenModuleUI.DOFlexibleSize)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE227(DG.Tweening.DOTweenModuleUI.DOMinSize)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE228(DG.Tweening.DOTweenModuleUI.DOPreferredSize)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE371(DG.Tweening.DOTweenModuleUI.DOFlexibleSize)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE372(DG.Tweening.DOTweenModuleUI.DOMinSize)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE373(DG.Tweening.DOTweenModuleUI.DOPreferredSize)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.UI.Outline), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE229(DG.Tweening.DOTweenModuleUI.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE230(DG.Tweening.DOTweenModuleUI.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE231(DG.Tweening.DOTweenModuleUI.DOScale)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE374(DG.Tweening.DOTweenModuleUI.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE375(DG.Tweening.DOTweenModuleUI.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE376(DG.Tweening.DOTweenModuleUI.DOScale)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.RectTransform), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE232(DG.Tweening.DOTweenModuleUI.DOAnchorPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE233(DG.Tweening.DOTweenModuleUI.DOAnchorPosX)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE234(DG.Tweening.DOTweenModuleUI.DOAnchorPosY)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE235(DG.Tweening.DOTweenModuleUI.DOAnchorPos3D)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE236(DG.Tweening.DOTweenModuleUI.DOAnchorPos3DX)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE237(DG.Tweening.DOTweenModuleUI.DOAnchorPos3DY)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE238(DG.Tweening.DOTweenModuleUI.DOAnchorPos3DZ)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE239(DG.Tweening.DOTweenModuleUI.DOAnchorMax)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE240(DG.Tweening.DOTweenModuleUI.DOAnchorMin)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE241(DG.Tweening.DOTweenModuleUI.DOPivot)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE242(DG.Tweening.DOTweenModuleUI.DOPivotX)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE243(DG.Tweening.DOTweenModuleUI.DOPivotY)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE244(DG.Tweening.DOTweenModuleUI.DOSizeDelta)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE245(DG.Tweening.DOTweenModuleUI.DOPunchAnchorPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE246(DG.Tweening.DOTweenModuleUI.DOShakeAnchorPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE247(DG.Tweening.DOTweenModuleUI.DOShakeAnchorPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE248(DG.Tweening.DOTweenModuleUI.DOJumpAnchorPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE260(DG.Tweening.DOTweenModuleUI.DOShapeCircle)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE377(DG.Tweening.DOTweenModuleUI.DOAnchorPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE378(DG.Tweening.DOTweenModuleUI.DOAnchorPosX)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE379(DG.Tweening.DOTweenModuleUI.DOAnchorPosY)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE380(DG.Tweening.DOTweenModuleUI.DOAnchorPos3D)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE381(DG.Tweening.DOTweenModuleUI.DOAnchorPos3DX)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE382(DG.Tweening.DOTweenModuleUI.DOAnchorPos3DY)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE383(DG.Tweening.DOTweenModuleUI.DOAnchorPos3DZ)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE384(DG.Tweening.DOTweenModuleUI.DOAnchorMax)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE385(DG.Tweening.DOTweenModuleUI.DOAnchorMin)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE386(DG.Tweening.DOTweenModuleUI.DOPivot)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE387(DG.Tweening.DOTweenModuleUI.DOPivotX)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE388(DG.Tweening.DOTweenModuleUI.DOPivotY)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE389(DG.Tweening.DOTweenModuleUI.DOSizeDelta)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE390(DG.Tweening.DOTweenModuleUI.DOPunchAnchorPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE391(DG.Tweening.DOTweenModuleUI.DOShakeAnchorPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE392(DG.Tweening.DOTweenModuleUI.DOShakeAnchorPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE393(DG.Tweening.DOTweenModuleUI.DOJumpAnchorPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE405(DG.Tweening.DOTweenModuleUI.DOShapeCircle)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.UI.ScrollRect), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE249(DG.Tweening.DOTweenModuleUI.DONormalizedPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE250(DG.Tweening.DOTweenModuleUI.DOHorizontalNormalizedPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE251(DG.Tweening.DOTweenModuleUI.DOVerticalNormalizedPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE394(DG.Tweening.DOTweenModuleUI.DONormalizedPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE395(DG.Tweening.DOTweenModuleUI.DOHorizontalNormalizedPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE396(DG.Tweening.DOTweenModuleUI.DOVerticalNormalizedPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.UI.Slider), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE252(DG.Tweening.DOTweenModuleUI.DOValue)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE397(DG.Tweening.DOTweenModuleUI.DOValue)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.UI.Text), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE253(DG.Tweening.DOTweenModuleUI.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE254(DG.Tweening.DOTweenModuleUI.DOCounter)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE255(DG.Tweening.DOTweenModuleUI.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE256(DG.Tweening.DOTweenModuleUI.DOText)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE259(DG.Tweening.DOTweenModuleUI.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE398(DG.Tweening.DOTweenModuleUI.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE399(DG.Tweening.DOTweenModuleUI.DOCounter)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE400(DG.Tweening.DOTweenModuleUI.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE401(DG.Tweening.DOTweenModuleUI.DOText)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE404(DG.Tweening.DOTweenModuleUI.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.SpriteRenderer), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE261(DG.Tweening.DOTweenModuleSprite.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE262(DG.Tweening.DOTweenModuleSprite.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE263(DG.Tweening.DOTweenModuleSprite.DOGradientColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE264(DG.Tweening.DOTweenModuleSprite.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE406(DG.Tweening.DOTweenModuleSprite.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE407(DG.Tweening.DOTweenModuleSprite.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE408(DG.Tweening.DOTweenModuleSprite.DOGradientColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE409(DG.Tweening.DOTweenModuleSprite.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.AudioSource), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE265(DG.Tweening.DOTweenModuleAudio.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE266(DG.Tweening.DOTweenModuleAudio.DOPitch)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE410(DG.Tweening.DOTweenModuleAudio.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE411(DG.Tweening.DOTweenModuleAudio.DOPitch)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.Audio.AudioMixer), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE267(DG.Tweening.DOTweenModuleAudio.DOSetFloat)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE268(DG.Tweening.DOTweenModuleAudio.DOComplete)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE269(DG.Tweening.DOTweenModuleAudio.DOKill)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE270(DG.Tweening.DOTweenModuleAudio.DOFlip)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE271(DG.Tweening.DOTweenModuleAudio.DOGoto)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE272(DG.Tweening.DOTweenModuleAudio.DOPause)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE273(DG.Tweening.DOTweenModuleAudio.DOPlay)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE274(DG.Tweening.DOTweenModuleAudio.DOPlayBackwards)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE275(DG.Tweening.DOTweenModuleAudio.DOPlayForward)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE276(DG.Tweening.DOTweenModuleAudio.DORestart)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE277(DG.Tweening.DOTweenModuleAudio.DORewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE278(DG.Tweening.DOTweenModuleAudio.DOSmoothRewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE279(DG.Tweening.DOTweenModuleAudio.DOTogglePause)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE412(DG.Tweening.DOTweenModuleAudio.DOSetFloat)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE413(DG.Tweening.DOTweenModuleAudio.DOComplete)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE414(DG.Tweening.DOTweenModuleAudio.DOKill)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE415(DG.Tweening.DOTweenModuleAudio.DOFlip)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE416(DG.Tweening.DOTweenModuleAudio.DOGoto)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE417(DG.Tweening.DOTweenModuleAudio.DOPause)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE418(DG.Tweening.DOTweenModuleAudio.DOPlay)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE419(DG.Tweening.DOTweenModuleAudio.DOPlayBackwards)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE420(DG.Tweening.DOTweenModuleAudio.DOPlayForward)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE421(DG.Tweening.DOTweenModuleAudio.DORestart)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE422(DG.Tweening.DOTweenModuleAudio.DORewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE423(DG.Tweening.DOTweenModuleAudio.DOSmoothRewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE424(DG.Tweening.DOTweenModuleAudio.DOTogglePause)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.Rigidbody), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE280(DG.Tweening.DOTweenModulePhysics.DOMove)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE281(DG.Tweening.DOTweenModulePhysics.DOMoveX)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE282(DG.Tweening.DOTweenModulePhysics.DOMoveY)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE283(DG.Tweening.DOTweenModulePhysics.DOMoveZ)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE284(DG.Tweening.DOTweenModulePhysics.DORotate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE285(DG.Tweening.DOTweenModulePhysics.DOLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE286(DG.Tweening.DOTweenModulePhysics.DOJump)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE287(DG.Tweening.DOTweenModulePhysics.DOPath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE288(DG.Tweening.DOTweenModulePhysics.DOLocalPath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE425(DG.Tweening.DOTweenModulePhysics.DOMove)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE426(DG.Tweening.DOTweenModulePhysics.DOMoveX)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE427(DG.Tweening.DOTweenModulePhysics.DOMoveY)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE428(DG.Tweening.DOTweenModulePhysics.DOMoveZ)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE429(DG.Tweening.DOTweenModulePhysics.DORotate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE430(DG.Tweening.DOTweenModulePhysics.DOLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE431(DG.Tweening.DOTweenModulePhysics.DOJump)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE432(DG.Tweening.DOTweenModulePhysics.DOPath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE433(DG.Tweening.DOTweenModulePhysics.DOLocalPath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.Rigidbody2D), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE289(DG.Tweening.DOTweenModulePhysics2D.DOMove)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE290(DG.Tweening.DOTweenModulePhysics2D.DOMoveX)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE291(DG.Tweening.DOTweenModulePhysics2D.DOMoveY)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE292(DG.Tweening.DOTweenModulePhysics2D.DORotate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE293(DG.Tweening.DOTweenModulePhysics2D.DOJump)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE294(DG.Tweening.DOTweenModulePhysics2D.DOPath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE295(DG.Tweening.DOTweenModulePhysics2D.DOLocalPath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE434(DG.Tweening.DOTweenModulePhysics2D.DOMove)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE435(DG.Tweening.DOTweenModulePhysics2D.DOMoveX)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE436(DG.Tweening.DOTweenModulePhysics2D.DOMoveY)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE437(DG.Tweening.DOTweenModulePhysics2D.DORotate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE438(DG.Tweening.DOTweenModulePhysics2D.DOJump)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE439(DG.Tweening.DOTweenModulePhysics2D.DOPath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE440(DG.Tweening.DOTweenModulePhysics2D.DOLocalPath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
			};
			
			genTryArrayGetPtr = StaticLuaCallbacks.__tryArrayGet;
            genTryArraySetPtr = StaticLuaCallbacks.__tryArraySet;
		}
	}
}
