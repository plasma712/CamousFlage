using UnityEngine;
using System.Collections;
public class PickUpItem : MonoBehaviour
{
    public Item item;
    private Inventory _inventory;
    private GameObject _player;
    /// <summary>
    /// 
    /// </summary>
    private GameObject target;



    // Use this for initialization

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        if (_player != null)
            _inventory = _player.GetComponent<PlayerInventory>().inventory.GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_inventory != null && Input.GetMouseButtonDown(0))
        {
            float distance = Vector3.Distance(this.gameObject.transform.position, _player.transform.position);
            
            target = GetClickedObject() ;

            if (target.Equals(gameObject))
            {
                bool check = _inventory.checkIfItemAllreadyExist(item.itemID, item.itemValue);
                if (check)
                    Destroy(this.gameObject);
                else if (_inventory.ItemsInInventory.Count < (_inventory.width * _inventory.height))
                {
                    _inventory.addItemToInventory(item.itemID, item.itemValue);
                    _inventory.updateItemList();
                    _inventory.stackableSettings();
                    Destroy(this.gameObject);
                }

            }
        }
    }

    private GameObject GetClickedObject() 
    {
        RaycastHit hit;
        GameObject target = null; 
 
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //마우스 포인트 근처 좌표를 만든다. 
         

        if( true == (Physics.Raycast(ray.origin, ray.direction * 10, out hit)))   //마우스 근처에 오브젝트가 있는지 확인
        {
            //있으면 오브젝트를 저장한다.
            target = hit.collider.gameObject; 
        } 
 
        return target; 
    } 
}






