using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class LoadDataFromCSV : MonoBehaviour
{

    public GameObject LoadParent;

    public GameObject ImageTargetParent;

    public List<GameObject> imageTargets;

    [System.Serializable]
    public class TextAssetItem
    {
        public TextAsset cardAssetsSource;
        public TextAsset cardIconsSource;
        public TextAsset cardActionCostSource;
        public TextAsset cardActionsSource;
        public TextAsset cardEffectsSource;
    }

    public List<TextAssetItem> textAssets;

    public List<Sprite> cardImageList;


    // Start is called before the first frame update
    void Start()
    {
        // Thread thread = new(LoadCardScan);
        //thread.Start();
        LoadCardScan();
    }

    private void LoadCardScan()
    {
        bool result;
        if (RuleBook.IconExplanationMap.Count == 0)
        {
            if (!RuleBook.RuleBookLoaded)
            {
                RuleBook.LoadRuleBook();
            }
            else
            {
                Debug.Log("A szab�lyk�nyv bet�lt�se megt�rt�nt kor�bban.");
            }
            
            if (RuleBook.RuleBookLoaded)
            {
                Debug.Log("Szab�lyk�nyv sikeresen bet�ltve.");
                if (CardAssets.cardInfoAssets.Count == 0)
                {
                    result = CardAssets.LoadCardAssets( textAssets, cardImageList);

                    if (result)
                    {
                        Debug.Log("K�rty�k sikeresen bet�ltve.");
                        if (imageTargets.Count == 0 && ImageTargetParent != null)
                        {
                            VuforiaApplication.Instance.OnVuforiaStarted += CreateImageTargetFromSideloadedTexture;
                            //LoadParent.SetActive(false);
                        }
                        else if(imageTargets.Count != 0)
                        {
                            Debug.Log("K�rtya Objektumok sikeresen bet�ltve.");
                        }else if (ImageTargetParent == null)
                        {
                            Debug.Log("K�rtya Objektumok bet�lt�se �tugorva.");
                        }
                    }
                    else
                    {
                        Debug.Log("K�rty�k bet�lt�se sikertelen.");
                    }
                }
                else
                {
                    Debug.Log("A k�rty�k m�r kor�bban be lettek t�ltve.");
                    if (imageTargets.Count == 0 && ImageTargetParent != null)
                    {
                        VuforiaApplication.Instance.OnVuforiaStarted += CreateImageTargetFromSideloadedTexture;
                        //LoadParent.SetActive(false);
                    }
                    else if (imageTargets.Count != 0)
                    {
                        Debug.Log("K�rtya Objektumok sikeresen bet�ltve.");
                    }
                    else if (ImageTargetParent == null)
                    {
                        Debug.Log("K�rtya Objektumok bet�lt�se �tugorva.");
                    }
                }
            }
            else
            {
                Debug.Log("Szab�lyk�nyv bet�lt�se sikertelen.");
            }
        }
        else
        {
            Debug.Log("A szab�lyk�nyv bet�lt�se megt�rt�nt kor�bban.");
            if (CardAssets.cardInfoAssets.Count == 0)
            {
                result = CardAssets.LoadCardAssets(textAssets, cardImageList);

                if (result)
                {
                    Debug.Log("K�rty�k sikeresen bet�ltve.");
                    if (imageTargets.Count == 0)
                    {
                        //result = LoadImageTargets();

                        VuforiaApplication.Instance.OnVuforiaStarted += CreateImageTargetFromSideloadedTexture;
                        //LoadParent.SetActive(false);
                    }
                    else
                    {
                        Debug.Log("K�rtya Objektumok sikeresen bet�ltve.");
                    }
                }
                else
                {
                    Debug.Log("K�rty�k bet�lt�se sikertelen.");
                }
            }
            else
            {
                Debug.Log("A k�rty�k m�r kor�bban be lettek t�ltve.");
                if (imageTargets.Count == 0 && ImageTargetParent != null)
                {
                    VuforiaApplication.Instance.OnVuforiaStarted += CreateImageTargetFromSideloadedTexture;
                    //LoadParent.SetActive(false);
                }
                else if (imageTargets.Count != 0)
                {
                    Debug.Log("K�rtya Objektumok sikeresen bet�ltve.");
                }
                else if (ImageTargetParent == null)
                {
                    Debug.Log("K�rtya Objektumok bet�lt�se �tugorva.");
                }
            }
        }
    }

    private void CreateImageTargetFromSideloadedTexture()
    {
        try
        {

            foreach (CardInfoAsset item in CardAssets.cardInfoAssets)
            {

                var mTarget = VuforiaBehaviour.Instance.ObserverFactory.CreateImageTarget(item.CardImage.texture, 1, item.CardImage.name);
                // add the Default Observer Event Handler to the newly created game object
                mTarget.gameObject.AddComponent<DefaultObserverEventHandler>();
                Debug.Log("Instant Image Target created " + mTarget.TargetName);
                Vector3 pos = new(0, 0, 0);
                GameObject inited = GameObject.Instantiate(ImageTargetParent, pos, Quaternion.identity);
                inited.transform.parent = mTarget.gameObject.transform;

                ARLayout aRLayout = inited.GetComponent<ARLayout>();
                aRLayout.CardInfoAsset = item;
                aRLayout.setupComponent();
            }

            
            //ImageTargetParent.SetActive(true);
            //ImageTargetInitSuccess = true;
        }
        catch (Exception e)
        {
            Debug.LogError(e.Message);
            Debug.LogError(e.StackTrace);
        }
    }
}
