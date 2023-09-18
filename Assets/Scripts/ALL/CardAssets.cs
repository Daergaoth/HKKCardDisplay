using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static CardInfoAsset;
using static LoadDataFromCSV;

public class CardAssets
{
    public static List<CardInfoAsset> cardInfoAssets = new List<CardInfoAsset>();


    public static bool LoadCardAssets(List<TextAssetItem> textAssets, List<Sprite> cardImageList)
    {

        try
        {
            foreach (TextAssetItem textAssetItem in textAssets)
            {

                //----------------------------- Create Base Assets -----------------------------
                int NumberOfColumnsInCSV = 14;
                string[] data = textAssetItem.cardAssetsSource.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);
                int tableSize = data.Length / NumberOfColumnsInCSV - 1;

                for (int i = 0; i < tableSize; i++)
                {
                    if (data[NumberOfColumnsInCSV * (i + 1)].Trim().Length > 0)
                    {
                        CardInfoAsset currentItem = new();
                        currentItem.cardID = Convert.ToInt32(data[NumberOfColumnsInCSV * (i + 1)].Trim());
                        currentItem.Title = data[NumberOfColumnsInCSV * (i + 1) + 1];
                        currentItem.release = data[NumberOfColumnsInCSV * (i + 1) + 2];
                        currentItem.ReleaseYear = Convert.ToInt32(data[NumberOfColumnsInCSV * (i + 1) + 3]);
                        currentItem.Description = data[NumberOfColumnsInCSV * (i + 1) + 4].Replace("[ENTER]", "\n").Replace("[COMA]", ",");
                        currentItem.DecorationText = data[NumberOfColumnsInCSV * (i + 1) + 5].Replace("[ENTER]", "\n").Replace("[COMA]", ",");
                        currentItem.Illustrator = data[NumberOfColumnsInCSV * (i + 1) + 6];
                        currentItem.Rarity = ((Rarity)Rarity.GYAKORI.GetEnumValueByDisplayName(data[NumberOfColumnsInCSV * (i + 1) + 7]));

                        currentItem.CardImage = (from s in cardImageList
                                                 where s.name == data[NumberOfColumnsInCSV * (i + 1) + 8]
                                                 select s).ToList().First();

                        List<string> temp = GetStringArray(data[NumberOfColumnsInCSV * (i + 1) + 9].Trim());
                        if (temp.Count > 0)
                        {
                            foreach (string item in temp)
                            {
                                currentItem.GroupTypeList.Add(((Group)Group.BARD.GetEnumValueByDisplayName(item)));
                            }
                        }

                        temp = GetStringArray(data[NumberOfColumnsInCSV * (i + 1) + 10].Trim());
                        if (temp.Count > 0)
                        {
                            foreach (string item in temp)
                            {
                                currentItem.MainTypeList.Add(((MainType)MainType.NONE.GetEnumValueByDisplayName(item)));
                            }
                        }

                        temp = GetStringArray(data[NumberOfColumnsInCSV * (i + 1) + 11].Trim());
                        if (temp.Count > 0)
                        {
                            foreach (string item in temp)
                            {
                                currentItem.SubTypeList.Add(((SubType)SubType.NONE.GetEnumValueByDisplayName(item)));
                            }
                        }

                        currentItem.SpecialNotes = data[NumberOfColumnsInCSV * (i + 1) + 12].Trim().Replace("[ENTER]", "\n").Replace("[COMA]", ",");

                        if (currentItem.Title == null
                            || currentItem.release == null
                            || currentItem.ReleaseYear == 0
                            || currentItem.Illustrator == null
                            || currentItem.CardImage == null
                            || currentItem.GroupTypeList == null
                            || currentItem.GroupTypeList.Count == 0
                            || currentItem.MainTypeList == null
                            || currentItem.MainTypeList.Count == 0)
                        {
                            return false;
                        }
                        else
                        {
                            cardInfoAssets.Add(currentItem);
                        }
                    }
                }











                //----------------------------- Add Icons To Card Assests -----------------------------
                NumberOfColumnsInCSV = 4;
                data = textAssetItem.cardIconsSource.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);
                tableSize = data.Length / NumberOfColumnsInCSV - 1;

                for (int i = 0; i < tableSize; i++)
                {
                    if (data[NumberOfColumnsInCSV * (i + 1)].Trim().Length > 0)
                    {
                        int cardID = Convert.ToInt32(data[NumberOfColumnsInCSV * (i + 1)].Trim());

                        CardInfoAsset currentItem = GetCardAssetwithData(cardID);

                        if (currentItem != null)
                        {
                            Icons icon = ((Icons)Icons.OSMAGIA.GetEnumValueByDisplayName(data[NumberOfColumnsInCSV * (i + 1) + 1]));
                            int amount = Convert.ToInt32(data[NumberOfColumnsInCSV * (i + 1) + 2]);
                            currentItem.IconList.Add(new CardInfoAsset.IconMap(icon, amount));
                        }
                    }
                    
                }








                //----------------------------- Add Effects To Card Assests -----------------------------
                NumberOfColumnsInCSV = 9;
                data = textAssetItem.cardEffectsSource.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);
                tableSize = data.Length / NumberOfColumnsInCSV - 1;

