using System;
using System.Collections.Generic;
using XLua;

public static class CsharpCallLuaList
{
    [CSharpCallLua]
    public static List<Type> csharpCallLuaList = new List<Type>();
}
