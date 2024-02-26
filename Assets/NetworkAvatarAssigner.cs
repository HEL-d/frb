using FirstGearGames.LobbyAndWorld.Lobbies.JoinCreateRoomCanvases;
using FishNet.Object;
using System.Collections.Generic;
using UnityEngine;
using FirstGearGames.LobbyAndWorld.Clients;
using System;

using FishNet.Object.Synchronizing;

using Unity.VisualScripting;
using ReadyPlayerMe.Core;
using FishNet.Component.Animating;
using UnityEngine.Rendering;

public class NetworkAvatarAssigner : NetworkBehaviour
{
        

    #region Ready Player Me Setting
    [Space]
    [Tooltip("Default value will be override at runtime")]
    [Header("ReadyPlayerMe Avatar Settings")]
    [Space]
    [SerializeField] private string avatarUrl;
    [SerializeField] private GameObject parentRef;
    [SerializeField] public Transform avatarSpawnPosition;
    #endregion


    #region Avatar Loader Var
    //  private readonly Network<NetworkString> avatarUrl_nw = new();
    //   ClientInstance ci = ClientInstance.ReturnClientInstance(Owner);
    //  string avatarur = ci.PlayerSettings.GetUsername();
    [SyncVar]
    private string avatarUrl_nw;
    private GameObject avatar;
    private bool avatarLoaded;
    private const string PARENT = "ParentRef";
    #endregion

    #region Eye Animation Handler Setting
    [Space]
    [Tooltip("Eye Animator Setting")]
    [Header("Eye Animator")]
    [Space]
    public bool useEyeAnimator;
    [Range(0, 1)] public float BlinkSpeed = 0.1f;
    [Range(1, 10)] public float BlinkInterval = 3f;
    #endregion

    public int spawnpoints;
    public Vector3 rotation;

    





    // Start is called before the first frame update
    void Start()
    {
        avatarLoaded = false;
        


    }

  

    private void FixedUpdate()
    {
        if (avatarLoaded) { return; }
        else
        {
            if (avatarUrl == null) { return; }

            if (!GetAvatarUrl().Equals(avatarUrl))
            {
                avatarUrl = GetAvatarUrl();
            }

            StartLoadAvatar(GetAvatarUrl());
            avatarLoaded = true;
          
        }

    }
    public void SetAvatarUrl(string _avatarUrl)
    {
        avatarUrl = _avatarUrl;
        avatarUrl_nw = _avatarUrl;
    }
    private string GetAvatarUrl()
    {
        return avatarUrl_nw;
    }

    
  private void StartLoadAvatar(string v)
    {
        ApplicationData.Log();
        var avatarLoader = new AvatarObjectLoader();
        avatarLoader.OnCompleted += (_, args) =>
        {
           
            avatar = args.Avatar;
              if(args.Metadata.OutfitGender == OutfitGender.Masculine)
            {
                avatar.GetComponent<Animator>().runtimeAnimatorController = transform.GetComponent<Animator>().runtimeAnimatorController;
                avatar.AddComponent<AnimationStateConroller>();
                avatar.transform.localScale = new Vector3(0.95f, 0.95f, 0.95f);
            }  else
            {
                avatar.GetComponent<Animator>().runtimeAnimatorController = transform.GetComponent<Animator>().runtimeAnimatorController;
                avatar.AddComponent<AnimationStateConroller>();
            }


           
            
   
            avatar.AddComponent<EyeAnimationHandler>();
           
            if (parentRef.name == v)
            {
                avatar.transform.parent = transform;
               
              avatar.transform.SetPositionAndRotation(avatarSpawnPosition.position, avatarSpawnPosition.rotation);
                
            }






            
            parentRef.name = PARENT;
           
        };
        avatarLoader.LoadAvatar(v);
        parentRef.name = v;



    }

   
    








   

    private void OnDestroy()
    {
        if(avatar != null) Destroy(avatar);
        
        

       }
        




  
  
}