                for (int i = 0; i < tableSize; i++)
                {

                    if (data[NumberOfColumnsInCSV * (i + 1)].Trim().Length > 0)
                    {
                        int cardID = Convert.ToInt32(data[NumberOfColumnsInCSV * (i + 1)].Trim());

                        CardInfoAsset currentItem = GetCardAssetwithData(cardID);

                        if (currentItem != null)
                        {

                            int effectID = Convert.ToInt32(data[NumberOfColumnsInCSV * (i + 1) + 1]);

                            EffectType effectType = (EffectType)EffectType.OSMAGIA.GetEnumValueByDisplayName(data[NumberOfColumnsInCSV * (i + 1) + 2]);

                            DurationType duration = (DurationType)DurationType.ALLANDO.GetEnumValueByDisplayName(data[NumberOfColumnsInCSV * (i + 1) + 3]);

                            int durationAmount = 0;

                            if (data[NumberOfColumnsInCSV * (i + 1) + 4].Trim().Length > 0)
                            {
                                durationAmount = Convert.ToInt32(data[NumberOfColumnsInCSV * (i + 1) + 4]);
                            }

                            List<string> temp = GetStringArray(data[NumberOfColumnsInCSV * (i + 1) + 5].Trim());
                            List<Phase> phaseList = new();
                            if (temp.Count > 0)
                            {
                                foreach (string item in temp)
                                {
                                    phaseList.Add((Phase)Phase.SAJAT_ELOKESZITO_EGY.GetEnumValueByDisplayName(item));
                                }
                            }

                            temp = GetStringArray(data[NumberOfColumnsInCSV * (i + 1) + 6].Trim());
                            List<Target> targetList = new();
                            if (temp.Count > 0)
                            {
                                foreach (string item in temp)
                                {
                                    targetList.Add((Target)Target.SAJAT_BUBAJ.GetEnumValueByDisplayName(item));
                                }
                            }

                            int amount = 0;

                            if (data[NumberOfColumnsInCSV * (i + 1) + 7].Trim().Length > 0)
                            {
                                amount = Convert.ToInt32(data[NumberOfColumnsInCSV * (i + 1) + 7]);
                            }

                            currentItem.effectList.Add(new CardInfoAsset.Effect(Convert.ToInt32(data[NumberOfColumnsInCSV * (i + 1)].Trim()), effectID, effectType, duration, durationAmount, phaseList, targetList, amount));

                        }
                    }
                        

                }






