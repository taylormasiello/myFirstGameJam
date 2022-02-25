using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.UIElements;
using UnityEngine.Tilemaps;

public class TestTrial : MonoBehaviour
{
    //[SerializeField] GameObject gameCursor;
    //[SerializeField] Grid tilemapGrid;
    //[SerializeField] Tilemap rockTilemap;

    //[SerializeField] GameObject player;
    //[SerializeField] CapsuleCollider2D playerCollider;
    //[SerializeField] Rigidbody2D playerRb;

    //// BRING IN isPickaxe bool from GameCursor.Script
    //// USE FOR MINIG LOGIC: "can only mine when isPickaxe is TRUE"

    ////Collision2D playerToMine;
    //ContactPoint2D[] playToRockContacts = new ContactPoint2D[2];

    //void FixedUpdate()
    //{
    //    //Captures WORLD space for player and cursor
    //    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    Vector3 playerPos = playerRb.transform.position;

    //    //Converts world space click point to tile map click point
    //    Vector3Int mousePosTranslated = rockTilemap.WorldToCell(mousePos);

    //    //Converts player world space to tile map space
    //    Vector3Int playerPosTranslated = rockTilemap.WorldToCell(playerPos);

    //    //Gives clicked on by cursor tile
    //    TileBase clickedTile = rockTilemap.GetTile<TileBase>(mousePosTranslated);

    //    //Gives touched by Kenny tile
    //    TileBase touchedtile = rockTilemap.GetTile<TileBase>(playerPosTranslated);
    //}

    //bool CanMineThisRock(Vector3 pos1, Vector3 pos2, Vector3 comp)
    //{
    //    return System.Math.Abs(pos1.x - pos2.x) <= comp.x && System.Math.Abs(pos1.y - pos2.y) <= comp.y;
    //}

    ////start mining_Action
    //void OnCollisionEnter2D(Collision2D playerToMine)
    //{
    //    //makes grid from rocktilemap
    //    Grid rockTileGrid = rockTilemap.layoutGrid;

    //    //gets array of contact points from collision, makes List from array
    //    playerToMine.GetContacts(playToRockContacts);
    //    List<ContactPoint2D> contactPointsList = new List<ContactPoint2D>(playToRockContacts);

    //    //stores both contactPoints from array into variables
    //    ContactPoint2D collsionPt1 = contactPointsList[0];    // I think the first one is the rock
    //    ContactPoint2D collisionPt2 = contactPointsList[1];   // i think this one is kenny

    //    //get cell coordiantes in which collision points are; converts world position to cell position
    //    Vector3Int collisionCellPos1 = rockTileGrid.WorldToCell(collsionPt1.point);
    //    Vector3Int collisionCellPos2 = rockTileGrid.WorldToCell(collisionPt2.point);


    //    Vector3 collisionVec3Pos1 = rockTileGrid.WorldToCell(collsionPt1.point);
    //    Vector3 collisionVec3Pos2 = rockTileGrid.WorldToCell(collisionPt2.point);
    //    Vector3 maxOffset = new Vector3(2f, 2f, 2f);
    //    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    Vector3 playerPos = playerRb.transform.position;

    //    Vector3Int mousePosTranslated = rockTilemap.WorldToCell(mousePos);
    //    Vector3Int playerPosTranslated = rockTilemap.WorldToCell(playerPos);

    //    //gets TileBase from collision tile
    //    TileBase collisionTile1 = rockTilemap.GetTile(collisionCellPos1);   //rock tile kenny collide w/?
    //    TileBase collisionTile2 = rockTilemap.GetTile(collisionCellPos2);

    //    TileBase clickedTile = rockTilemap.GetTile<TileBase>(mousePosTranslated);
    //    TileBase touchedtile = rockTilemap.GetTile<TileBase>(playerPosTranslated);

    //    if (CanMineThisRock(collisionVec3Pos1, collisionVec3Pos2, maxOffset))
    //    {
    //        Debug.Log("kenny can mine this rock");
    //        if (playerToMine.collider.tag == "Rock" && contactPointsList != null)
    //        {
    //            //UnityEngine.Cursor.SetCursor(miningCursor, Vector2.zero, CursorMode.Auto);
    //            if (Input.GetMouseButtonDown(0))
    //            {
    //                //Debug.Log(string.Format("Coor of cursor is {0} x and {1} y", mousePos.x, mousePos.y));
    //                //Debug.Log(string.Format("Coor of clicked tile is {0} x and {1} y", clickedTile.x, clickedTile.y));

