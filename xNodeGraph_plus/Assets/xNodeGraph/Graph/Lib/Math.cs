using UnityEngine;

using Game.Graph;
using Cysharp.Threading.Tasks;
using System;

namespace Game.Lib {
    public static class Math {
        [Node("数学-相加", "a + b", false)]
        public static float Add(float a, float b) {
            return a + b;
        }
        [Node("数学-相减", "a - b", false)]
        public static float Sub(float a, float b)
        {
            return a - b;
        }
        [Node("数学-相乘", "a * b", false)]
        public static float Multiplie(float a, float b)
        {
            return a * b;
        }
        [Node("数学-相除", "a / b", false)]
        public static float Divided(float a, float b)
        {

            return a / b;
        }
        [Node("数学-对象", "", true)]
        public static object ObjectTT(object p)
        {
            return p;
        }



        [Node("数学-取整数")]
        public static object SetInt(object v) {

            return (int)v;
        }
    }

    public static class CommonLib
    {
        //[Node("通用-等待","等待流程(millisecond)")]
        //public async static UniTask Wait(int millisecond)
        //{
        //    await UniTask.Delay(millisecond);
        //    Debug.Log("等待了" + millisecond + "毫秒");
        //}

        [Node("通用-查找物体", "根据名称获取物体对象")]
        public async static UniTask<GameObject> FindGameObject(string name)
        {
            var go=GameObject.Find(name);

            await UniTask.CompletedTask;

            return go;
        }


        [Node("通用-设置物体名称", "", true, "gameObject")]
        public static void SetName(object obj, string named)
        {
            (obj as GameObject).name = named;
        }

        [Node("通用-取(object)名称", "获取obj.Tostring()", false)]
        public static string GetName(object p)
        {
            return p.ToString();
        }

        [Node("通用-调用Action方法", "", true)]
        public static void CallFun(Action action)
        {
            action?.Invoke();
        }
        [Node("通用-打开界面", "等待打开界面", true)]
        public static async UniTask OpenView(string viewName)
        {
            await UniTask.CompletedTask;
            Debug.Log("打开界面"+ viewName);
        }
        [Node("通用-获取结果", "等待", false)]
        public static async UniTask<bool> GetBoolen()
        {
            await UniTask.Delay(1000);

            return true;
        }
    }
}