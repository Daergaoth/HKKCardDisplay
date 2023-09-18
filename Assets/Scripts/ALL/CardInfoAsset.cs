using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card", order = 1)]
public class CardInfoAsset : ScriptableObject
{
    public string Title;

    public int cardID;

    public string release;

    public int ReleaseYear;

    public string Illustrator;

    public Sprite CardImage;

    public Rarity Rarity;

    public List<MainType> MainTypeList = new();

    public List<SubType> SubTypeList = new();

    public List<Group> GroupTypeList = new();

    [System.Serializable]
    public class Effect
    {
        public int effectID;
        public int cardID;
        public EffectType effectType;
        public DurationType duration;
        public int DurationAmount;
        public List<Phase> activePhase;
        public List<Target> efftectTargetType = new();
        public int amount;

        public Effect(int cardID, int effectID, EffectType effectType, DurationType duration, int DurationAmount, List<Phase> activePhase, List<Target> efftectTargetType, int amount)
        {
            this.effectID = effectID;
            this.cardID = effectID;
            this.effectType = effectType;
            this.duration = duration;
            this.DurationAmount = DurationAmount;
            this.activePhase = activePhase;
            this.efftectTargetType = efftectTargetType;
            this.amount = amount;
    }
    }

    public List<Effect> effectList = new();

    [System.Serializable]
    public class ActionEntry
    {
        public int actionID;
        public int cardID;
        public ActionType actionType;
        public ActionEntry parentAction;
        public List<Phase> phase;
        public List<ActionEntry> actionIdList = new();
        public Player who;
        public int amount;
        public Place from;
        public Place to;
        public bool canSplitTargetAmongTargetTypes;
        public List<Effect> triggeredEffects = new();

        public ActionEntry(int cardID, int actionID, ActionType actionType, ActionEntry parentAction, List<Phase> phase, List<ActionEntry> actionIdList, Player who, int amount, Place from, Place to, bool canSplitTargetAmongTargetTypes, List<Effect> triggeredEffects)
        {
            this.actionID = actionID;
            this.cardID = cardID;
            this.actionType = actionType;
            this.parentAction = parentAction;
            this.phase = phase;
            this.actionIdList = actionIdList;
            this.who = who;
            this.amount = amount;
            this.from = from;
            this.to = to;
            this.canSplitTargetAmongTargetTypes = canSplitTargetAmongTargetTypes;
            this.triggeredEffects = triggeredEffects;
        }

        public ActionEntry() { }

    }

    public List<ActionEntry> actionList = new();

    [System.Serializable]
    public class SummonCostMap
    {
        public SummonCostType summonCostType;
        public int amount;
        public ActionEntry actionID;
        public int cardID;

        public SummonCostMap() { }
    }

    public List<SummonCostMap> SummonCost = new();

    [System.Serializable]
    public class IconMap
    {
        public Icons Icon;
        public int Amount;

        public IconMap(Icons icon, int amount)
        {
            this.Icon = icon;
            this.Amount = amount;
        }
    }

    public List<IconMap> IconList = new();

    [TextArea(3, 10)]
    public string Description;

    [TextArea(3, 10)]
    public string DecorationText;

    [TextArea(3, 10)]
    public string SpecialNotes;
}

