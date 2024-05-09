using FirstGearGames.LobbyAndWorld.Lobbies.JoinCreateRoomCanvases;
using FirstGearGames.LobbyAndWorld.Lobbies;
using FishNet.Object;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FishNet.Connection;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;
using FirstGearGames.LobbyAndWorld.Clients;
using FishNet;
using FirstGearGames.LobbyAndWorld.Global.Canvases;
using FirstGearGames.LobbyAndWorld.Global;
using System;
using System.Linq;
using UnityEngine.UIElements;

public class GameMan : NetworkBehaviour
{
    #region Serialized
    [Header("Spawning")]
    /// <summary>
    /// Region players may spawn.
    /// </summary>
    [Tooltip("Region players may spawn.")]
    [SerializeField]
    private Transform _spawnRegion;
    /// <summary>
    /// Prefab to spawn.
    /// </summary>
    /// 
    [Tooltip("Region players may spawn.")]
    [SerializeField]
    private Transform _spawnRegion2;
    /// <summary>
    /// Prefab to spawn.
    /// </summary>
    /// 



    [Tooltip("Prefab to spawn.")]
    [SerializeField]
    private NetworkObject _playerPrefab = null;
 
    #endregion

    /// <summary>
    /// RoomDetails for this game. Only available on the server.
    /// </summary>
    private RoomDetails _roomDetails = null;
    /// <summary>
    /// LobbyNetwork.
    /// </summary>
    private LobbyNetwork _lobbyNetwork = null;
    /// <summary>
    /// Currently spawned player objects. Only exist on the server.
    /// </summary>


    private List<NetworkObject> _spawnedPlayerObjects = new List<NetworkObject>();
    
    //  public bool ispositionoccupied = false;


    private void OnDestroy()
    {
        if (_lobbyNetwork != null)
        {
            _lobbyNetwork.OnClientJoinedRoom -= LobbyNetwork_OnClientStarted;
            _lobbyNetwork.OnClientLeftRoom -= LobbyNetwork_OnClientLeftRoom;
        }
    }

    /// <summary>
    /// Initializes this script for use.
    /// </summary>
    public void FirstInitialize(RoomDetails roomDetails, LobbyNetwork lobbyNetwork)
    {
        _roomDetails = roomDetails;
        _lobbyNetwork = lobbyNetwork;
        _lobbyNetwork.OnClientStarted += LobbyNetwork_OnClientStarted;
        _lobbyNetwork.OnClientLeftRoom += LobbyNetwork_OnClientLeftRoom;
    }

    /// <summary>
    /// Called when a client leaves the room.
    /// </summary>
    /// <param name="arg1"></param>
    /// <param name="arg2"></param>
    private void LobbyNetwork_OnClientLeftRoom(RoomDetails arg1, NetworkObject arg2)
    {

      

      
        
        //Destroy all of clients objects, except their client instance.
        for (int i = 0; i < _spawnedPlayerObjects.Count; i++)
        {
            NetworkObject entry = _spawnedPlayerObjects[i];
            //Entry is null. Remove and iterate next.
            if (entry == null)
            {
                _spawnedPlayerObjects.RemoveAt(i);
                i--;
                continue;
            }

            //If same connection to client (owner) as client instance of leaving player.
            if (_spawnedPlayerObjects[i].Owner == arg2.Owner)
            {
                //Destroy entry then remove from collection.
                entry.Despawn();
                _spawnedPlayerObjects.RemoveAt(i);
                i--;
            }

         


        }

        
           
         




    }

    /// <summary>
    /// Called when a client starts a game.
    /// </summary>
    /// <param name="roomDetails"></param>
    /// <param name="client"></param>
    private void LobbyNetwork_OnClientStarted(RoomDetails roomDetails, NetworkObject client)
    {
        //Not for this room.
        if (roomDetails != _roomDetails)
            return;
        //NetIdent is null or not a player.
        if (client == null || client.Owner == null)
            return;

        /* POSSIBLY USEFUL INFORMATION!!!!!
         * POSSIBLY USEFUL INFORMATION!!!!!
         * If you want to wait until all players are in the scene
         * before spaning then check if roomDetails.StartedMembers.Count
         * is the same as roomDetails.MemberIds.Count. A member is considered
         * started AFTER they have loaded all of the scenes. */
        SpawnPlayer(client.Owner);
    }





    /// <summary>
    /// Spawns a player at a random position for a connection.
    /// </summary>
    /// <param name="conn"></param>
    public void SpawnPlayer(NetworkConnection conn)
    {
       
             Vector3 position = _spawnRegion2.position;
             Quaternion rotation = Quaternion.identity;
            int spawnPoint = 0;
        foreach (var spawnedplayer in _spawnedPlayerObjects)


            if (spawnedplayer.GetComponent<NetworkAvatarAssigner>().spawnpoints == 0)
            {

                position = _spawnRegion2.position;
                rotation = _spawnRegion2.rotation;
                spawnPoint = 1;

            }
            else

                position = _spawnRegion.position;
                    rotation = _spawnRegion.rotation;

            

            




            //Make object and move it to proper scene.
            NetworkObject nob = Instantiate<NetworkObject>(_playerPrefab, position,rotation);
            nob.GetComponent<NetworkAvatarAssigner>().spawnpoints = spawnPoint;
            UnitySceneManager.MoveGameObjectToScene(nob.gameObject, gameObject.scene);
            _spawnedPlayerObjects.Add(nob);
            base.Spawn(nob.gameObject, conn);

            //NetworkObject netIdent = conn.identity;            
            //   nob.transform.position = next;

            //Assign a avatar
            ClientInstance ci = ClientInstance.ReturnClientInstance(nob.Owner);
            string avatarur = ci.PlayerSettings.GetUsername();
            nob.GetComponent<NetworkAvatarAssigner>().SetAvatarUrl(avatarur);

            //  ObserversTeleport(nob, next);


        }

    
  

    /// <summary>
    /// teleports a NetworkObject to a position.
    /// </summary>
    /// <param name="ident"></param>
    /// <param name="position"></param>
    [ObserversRpc]
    private void ObserversTeleport(NetworkObject ident, Vector3 position)
    {
        ident.transform.position = position;
    }

    /// <summary>
    /// Draw spawn region.
    /// </summary>
  /*  private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireCube(transform.position, _spawnRegion);
    }*/

}
















   




    /*   Vector3 GetSpawnPosition()
       {
           Vector3 position = Vector3.zero;
           if (spawnpoints != null)
           {
               position = spawnpoints.position;
           }
           return position;
       }

       Quaternion GetSpawnRotation()
       {
           Quaternion rotation = Quaternion.identity;
           if (spawnpoints != null)
           {
               rotation = spawnpoints.rotation;
           }
           return rotation;
       }*/



    // Start is called before the first frame update