                //----------------------------- Add Actions To Card Assests -----------------------------
                NumberOfColumnsInCSV = 13;
                data = textAssetItem.cardActionsSource.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);
                tableSize = data.Length / NumberOfColumnsInCSV - 1;

                for (int i = 0; i < tableSize; i++)
                {
                    if (data[NumberOfColumnsInCSV * (i + 1)].Trim().Length > 0)
                    {
                        int cardID = Convert.ToInt32(data[NumberOfColumnsInCSV * (i + 1)].Trim());
                        CardInfoAsset currentItem = GetCardAssetwithData(cardID);

                        if (currentItem != null)
                        {

                            ActionEntry actionToAdd = new();

                            actionToAdd.actionID = Convert.ToInt32(data[NumberOfColumnsInCSV * (i + 1) + 1]);
                            actionToAdd.actionType = (ActionType)ActionType.LAPKIJATSZAS.GetEnumValueByDisplayName(data[NumberOfColumnsInCSV * (i + 1) + 2]);



                            if (data[NumberOfColumnsInCSV * (i + 1) + 3].Trim().Length > 0)
                            {
                                int parentActionID = Convert.ToInt32(data[NumberOfColumnsInCSV * (i + 1) + 3].Trim());
                                if (parentActionID != 0)
                                {
                                    bool parentFound = false;
                                    foreach (CardInfoAsset card in cardInfoAssets)
                                    {
                                        if (!parentFound)
                                        {
                                            foreach (ActionEntry action in card.actionList)
                                            {
                                                if (!parentFound && action.actionID == parentActionID)
                                                {
                                                    actionToAdd.parentAction = action;
                                                    parentFound = true;
                                                }
                                            }
                                        }

                                    }
                                }
                            }



                            List<string> temp = GetStringArray(data[NumberOfColumnsInCSV * (i + 1) + 4].Trim());
                            List<Phase> phaseList = new();
                            if (temp.Count > 0)
                            {
                                foreach (string item in temp)
                                {
                                    phaseList.Add((Phase)Phase.SAJAT_ELOKESZITO_EGY.GetEnumValueByDisplayName(item));
                                }
                            }

                            actionToAdd.phase = phaseList;

                            temp = GetStringArray(data[NumberOfColumnsInCSV * (i + 1) + 5].Trim());
                            List<ActionEntry> impactedActionList = new();
                            if (temp.Count > 0)
                            {
                                foreach (string item in temp)
                                {
                                    bool parentFound = false;
                                    foreach (CardInfoAsset card in cardInfoAssets)
                                    {
                                        if (!parentFound)
                                        {
                                            foreach (ActionEntry action in card.actionList)
                                            {
                                                if (!parentFound && action.actionID == Convert.ToInt32(item.Trim()))
                                                {
                                                    impactedActionList.Add(action);
                                                    parentFound = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            actionToAdd.actionIdList = impactedActionList;

                            actionToAdd.who = (Player)Player.JATEKOS.GetEnumValueByDisplayName(data[NumberOfColumnsInCSV * (i + 1) + 6]);

                            if (data[NumberOfColumnsInCSV * (i + 1) + 7].Trim().Length > 0)
                            {
                                actionToAdd.amount = Convert.ToInt32(data[NumberOfColumnsInCSV * (i + 1) + 7].Trim());
                            }

                            actionToAdd.from = (Place)Place.SAJAT_KEZ.GetEnumValueByDisplayName(data[NumberOfColumnsInCSV * (i + 1) + 8]);

                            actionToAdd.to = (Place)Place.SAJAT_KEZ.GetEnumValueByDisplayName(data[NumberOfColumnsInCSV * (i + 1) + 9]);

                            if (data[NumberOfColumnsInCSV * (i + 1) + 10].Trim().Length > 0)
                            {
                                actionToAdd.canSplitTargetAmongTargetTypes = Convert.ToBoolean(data[NumberOfColumnsInCSV * (i + 1) + 10].Trim());
                            }

                            temp = GetStringArray(data[NumberOfColumnsInCSV * (i + 1) + 11].Trim());
                            List<Effect> triggeredEffects = new();
                            if (temp.Count > 0)
                            {
                                foreach (string item in temp)
                                {
                                    bool effectFound = false;
                                    foreach (CardInfoAsset card in cardInfoAssets)
                                    {
                                        if (!effectFound)
                                        {
                                            foreach (Effect effect in card.effectList)
                                            {
                                                if (!effectFound && effect.effectID == Convert.ToInt32(item.Trim()))
                                                {
                                                    triggeredEffects.Add(effect);
                                                    effectFound = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                            actionToAdd.triggeredEffects = triggeredEffects;

                            actionToAdd.cardID = cardID;

                            currentItem.actionList.Add(actionToAdd);
                        }
                    }
                        

                }










                //----------------------------- Add Summon Costs To Card Assests -----------------------------
                NumberOfColumnsInCSV = 5;
                data = textAssetItem.cardActionCostSource.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);
                tableSize = data.Length / NumberOfColumnsInCSV - 1;

                for (int i = 0; i < tableSize; i++)
                {
                    if (data[NumberOfColumnsInCSV * (i + 1)].Trim().Length > 0)
                    {
                        int cardID = Convert.ToInt32(data[NumberOfColumnsInCSV * (i + 1)].Trim());
                        CardInfoAsset currentItem = GetCardAssetwithData(cardID);

                        if (currentItem != null)
                        {
                            SummonCostMap summonCostsToAdd = new();

                            bool actionFound = false;
                            foreach (CardInfoAsset card in cardInfoAssets)
                            {
                                if (!actionFound)
                                {
                                    foreach (ActionEntry action in card.actionList)
                                    {
                                        if (!actionFound && action.actionID == Convert.ToInt32(data[NumberOfColumnsInCSV * (i + 1) + 1].Trim()))
                                        {
                                            summonCostsToAdd.actionID = action;
                                            actionFound = true;
                                        }
                                    }
                                }
                            }


                            summonCostsToAdd.summonCostType = (SummonCostType)SummonCostType.EPITO.GetEnumValueByDisplayName(data[NumberOfColumnsInCSV * (i + 1) + 2]);

                            if (data[NumberOfColumnsInCSV * (i + 1) + 3].Trim().Length > 0)
                            {
                                summonCostsToAdd.amount = Convert.ToInt32(data[NumberOfColumnsInCSV * (i + 1) + 3].Trim());
                            }

                            summonCostsToAdd.cardID = cardID;

                            currentItem.SummonCost.Add(summonCostsToAdd);
                        }
                    }
                        
                }
            }
            return true;
        }
        catch (Exception e)
        {
            Debug.LogError(e.Message);
            Debug.LogError(e.StackTrace);
            return false;
        }
    }

    private static List<string> GetStringArray(string item)
    {
        string[] temp = item.Split("/");
        List<string> result = new();
        if (temp.Length >0)
        {
            foreach (string elem in temp)
            {
                if (elem.Trim().Length > 0)
                {
                    result.Add(elem);
                }
            }
        }
        
        return result;
    }

    private static CardInfoAsset GetCardAssetwithData(int cardID)
    {
         return (from c in cardInfoAssets where c.cardID == cardID select c).ToList().First();
    }

}
