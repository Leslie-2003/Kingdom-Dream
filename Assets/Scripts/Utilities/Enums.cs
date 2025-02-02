using System;

[Flags] //实现多选
public enum RoomType
{
    MinorEnemy=1, 

    EliteEnemy=2, 

    Shop=4, 

    Treasure=8,

    RestRoom=16,

    Boss=32

}

public enum RoomState
{
    locked,

    visitied,

    attainable
}

public enum CardType
{
    Attack,
    Defense,
    Abilities,
}

public enum EffectTargetType
{
    Self, //自己
    Target, //单体敌人类型
    All , //群体类型
}