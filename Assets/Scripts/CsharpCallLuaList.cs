﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using XLua;



public static class CsharpCallLuaList
{
    [CSharpCallLua]
    public static List<Type> csharpCallLuaList = new List<Type>();

    [LuaCallCSharp]
    [ReflectionUse]
    public static List<Type> dotween_lua_call_cs_list = new List<Type>()
    {
        typeof(DG.Tweening.AutoPlay),
        typeof(DG.Tweening.AxisConstraint),
        typeof(DG.Tweening.Ease),
        typeof(DG.Tweening.LogBehaviour),
        typeof(DG.Tweening.LoopType),
        typeof(DG.Tweening.PathMode),
        typeof(DG.Tweening.PathType),
        typeof(DG.Tweening.RotateMode),
        typeof(DG.Tweening.ScrambleMode),
        typeof(DG.Tweening.TweenType),
        typeof(DG.Tweening.UpdateType),

        typeof(DG.Tweening.DOTween),
        typeof(DG.Tweening.DOVirtual),
        typeof(DG.Tweening.EaseFactory),
        typeof(DG.Tweening.Tweener),
        typeof(DG.Tweening.Tween),
        typeof(DG.Tweening.Sequence),
        typeof(DG.Tweening.TweenParams),
        typeof(DG.Tweening.Core.ABSSequentiable),

        typeof(DG.Tweening.Core.TweenerCore<Vector3, Vector3, DG.Tweening.Plugins.Options.VectorOptions>),
        typeof(DG.Tweening.Core.TweenerCore<Color,Color,DG.Tweening.Plugins.Options.ColorOptions>),
        typeof(DG.Tweening.Core.TweenerCore<float,float,DG.Tweening.Plugins.Options.FloatOptions>),

        typeof(DG.Tweening.TweenCallback),
        typeof(DG.Tweening.TweenExtensions),
        typeof(DG.Tweening.TweenSettingsExtensions),
        typeof(DG.Tweening.ShortcutExtensions),
        typeof(DG.Tweening.DOTweenModuleUI),
        //有了以下这部分才能真正使用其他模块的拓展方法，这是其他帖子都没写的
        typeof(DG.Tweening.DOTweenModuleSprite),
        typeof(DG.Tweening.DOTweenModuleAudio),
       typeof(DG.Tweening.DOTweenModulePhysics),
       typeof(DG.Tweening.DOTweenModulePhysics2D)
    };
}