    //                //Debug.Log(string.Format("Coor of player is {0} x and {1} y", playerPos.x, playerPos.y));
    //                //Debug.Log(string.Format("Coor of player touched tile is {0} x and {1} y", touchedtile.x, touchedtile.y));
    //            }

    //        }
    //    }



    //    //do
    //    //{
    //    //    Debug.Log(Input.GetMouseButtonDown(0));
    //    //} while (playerToMine.collider.tag == "Rock" && contactPointsList != null);
    //}

    ////end mining_Action
    //void OnCollisionExit2D(Collision2D playerToMine)
    //{
    //    Grid rockTileGrid = rockTilemap.layoutGrid;
    //    playerToMine.GetContacts(playToRockContacts);
    //    List<ContactPoint2D> contactPointsList = new List<ContactPoint2D>(playToRockContacts);

    //    ContactPoint2D collsionPt1 = contactPointsList[0];
    //    ContactPoint2D collisionPt2 = contactPointsList[1];

    //    Vector3 collisionVec3Pos1 = rockTileGrid.WorldToCell(collsionPt1.point);
    //    Vector3 collisionVec3Pos2 = rockTileGrid.WorldToCell(collisionPt2.point);
    //    Vector3 maxOffset = new Vector3(2f, 2f, 2f);

    //    Vector3Int collisionCellPos1 = rockTileGrid.WorldToCell(collsionPt1.point);
    //    Vector3Int collisionCellPos2 = rockTileGrid.WorldToCell(collisionPt2.point);

    //    TileBase collisionTile1 = rockTilemap.GetTile(collisionCellPos1);
    //    TileBase collisionTile2 = rockTilemap.GetTile(collisionCellPos2);

    //    // collision.collider: find the collider of the gameobj your gameobj hits
    //    if (playerToMine.collider.tag != "Rock")
    //    {
    //        return;
    //    }
    //    else if (contactPointsList != null)
    //    {
    //        //Debug.Log("Kenny is finished mining");
    //    }
    //}





    //[SerializeField] GameObject player;
    //[SerializeField] CapsuleCollider2D playerCollider;
    //[SerializeField] Rigidbody2D playerRb;

    //[SerializeField] Texture2D miningCursor;
    //[SerializeField] Texture2D searchingCursor;

    //[SerializeField] GameObject gameCursor;
    //[SerializeField] UnityEngine.UI.Button backpackBtn;




    // .OnMouseDown <-- "event listener"

    [SerializeField] Grid tilemapGrid;
    [SerializeField] Tilemap rockTilemap;
    [SerializeField] Rigidbody2D playerRb;

    void Update()
    {
        ClickOnTile();
    }

    void ClickOnTile() 
    {
        var playerPos = playerRb.transform.position;
        var playerPosNoZ = new Vector3(playerPos.x, playerPos.y);
        Vector3Int playerTileCell = tilemapGrid.WorldToCell(playerPosNoZ);
        Debug.Log(playerTileCell); //play pos real time (?)

        var tileUnderPlayer = rockTilemap.GetTile(playerTileCell);
        Debug.Log(tileUnderPlayer);// tells you tile under player (?)

        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var mousePosNoZ = new Vector3(mousePos.x, mousePos.y);
        Vector3Int mouseTileCell = tilemapGrid.WorldToCell(mousePosNoZ);
        Debug.Log(mouseTileCell); // cursor pos real time

        var tileUnderCursor = rockTilemap.GetTile(mouseTileCell); 
        Debug.Log(tileUnderCursor); // tells you tile under cursor

        // attempt to make a tile behave like a clickable (button) obj
        //if (Input.GetMouseButtonUp(0))
        //{
        //    var tileUnderMouse = rockTilemap.GetTile(mouseTileCell); // tracking cursor cell pos real-time

        //    if (Input.GetMouseButtonDown(0))
        //    {
        //        Debug.Log("tile click", tileUnderMouse);
        //    }
        //}
    }

}











//[SerializeField] Grid tilemapGrid;
//[SerializeField] Tilemap rockTilemap;

