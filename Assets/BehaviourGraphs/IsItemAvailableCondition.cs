using System;
using Unity.Behavior;
using UnityEngine;

[Serializable, Unity.Properties.GeneratePropertyBag]
[Condition(name: "isItemAvailable", story: "[Item] is available", category: "Conditions", id: "f4dbfe425ef1f111beb9e98bd9268c87")]
public partial class IsItemAvailableCondition : Condition
{
    [SerializeReference] public BlackboardVariable<GameObject> Item;

    public override bool IsTrue()
    {
        return Item.Value.activeSelf;
    }

    public override void OnStart()
    {
    }

    public override void OnEnd()
    {
    }
}
