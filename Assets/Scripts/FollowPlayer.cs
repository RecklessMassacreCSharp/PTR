using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    Dictionary<string, int> nameMapper = new Dictionary<string, int>();
    Dictionary<string, Vector3> offsetMapper = new Dictionary<string, Vector3>();

    GameObject player;
    Vector3 offset;

    void Start()
    {
        nameMapper.Add("Bus", 25);
        nameMapper.Add("Car", 25);
        nameMapper.Add("Van", 27);

        offsetMapper.Add("Bus", new Vector3(0, 7.27f, -9.03f));
        offsetMapper.Add("Car", new Vector3(0, 6.14f, -6.6f));
        offsetMapper.Add("Van", new Vector3(0, 6.49f, -6.68f));

        GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        player = gameManager.obj;

        string vehName = player.name.Substring(0, player.name.LastIndexOf("(")); 
        offset = offsetMapper[vehName];
        Quaternion target = Quaternion.Euler(nameMapper[vehName], 0, 0);
        transform.rotation = target;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
