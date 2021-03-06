﻿using Natasha.Cache;
using Natasha.Debug;
using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Natasha.Utils
{
    public static class MethodHelper
    {
        
        public static Type[] GetGenericTypes()
        {
            return new Type[0];
        }
        public static Type[] GetGenericTypes<T1>()
        {
            Type[] methodParameterTypes = new Type[1];
            methodParameterTypes[0] = typeof(T1);
            return methodParameterTypes;
        }
        public static Type[] GetGenericTypes<T1, T2>()
        {
            Type[] methodParameterTypes = new Type[2];
            methodParameterTypes[0] = typeof(T1);
            methodParameterTypes[1] = typeof(T2);
            return methodParameterTypes;
        }
        public static Type[] GetGenericTypes<T1, T2, T3>()
        {
            Type[] methodParameterTypes = new Type[3];
            methodParameterTypes[0] = typeof(T1);
            methodParameterTypes[1] = typeof(T2);
            methodParameterTypes[2] = typeof(T3);
            return methodParameterTypes;
        }
        public static Type[] GetGenericTypes<T1, T2, T3, T4>()
        {
            Type[] methodParameterTypes = new Type[4];
            methodParameterTypes[0] = typeof(T1);
            methodParameterTypes[1] = typeof(T2);
            methodParameterTypes[2] = typeof(T3);
            methodParameterTypes[3] = typeof(T4);
            return methodParameterTypes;
        }
        public static Type[] GetGenericTypes<T1, T2, T3, T4, T5>()
        {
            Type[] methodParameterTypes = new Type[5];
            methodParameterTypes[0] = typeof(T1);
            methodParameterTypes[1] = typeof(T2);
            methodParameterTypes[2] = typeof(T3);
            methodParameterTypes[3] = typeof(T4);
            methodParameterTypes[4] = typeof(T5);
            return methodParameterTypes;
        }
        public static Type[] GetGenericTypes<T1, T2, T3, T4, T5, T6>()
        {
            Type[] methodParameterTypes = new Type[6];
            methodParameterTypes[0] = typeof(T1);
            methodParameterTypes[1] = typeof(T2);
            methodParameterTypes[2] = typeof(T3);
            methodParameterTypes[3] = typeof(T4);
            methodParameterTypes[4] = typeof(T5);
            methodParameterTypes[5] = typeof(T6);
            return methodParameterTypes;
        }
        public static Type[] GetGenericTypes<T1, T2, T3, T4, T5, T6, T7>()
        {
            Type[] methodParameterTypes = new Type[7];
            methodParameterTypes[0] = typeof(T1);
            methodParameterTypes[1] = typeof(T2);
            methodParameterTypes[2] = typeof(T3);
            methodParameterTypes[3] = typeof(T4);
            methodParameterTypes[4] = typeof(T5);
            methodParameterTypes[5] = typeof(T6);
            methodParameterTypes[6] = typeof(T7);
            return methodParameterTypes;
        }
        public static Type[] GetGenericTypes<T1, T2, T3, T4, T5, T6, T7, T8>()
        {
            Type[] methodParameterTypes = new Type[8];
            methodParameterTypes[0] = typeof(T1);
            methodParameterTypes[1] = typeof(T2);
            methodParameterTypes[2] = typeof(T3);
            methodParameterTypes[3] = typeof(T4);
            methodParameterTypes[4] = typeof(T5);
            methodParameterTypes[5] = typeof(T6);
            methodParameterTypes[6] = typeof(T7);
            methodParameterTypes[7] = typeof(T8);
            return methodParameterTypes;
        }
        public static Type[] GetGenericTypes<T1, T2, T3, T4, T5, T6, T7, T8, T9>()
        {
            Type[] methodParameterTypes = new Type[9];
            methodParameterTypes[0] = typeof(T1);
            methodParameterTypes[1] = typeof(T2);
            methodParameterTypes[2] = typeof(T3);
            methodParameterTypes[3] = typeof(T4);
            methodParameterTypes[4] = typeof(T5);
            methodParameterTypes[5] = typeof(T6);
            methodParameterTypes[6] = typeof(T7);
            methodParameterTypes[7] = typeof(T8);
            methodParameterTypes[8] = typeof(T9);
            return methodParameterTypes;
        }

        public static void CallMethod(Type type, MethodInfo info)
        {
            ILGenerator il = ThreadCache.GetIL();
            if (type.IsValueType || info.IsStatic)
            {
                DebugHelper.WriteLine("Call", info.Name);
                il.Emit(OpCodes.Call, info);
            }
            else
            {
                DebugHelper.WriteLine("Callvirt", info.Name);
                il.Emit(OpCodes.Callvirt, info);
            }
        }

        //返回
        public static void Return()
        {
            ILGenerator il = ThreadCache.GetIL();
            il.Emit(OpCodes.Ret);
            DebugHelper.WriteLine("Ret");
        }

        //压栈并返回
        public static void ReturnValue(object value)
        {
            DataHelper.NoErrorLoad(value, ThreadCache.GetIL());
            Return();
        }
    }
}
