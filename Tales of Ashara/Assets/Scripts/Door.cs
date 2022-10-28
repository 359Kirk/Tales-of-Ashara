using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Door : MonoBehaviourPun
{
    public Transform Destination;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!PhotonNetwork.IsMasterClient)
            return;

        if (collision.CompareTag("Player"))
        {
            Debug.Log("player encountered");
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            player.transform.position = Destination.position;
            Debug.Log("player transported");
        }
    }
}