//[SerializeField] GameObject player;
//[SerializeField] CapsuleCollider2D playerCollider;

////Collision2D playerToMine;
//ContactPoint2D[] playToRockContacts = new ContactPoint2D[2];

////Kenny goes to mine
//void OnCollisionEnter2D(Collision2D playerToMine)
//{
//    //makes grid from rocktilemap
//    Grid rockTileGrid = rockTilemap.layoutGrid;

//    //gets array of contact points from collision, makes List from array
//    playerToMine.GetContacts(playToRockContacts);
//    List<ContactPoint2D> contactPointsList = new List<ContactPoint2D>(playToRockContacts);

//    //stores both contactPoints from array into variables
//    ContactPoint2D collsionPt1 = contactPointsList[0];
//    ContactPoint2D collisionPt2 = contactPointsList[1];

//    //get cell coordiantes in which collision points are; converts world position to cell position
//    Vector3Int collisionCellPos1 = rockTileGrid.WorldToCell(collsionPt1.point);
//    Vector3Int collisionCellPos2 = rockTileGrid.WorldToCell(collisionPt2.point);

//    //gets TileBase from collision tile
//    TileBase collisionTile1 = rockTilemap.GetTile(collisionCellPos1);
//    TileBase collisionTile2 = rockTilemap.GetTile(collisionCellPos2);

//    if (!playerCollider.IsTouchingLayers(LayerMask.GetMask("Mining")))
//    {
//        return;
//    }
//    else if (contactPointsList != null)
//    {
//        Debug.Log("Kenny is mining");
//        foreach (var contact in playToRockContacts)
//        {
//            Debug.Log(contact.point);
//        }
//    }
//}

////kenny is finished mining
//void OnCollisionExit2D(Collision2D playerToMine)
//{
//    Grid rockTileGrid = rockTilemap.layoutGrid;
//    playerToMine.GetContacts(playToRockContacts);
//    List<ContactPoint2D> contactPointsList = new List<ContactPoint2D>(playToRockContacts);

//    ContactPoint2D collsionPt1 = contactPointsList[0];
//    ContactPoint2D collisionPt2 = contactPointsList[1];

//    Vector3Int collisionCellPos1 = rockTileGrid.WorldToCell(collsionPt1.point);
//    Vector3Int collisionCellPos2 = rockTileGrid.WorldToCell(collisionPt2.point);

//    TileBase collisionTile1 = rockTilemap.GetTile(collisionCellPos1);
//    TileBase collisionTile2 = rockTilemap.GetTile(collisionCellPos2);

//    // collision.collider: find the collider of the gameobj your gameobj hits
//    if (playerToMine.collider.tag != "Rock")
//    {
//        return;
//    }
//    else if (contactPointsList != null)
//    {
//        Debug.Log("Kenny is finished mining");
//    }
//}

////////////////////void Pickaxe()
////////////////////{
////////////////////    //Captures WORLD space for player and cursor
////////////////////    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
////////////////////    Vector3 playerPos = player.GetComponent<PlayerMovement>().playerWorldPos;

////////////////////    //Converts world space click point to tile map click point
////////////////////    Vector3Int mousePosTranslated = rockTilemap.WorldToCell(mousePos);

////////////////////    //Converts player world space to tile map space
////////////////////    Vector3Int playerPosTranslated = rockTilemap.WorldToCell(playerPos);

////////////////////    //Gives clicked on by cursor tile
////////////////////    TileBase clickedTile = rockTilemap.GetTile<TileBase>(mousePosTranslated);

////////////////////    //Gives touched by Kenny tile
////////////////////    TileBase touchedtile = rockTilemap.GetTile<TileBase>(playerPosTranslated);

////////////////////(mousePosTranslated == playerPosTranslated) \\ (clickedTile == touchedtile)



////foreach (var contact in playToRockContacts)
////{
////    Debug.Log(contact.point); // each elm in arr is a point: (int x, int y)
////    // rockTileGrid.WorldToCell(contact.point); // cell coordinates in which collision point is
////    TileBase collisionTile = rockTilemap.GetTile(rockTileGrid.WorldToCell(contact.point));

////}

////tilemapGrid.WorldToCell(playToRockContacts);
////rockTilemap.GetInstantiatedObject();

////}

