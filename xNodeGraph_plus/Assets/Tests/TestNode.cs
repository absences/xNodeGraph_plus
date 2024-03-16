using UnityEngine;
using Game.Graph;
using System;

public class TestNode : MonoBehaviour
{

    public BaseGraph graph;

    [SerializeField]
    private Blackboard blackboard = new Blackboard();
    private Runtime runtime;

    protected void Awake()
    {
        //var unit = new Blackboard.Unit();
        var var=  AddVar(typeof(UEFun));

        var.fun=new UEFun ();
        var.name="fun1";

        var.fun.value = () => {

            Debug.Log("invoked");
        };
        this.runtime = new Runtime(this.graph, this.blackboard);
        this.runtime.RunFunc("Awake");
    }
    Blackboard.Unit AddVar(Type type)
    {
        Blackboard.Unit unit = new Blackboard.Unit();
        unit.type = type.ToString();

        if (type == typeof(Number))
        {
            unit.number = new Number();
        }
        else if (type == typeof(Boolen))
        {
            unit.boolean = new Boolen();
        }
        else if (type == typeof(Vec3))
        {
            unit.vec3 = new Vec3();
        }
        else if (type == typeof(Col))
        {
            unit.col = new Col();
        }
        else if (type == typeof(string))
        {
            unit.text = "";
        }

        var values = new Blackboard.Unit[blackboard.values.Length + 1];
        blackboard.values.CopyTo(values, 0);
        values[blackboard.values.Length] = unit;
        blackboard.values = values;

        return unit;
    }
}
